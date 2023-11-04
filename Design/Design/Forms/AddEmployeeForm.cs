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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            
        }
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bloodGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ClearField()
        {
            nameTextBox.Text = string.Empty;
            nationalityTextBox.Text = string.Empty;
            maritalcomboBox.Text = string.Empty;
            positionTextBox.Text = string.Empty;
            religioncomboBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            bloodGroupComboBox.Text = string.Empty;
            dateOfBirthDateTimePicker.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            maleRadioButton.Text = string.Empty;
            femaleRadioButton.Text = string.Empty;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (positionTextBox.Text == "")
            {
                MessageBox.Show("Position cannot be empty");
            }
            else if (nationalityTextBox.Text == "")
            {
                MessageBox.Show("Nationality cannot be empty");
            }
            else if (religioncomboBox.Text == "")
            {
                MessageBox.Show("Select a religion");
            }
            else if (salaryTextBox.Text == "")
            {
                MessageBox.Show("Salary cannot be empty");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Address cannot be empty");
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be empty");
            }
            else if (dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Select a date");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("Select a blood group");
            }
            else if (maritalcomboBox.Text == "")
            {
                MessageBox.Show("Select a marital status");
            }
            else
            {
                Employee employee = new Employee();
                employee.Name = nameTextBox.Text;
                employee.Position = positionTextBox.Text;
                employee.Salary = salaryTextBox.Text;
                employee.Address = addressTextBox.Text;
                employee.Nationality = nationalityTextBox.Text;
                employee.Email = emailTextBox.Text;
                employee.DateOfBirth = dateOfBirthDateTimePicker.Text;
                if (maleRadioButton.Checked)
                {
                    employee.Gender = "Male";
                }
                else
                {
                    employee.Gender = "Female";
                }
                employee.BloodGroup = bloodGroupComboBox.Text;
                employee.Religion = religioncomboBox.Text;
                employee.MaritialStatus = maritalcomboBox.Text;

                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                if (employeeDataAccess.AddEmployee(employee))
                {
                    MessageBox.Show("Employee registered");
                    Form_Employee form_Employee = new Form_Employee();
                    form_Employee.UpdateGridView();
                    ClearField();

                }
                else
                {
                    MessageBox.Show("Employee registration error");
                }
            }
        }

       
    }
}