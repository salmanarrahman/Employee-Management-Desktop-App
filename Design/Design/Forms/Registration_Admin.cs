using Design.Forms.DataAccessLayer;
using Design.Forms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms
{
    public partial class Registration_Admin : Form
    {
        public Registration_Admin()
        {
            InitializeComponent();
        }
        void ClearField()
        {
            nameTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Usernme cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("Confirm passwrod cannot be empty");
            }

            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match");
                }
                else
                {
                    Admin admin = new Admin();
                    admin.Name = nameTextBox.Text;
                    admin.UserName = usernameTextBox.Text;
                    admin.Password = passwordTextBox.Text;
                    UserDataAccess adminDataAccess = new UserDataAccess();
                    if (adminDataAccess.AddAdmin(admin))
                    {
                        MessageBox.Show("Admin registered");
                        ClearField();
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }
                }
            }
        }

        private void Registration_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
