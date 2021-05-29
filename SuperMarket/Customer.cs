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

    public partial class Customer : Form
    {
        string ordp = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection Conn;
        public static int CustomerID;
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(ordp);
            Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "GetIDs";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                CustIDs.Items.Add(DR[0]);
            }
            DR.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {           
            OracleCommand C1 = new OracleCommand();
            C1.Connection = Conn;
            C1.CommandText = "Select * from customer where CID=:id";
            C1.CommandType = CommandType.Text;
            C1.Parameters.Add("id", CustIDs.Text);
            int ret = C1.ExecuteNonQuery();

            if (CustIDs.Text != null && Cust_Name.Text != null && Cust_Phone.Text != null && Cust_Address.Text != null)
            {
                MessageBox.Show(
                   "Invalid Data, Try Again",
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = Conn;
                cmd2.CommandText = "INSERT INTO customer Values(:CID, :CName, :CPhone, :CAddress)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("CID", CustIDs.Text);
                cmd2.Parameters.Add("CName", Cust_Name.Text);
                cmd2.Parameters.Add("CPhone", Cust_Phone.Text);
                cmd2.Parameters.Add("CAddress", Cust_Address.Text);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    CustIDs.Items.Add(CustIDs.Text);
                    MessageBox.Show("Customer Added Successfully");
                }

            }
            catch
            {
                MessageBox.Show(
                    "Invalid Data, Try Again",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }    
        private void CustIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "SELECT name, phone, address FROM customer WHERE Cid = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", CustIDs.SelectedItem.ToString());
            OracleDataReader DR = cmd.ExecuteReader();
            if (DR.Read())
            {
                Cust_Name.Text = DR[0].ToString();
                Cust_Phone.Text = DR[1].ToString();
                Cust_Address.Text = DR[2].ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "UpdateCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", CustIDs.Text);
            cmd.Parameters.Add("name", Cust_Name.Text);
            cmd.Parameters.Add("phone", Cust_Phone.Text);
            cmd.Parameters.Add("address", Cust_Address.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "Delete From Customer where cid = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", CustIDs.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                CustIDs.Items.Remove(CustIDs.Text);
                Cust_Name.Text = "";
                Cust_Phone.Text = "";
                Cust_Address.Text = "";
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerID = int.Parse(CustIDs.Text);
                Order form = new Order();
                form.Show();
            }
            catch
            {
                MessageBox.Show(
                    "Please Enter Customer ID",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }
    }
}
