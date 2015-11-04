using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class LoginForm : Form
    {
        private string login = "admin";
        private string password = "admin";


        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == login && passwordBox.Text == password)
            {
                this.Hide();
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Authentication failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
