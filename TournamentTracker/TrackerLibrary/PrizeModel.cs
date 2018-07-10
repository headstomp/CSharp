using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a place and prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the place number (1,2,3)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place name (Champion, First Runner Up, Second Runner Up
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the Prize amount in $
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
