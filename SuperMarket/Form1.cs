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
                
                if (dr.Read())
                {

                    var isManager = dr[0].ToString();

                    if (isManager.Equals(""))
                    {
                        this.Hide();
                        managerForm mangForm = new managerForm();
                        mangForm.Show(); //manager form
                    }
                    else
                    {
                        this.Hide();
                        employeeForm empForm = new employeeForm();
                        empForm.Show(); //employee form
                    }

                }
                
                else
                {
                    MessageBox.Show("Incorrect email or password");
                    userIdTextBox.Text = "";
                    passwordTextBox.Text = "";

                }
                dr.Close();
                

                //Sara@gmail.com 123456 employee
                //Maria@gmail.com 1010 manager 1
                //Rana@gmail.com 2323 manager 2

                
              
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
            conn.Close();
            Application.Exit();
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            //Application.Exit();
        }
    }
}
