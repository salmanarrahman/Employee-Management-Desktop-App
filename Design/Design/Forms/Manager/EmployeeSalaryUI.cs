using Design.Forms.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms.Manager
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }
        void ClearField()
        {
            employeeIdTextBox.Text = string.Empty;
            employeeSalaryTextBox.Text = string.Empty;
        }

        void UpdateGridView()
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeListDataGridView.DataSource = employeeDataAccess.GetEmployees();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (employeeIdTextBox.Text == "")
            {
                MessageBox.Show("Give an employee Id");
            }
            else if (employeeSalaryTextBox.Text == "")
            {
                MessageBox.Show("Give an employee status");
            }
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                if (employeeDataAccess.UpdateEmployeeSalary(Convert.ToInt32(employeeIdTextBox.Text), employeeSalaryTextBox.Text))
                {
                    MessageBox.Show("Employee salary updated");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error in employee salary update");
                }
            }
        }

        private void EmployeeSalaryUI_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeListDataGridView.DataSource = employeeDataAccess.GetEmployees();

            TextWriter writer = new StreamWriter(@"C:\Users\emoni\salary.txt");
            writer.WriteLine("\t       Details of Employees And Monthly Salary  ");
            for (int i = 0; i <employeeListDataGridView.Rows.Count - 1; i++)
            {

                for (int j = 0; j <employeeListDataGridView.Columns.Count; j++)
                {

                    writer.Write("\t" + employeeListDataGridView.Rows[i].Cells[j].Value.ToString() + "\t");

                }
                writer.WriteLine(" ");

            }
            writer.Close();
            MessageBox.Show("Salary Sheet Exported");
        }
    }
}
