using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SuperMarket
{
    
    public partial class Order : Form
    {
        string ordp = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection Conn;
        int Prices = 0;
        
        int OID = -1;
        public Order()
        {
            InitializeComponent();
        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.Text = Products.SelectedItem.ToString();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = Conn;
            cmd1.CommandText = "select price from product where name=:n";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("name", Item.Text);
            OracleDataReader DR = cmd1.ExecuteReader();
            if (DR.Read())
            {
                Price.Text = DR[0].ToString();
            }
            DR.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(ordp);
            Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "select name from product";
            cmd.CommandType = CommandType.Text;          
            OracleDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                Products.Items.Add(DR[0]);
            }
            DR.Close();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = Conn;
            cmd1.CommandText = "GetOrderID";
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd1.ExecuteNonQuery();
            int maxID;
            try
            {
                maxID = int.Parse(cmd1.Parameters["id"].Value.ToString());
                OID = maxID + 1;
            }
            catch
            {
                OID = 1;
            }
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = Conn;
            cmd2.CommandText = "INSERT INTO customerorder Values(:OID, :CID, :Price)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("OID", OID);
            cmd2.Parameters.Add("CID", null);
            cmd2.Parameters.Add("Price", null);
            cmd2.ExecuteNonQuery();
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            int Q = 0;
            OracleCommand C = new OracleCommand();
            C.Connection = Conn;
            C.CommandText = "SELECT quantity from product where name = :pname";
            C.CommandType = CommandType.Text;
            C.Parameters.Add("pname", Item.Text);
            OracleDataReader DR = C.ExecuteReader();
            if (DR.Read())
            {
                Q = int.Parse(DR[0].ToString());
            }         
            if (Q >= int.Parse(Quant.Text))
            {
                Prices += (int.Parse(Price.Text) * int.Parse(Quant.Text));
                OracleCommand C2 = new OracleCommand();
                C2.Connection = Conn;
                C2.CommandText = "UpdateQuantity";
                C2.CommandType = CommandType.StoredProcedure;
                C2.Parameters.Add("q", Quant.Text);
                C2.ExecuteNonQuery();
                OracleCommand COrderedItems = new OracleCommand();
                COrderedItems.Connection = Conn;
                COrderedItems.CommandText = "INSERT INTO OrderedItems Values(:Pname,:OID,:quantity)";
                COrderedItems.CommandType = CommandType.Text;
                COrderedItems.Parameters.Add("Pname", Item.Text);
                COrderedItems.Parameters.Add("OID", OID);
                COrderedItems.Parameters.Add("quantity", Quant.Text);
                int s = COrderedItems.ExecuteNonQuery();
                if (s != -1)
                {
                    Products.Text = "";
                    Item.Text = "";
                    Quant.Text = "";
                    Price.Text = "";
                    MessageBox.Show("Item Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Item is not Available");
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        { 
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = Conn;
            cmd2.CommandText = "Update customerorder set customerid=:CID, Price=:Price where OID=:iD";
            cmd2.CommandType = CommandType.Text;           
            cmd2.Parameters.Add("CID", Customer.CustomerID);
            cmd2.Parameters.Add("Price", Prices);
            cmd2.Parameters.Add("id", OID);
            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Order Added Successfully");
            }

            this.Close();

        }

  
        private void Qunat_TextChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
