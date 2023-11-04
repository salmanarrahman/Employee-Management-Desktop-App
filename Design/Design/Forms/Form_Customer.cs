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
    public partial class Form_Customer : Form
    {
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            searchCustomerGridView.DataSource = customerDataAccess.GetCustomerListByName(customerSearchTextBox.Text);
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerGridView.DataSource = customerDataAccess.GetCustomers();
        }
    }
}
