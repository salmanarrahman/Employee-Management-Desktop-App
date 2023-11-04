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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
            this.Size = new Size(800, 800);
        }

        private void searchEmpNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            searchEmployeeListGridView.DataSource = employeeDataAccess.GetEmployeeListByName(searchEmpNameTextBox.Text);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
          
        
            if (searchEmpIdTextBox.Text == "")
            {
                MessageBox.Show("Give an employee Id");
            }
           
           
            else
            {
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                searchEmployeeListGridView.DataSource = employeeDataAccess.GetEmployeeListById(Convert.ToInt32(searchEmpIdTextBox.Text));
            }

        }

        private void searchEmployeeListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            
                EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
                searchEmployeeListGridView.DataSource = employeeDataAccess.GetEmployees();
            
        }
    }
}
