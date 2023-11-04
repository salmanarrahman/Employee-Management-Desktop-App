using Design.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class AdminUI : Form
    {

        Button currentButon;
        Random random;
        int tempIndex;
        private Form activeForm;

        public AdminUI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1000, 600);
            random = new Random();
        }

        private Color SelectThemeColor() {

            int index = random.Next(themecolor.colorList.Count);
            while (tempIndex == index) {
                index = random.Next(themecolor.colorList.Count);
               }
            tempIndex = index;
            string color = themecolor.colorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 255, 255);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void ActivateButton(object btnSender) {

            DisableButton();
            if (btnSender != null) {
                Color color = SelectThemeColor();
                currentButon = (Button)btnSender;
                currentButon.BackColor = color;
                currentButon.ForeColor = Color.White;
                currentButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            }         

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
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

        private void btnproduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Employee(), sender);
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Offer(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_Customer(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Form_GenerateManager(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void paneltitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paneldesktoppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();

        }

        private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
