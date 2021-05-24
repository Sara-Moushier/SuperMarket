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

   

    public partial class loginForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
             
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText ="select supervisorID from EMPLOYEE where email = '" + userIdTextBox.Text.TrimStart()
                          + "'and passowrd = '" + passwordTextBox.Text.TrimStart() + "'";


                c.CommandType = CommandType.Text;
                c.Parameters.Add("email", userIdTextBox.ToString());
                c.Parameters.Add("password", passwordTextBox.ToString());     
                OracleDataReader dr = c.ExecuteReader();
                string var =null;
                if (dr.Read())
                {
                    var = dr[0].ToString();
                }
                dr.Close();
                managerForm f2 = new managerForm();
                employeeForm f3 = new employeeForm();

                //sara@gmail.com 123456 employee
                //Maria@gmail.com 1010 manager 1
                //Rana@gmail.com 2323 manager 2

                if (var.Equals("1")|| var.Equals("2"))
                    f2.Show(); //manager form
                else
                    f3.Show(); //employee form
              
            }
            


        }

        private bool isValid()
        {
            if(userIdTextBox.Text.TrimStart()==string.Empty )
            {
                MessageBox.Show("Please enter a valid ID!", "Error");
                return false;
            }
            else if (passwordTextBox.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Please enter a valid Password!", "Error");
                return false;
            }
                return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
