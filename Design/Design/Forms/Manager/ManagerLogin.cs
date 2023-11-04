using Design.Forms.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms.Manager
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

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
                UserDataAccess manager = new UserDataAccess();
                if (manager.LoginValidationManager(usernameTextBox.Text, passwordTextBox.Text))
                {
                    this.Hide();
                    ManagerUI man = new ManagerUI();
                    man.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void ManagerLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
