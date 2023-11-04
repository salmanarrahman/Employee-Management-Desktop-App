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
    public partial class CoustomersUI : Form
    {
        public CoustomersUI()
        {
            InitializeComponent();
        }

        private void CoustomersUI_Load(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerDataGridView.DataSource = customerDataAccess.GetCustomers();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (customerIdTextBox.Text == "")
            {
                MessageBox.Show("Give a customer Id");
            }
            else
            {
                CustomerDataAccess customerDataAccess = new CustomerDataAccess();
                customerDataGridView.DataSource = customerDataAccess.GetCustomerListById(Convert.ToInt32(customerIdTextBox.Text));
            }
            }
    }
}
