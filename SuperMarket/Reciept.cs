using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Reciept : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet DS;
        string constr = "data source=orcl; user id=scott; password=tiger;";
        string cmdstr = "";
        public Reciept()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            cmdstr = "select pname, quantity from ordereditems where OID =:id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", Order.OID);
            DS = new DataSet();
            adapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

            cmdstr = "select price from customerorder where OID =:id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("id", Order.OID);
            DS = new DataSet();
            adapter.Fill(DS);
            TotalPrice.Text = DS.Tables[0].Rows[0]["Price"].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
