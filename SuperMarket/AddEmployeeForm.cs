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
    public partial class AddEmployeeForm : Form
    {
        string ordp = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection Conn;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            Conn = new OracleConnection(ordp);
            Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Conn;
            cmd.CommandText = "select name from department";
            cmd.CommandType = CommandType.Text;
            OracleDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                cmb_dept.Items.Add(r[0]);
            }
            r.Close();
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
           
            string pass = passtxt.Text;
            string cpass = Cpasstxt.Text;
            if (pass != cpass)
            {
                MessageBox.Show("Password Not match");

            }
            else
            {
                string dept = cmb_dept.SelectedItem.ToString();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = Conn;
                cmd2.CommandText = "select DID,managerid from department where name = :name";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("deptname", dept);

                OracleDataReader dr = cmd2.ExecuteReader();
                int deptId = 2;
                int superid = 2;
                while (dr.Read())
                {
                    deptId = Convert.ToInt32(dr[0]);
                    superid = Convert.ToInt32(dr[1]);
                }
                dr.Close();
                string Name = Nametxt.Text;
                string email = Emailtxt.Text;

                int salary = 100;
                DateTime date = DateTime.Now;
                string Phone = phonetxt.Text;
                string Address = Adresstxt.Text;
                string jobtitle = Jobtxt.Text;
              

                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = Conn;
                cmd3.CommandText = "ADDEMPLOYEE";
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.Add("name", Name);
                cmd3.Parameters.Add("dept", deptId);
                cmd3.Parameters.Add("email", email);
                cmd3.Parameters.Add("pass", pass);
                cmd3.Parameters.Add("salary", salary);
                cmd3.Parameters.Add("date", date);
                cmd3.Parameters.Add("phone", Phone);
                cmd3.Parameters.Add("Add", Address);
                cmd3.Parameters.Add("job", jobtitle);
                cmd3.Parameters.Add("supid", superid);
                int x = cmd3.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfully");
                
              
            }

        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conn.Dispose();
            this.Hide();
            managerForm mangForm = new managerForm();
            mangForm.Show(); //manager form
            //Application.Exit();
        }
    }
}
