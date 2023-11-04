using Design.Forms.DataAccessLayer;
using Design.Forms.Manager;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password cannot be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty");
            }
            else
            {
                UserDataAccess admin = new UserDataAccess();
                if (admin.LoginValidationAdmin(usernameTextBox.Text, passwordTextBox.Text))
                {
                    this.Hide();
                    AdminUI adminUi = new AdminUI();
                    adminUi.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }

        private void btnLoginManger_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin ml = new ManagerLogin();
            ml.ShowDialog();
           

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   this.Hide();
            Registration_Admin reg = new Registration_Admin();
            reg.Show();
        }
    }
}
