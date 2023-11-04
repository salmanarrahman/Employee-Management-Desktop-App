using Design.Forms.DataAccessLayer;
using Design.Forms.Enitity;
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
    public partial class CreateOffers : Form
    {
        public CreateOffers()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void ClearField()
        {
            offerTitleTextBox.Text = string.Empty;
            interestRateTextBox.Text = string.Empty;
            DescripRichTextBox.Text = string.Empty;
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            if (offerTitleTextBox.Text == "")
            {
                MessageBox.Show("Offer title cannot be empty");
            }
            else if (interestRateTextBox.Text=="")
            {
                MessageBox.Show("Interest rate cannot be empty");
            }
            else if (DescripRichTextBox.Text == "")
            {
                MessageBox.Show("Description cannot be empty");
            }
            else
            {
                OfferEntity offer = new OfferEntity();
                offer.OfferTitle = offerTitleTextBox.Text;
                offer.InterestRate = interestRateTextBox.Text;
                offer.Description = DescripRichTextBox.Text;

                OfferDataAccess offerDataAccess = new OfferDataAccess();
                if (offerDataAccess.AddOffer(offer))
                {
                    MessageBox.Show("Offer is created");
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Error in creating");
                }
            }
        }

      
    }
}
