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

namespace Design.Forms
{
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            AddEmployeeForm afm = new AddEmployeeForm();
            afm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm up = new UpdateEmployeeForm();
            up.ShowDialog();
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            RemoveEmployee rm = new RemoveEmployee();
            rm.ShowDialog();
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            SearchEmployee sm = new SearchEmployee();
            sm.ShowDialog();
        }
        public void UpdateGridView()
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeListGridView.DataSource = employeeDataAccess.GetEmployees();
        } 
        private void Form_Employee_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
