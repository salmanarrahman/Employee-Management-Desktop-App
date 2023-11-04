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
    public partial class Form_Offer : Form
    {
        public Form_Offer()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateOffers cf = new CreateOffers();
            cf.ShowDialog();
        }

        private void Form_Offer_Load(object sender, EventArgs e)
        {
            OfferDataAccess offerDataAccess = new OfferDataAccess();
            offerListGridView.DataSource = offerDataAccess.GetOffers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OfferDataAccess offerDataAccess = new OfferDataAccess();
            offerListGridView.DataSource = offerDataAccess.ShowOffers();
        }
    }
}
