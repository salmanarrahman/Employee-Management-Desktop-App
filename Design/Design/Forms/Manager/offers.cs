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
    public partial class offers : Form
    {
        public offers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (offerIdTextBox.Text == "")
            {
                MessageBox.Show("Give an offer Id");
            }
            else if (offerStatusComboBox.Text == "")
            {
                MessageBox.Show("Select an offer status");
            }
            else
            {
                OfferDataAccess offerDataAccess = new OfferDataAccess();
                if(offerDataAccess.UpdateOffer(Convert.ToInt32(offerIdTextBox.Text), offerStatusComboBox.Text))
                {
                    MessageBox.Show("Offer is confirmed");
                }
                else
                {
                    MessageBox.Show("Error in offer confirmation");
                }
            }
        }

        private void offerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        void UpdateGridView()
        {
            OfferDataAccess offerDataAccess = new OfferDataAccess();
            offerListDataGridView.DataSource = offerDataAccess.ShowOffers();
        }

        private void offers_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }
    }
}
