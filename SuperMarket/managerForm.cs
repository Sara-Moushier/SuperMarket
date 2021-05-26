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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddSupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void managerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }
    }
}
