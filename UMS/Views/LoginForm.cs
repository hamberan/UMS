using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.Controllers;

namespace UMS.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Login button click
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // call login function
                string role = LoginController.Login(username, password);

                if (role != null)
                {
                    // Login success
                    MessageBox.Show($"Login Successful! Role: {role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminMainForm adminForm = new AdminMainForm();
                    adminForm.Show();
                    this.Hide(); 
                    
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}


