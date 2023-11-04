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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
            
        }
        void ClearField (){
            deleteEmpIdTextBox.Text = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteEmpIdTextBox.Text == "")
            {
                MessageBox.Show("Please give employee ID");
            }
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                Employee employee = employeeDataAccess.GetEmployeeById(Convert.ToInt32(deleteEmpIdTextBox.Text));

                if (employee == null)
                {
                    MessageBox.Show("Employee is not found");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure to remove Employee", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form_Employee form_Employee = new Form_Employee();
                        employeeDataAccess = new EmployeeDataAccess();
                        if (employeeDataAccess.RemoveEmployee(Convert.ToInt32(deleteEmpIdTextBox.Text)))
                        {
                            MessageBox.Show("Employee has been removed");
                            form_Employee.UpdateGridView();
                            ClearField();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error in employee details deleting");
                        }

                    }
                    
                    
                }
            }
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
