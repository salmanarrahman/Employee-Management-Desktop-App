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
    public partial class ManagerUI : Form
    {

        private Form activeForm;
        public ManagerUI()
        {
            InitializeComponent();
            this.Size = new Size(1000, 620);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();           
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneldesktoppanel.Controls.Add(childForm);
            this.paneldesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // guestLabel.Text = childForm.Text;
        }

        private void btnorders_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Manager.offers());
        }

        private void btncustomer_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Manager.EmployeeSalaryUI());
        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Manager.CoustomersUI());
        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();

        }

        private void ManagerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
