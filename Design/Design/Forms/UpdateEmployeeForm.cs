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
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            this.Size = new Size(800, 700);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        void ClearField()
        {
            updateEmpIdTextBox.Text = string.Empty;
            updateNameTextBox.Text = string.Empty;
            updateNationalityTextBox.Text = string.Empty;
            updateMaritalcomboBox.Text = string.Empty;
            updatePositionTextBox.Text = string.Empty;
            updateReligioncomboBox.Text = string.Empty;
            updateSalaryTextBox.Text = string.Empty;
            updateAddressTextBox.Text = string.Empty;
            updateBloodGroupComboBox.Text = string.Empty;
            updateDateOfBirthDateTimePicker.Text = string.Empty;
            updateEmailTextBox.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (updateEmpIdTextBox.Text == "")
            {
                MessageBox.Show("Please give employee ID");
            }
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                Employee employee = employeeDataAccess.GetEmployeeById(Convert.ToInt32(updateEmpIdTextBox.Text));

                if (employee == null)
                {
                    MessageBox.Show("Employee is not found");
                }
                else
                {
                    updateNameTextBox.Text = employee.Name;
                    updateNationalityTextBox.Text = employee.Nationality;
                    updateMaritalcomboBox.Text = employee.MaritialStatus;
                    updatePositionTextBox.Text = employee.Position;
                    updateReligioncomboBox.Text = employee.Religion;
                    updateSalaryTextBox.Text = employee.Salary;
                    updateAddressTextBox.Text = employee.Address;
                    updateBloodGroupComboBox.Text = employee.BloodGroup;
                    updateDateOfBirthDateTimePicker.Text = employee.DateOfBirth;
                    updateEmailTextBox.Text = employee.Email;
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.Name = updateNameTextBox.Text;
            employee.Nationality = updateNationalityTextBox.Text;
            employee.MaritialStatus =updateMaritalcomboBox.Text ;
            employee.Position =updatePositionTextBox.Text ;
            employee.Religion = updateReligioncomboBox.Text ;
            employee.Salary=updateSalaryTextBox.Text ;
            employee.Address=updateAddressTextBox.Text;
            employee.BloodGroup = updateBloodGroupComboBox.Text;
            employee.DateOfBirth= updateDateOfBirthDateTimePicker.Text ;
            employee.Email= updateEmailTextBox.Text ;

            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            Form_Employee form_Employee = new Form_Employee();

            if (employeeDataAccess.UpdateEmployee(employee, Convert.ToInt32(updateEmpIdTextBox.Text)))
            {
                MessageBox.Show("Employee details updated");
                form_Employee.UpdateGridView();
                ClearField();
                
            }
            else
            {
                MessageBox.Show("Error in employee details updating");
            }
        }

       
    }
}
