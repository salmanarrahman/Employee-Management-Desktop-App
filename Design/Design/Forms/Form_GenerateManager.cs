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
    public partial class Form_GenerateManager : Form
    {
        public Form_GenerateManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void UpdateGridview()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            managerDataGridView.DataSource = managerDataAccess.GetManager();
        }

        void ClearField()
        {
            nameTextBox.Text = string.Empty;
            usernameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;
            deleteManagerIdTextBox.Text = string.Empty;

        }
        private void Add_button_Click(object sender, EventArgs e)
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
                    ManagerEntity manager = new ManagerEntity();
                    manager.Name = nameTextBox.Text;
                    manager.Username = usernameTextBox.Text;
                    manager.Password = passwordTextBox.Text;
                    ManagerDataAccess managerDataAccess = new ManagerDataAccess();
                    if (managerDataAccess.AddManager(manager))
                    {
                        MessageBox.Show("Manager added");
                        UpdateGridview();
                        ClearField();
                    }
                    else
                    {
                        MessageBox.Show("Error in adding");
                    }

                }
            }
        }

        private void Form_GenerateManager_Load(object sender, EventArgs e)
        {
            UpdateGridview();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteManagerIdTextBox.Text == "")
            {
                MessageBox.Show("Please give employee ID");
            }
            else
            {
                ManagerDataAccess managerDataAccess = new ManagerDataAccess();
                ManagerEntity manager = managerDataAccess.GetByManagerId(Convert.ToInt32(deleteManagerIdTextBox.Text));

                if (manager == null)
                {
                    MessageBox.Show("Manager is not found");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure to remove Manager", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                             managerDataAccess = new ManagerDataAccess();
                        if (managerDataAccess.DeleteManager(Convert.ToInt32(deleteManagerIdTextBox.Text)))
                        {
                            MessageBox.Show("Manager has been removed");
                            UpdateGridview();
                            ClearField();
                            
                        }
                        else
                        {
                            MessageBox.Show("Error in employee details deleting");
                        }
                    }
                }
            }
        }
    }
}
