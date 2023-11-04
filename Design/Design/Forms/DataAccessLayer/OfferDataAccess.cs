using Design.Forms.Enitity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Forms.DataAccessLayer
{
    class OfferDataAccess:DataAccess
    {
        public List<OfferEntity> GetOffers()
        {
            string sql = "SELECT OfferId,OfferTitle,InterestRate,Description FROM Offers";
            SqlDataReader reader = this.GetData(sql);
            List<OfferEntity> offers = new List<OfferEntity>();
            while (reader.Read())
            {
                OfferEntity offer = new OfferEntity();
                offer.OfferId = (int)reader["OfferId"];
                offer.OfferTitle = reader["OfferTitle"].ToString();
                offer.InterestRate = reader["InterestRate"].ToString();
                offer.Description = reader["Description"].ToString();
                offers.Add(offer);
            }
            return offers;
        }

        public List<OfferEntity> ShowOffers()
        {
            string sql = "SELECT * FROM Offers";
            SqlDataReader reader = this.GetData(sql);
            List<OfferEntity> offers = new List<OfferEntity>();
            while (reader.Read())
            {
                OfferEntity offer = new OfferEntity();
                offer.OfferId = (int)reader["OfferId"];
                offer.OfferTitle = reader["OfferTitle"].ToString();
                offer.InterestRate = reader["InterestRate"].ToString();
                offer.Description = reader["Description"].ToString();
                offer.Approval = reader["Approval"].ToString();
                offers.Add(offer);
            }
            return offers;
        }
     /*   public OfferEntity GetOfferById(int offerId)
        {
            string sql = "SELECT * FROM Offers WHERE OfferId=" + offerId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                OfferEntity offer = new OfferEntity();
                offer.OfferId = (int)reader["OfferId"];
                offer.OfferTitle = reader["OfferTitle"].ToString();
                offer.InterestRate = reader["InterestRate"].ToString();
                offer.Description = reader["Description"].ToString();
                return offer;
            }
            return null;

        }*/

        public bool AddOffer(OfferEntity offer)
        {
            string sql = "INSERT INTO Offers(OfferTitle,InterestRate,Description) VALUES('" + offer.OfferTitle + "','" + offer.InterestRate + "','" + offer.Description + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateOffer(int offerId,string status)
        {
            string sql = "UPDATE Offers SET Approval='" + status + "' WHERE OfferId=" + offerId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
