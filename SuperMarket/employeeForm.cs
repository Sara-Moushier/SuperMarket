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
    public partial class employeeForm : Form
    {
        public employeeForm()
        {
            InitializeComponent();
        }
       

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customerForm = new Customer();
            customerForm.Show();

        }

        private void employeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
