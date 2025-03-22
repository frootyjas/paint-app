using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string validUser = "admin";
            const string validPass = "password123";

            if (txtUsername.Text == validUser && txtPassword.Text == validPass)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
