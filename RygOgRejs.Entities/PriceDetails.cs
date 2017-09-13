using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejs.Entities
{
    public class PriceDetails
    {
        private decimal destinationPrice;
        private decimal firstClassPrice;
        private decimal luggagePrice;
        private const double taxRate = 0.25; //moms
        public PriceDetails(decimal destinationPrice, decimal firstClassPrice,decimal luggagePrice)
        {
            this.destinationPrice = destinationPrice;
            this.firstClassPrice = firstClassPrice;
            this.luggagePrice = luggagePrice;
        }


        //TODO just return calculation when program is up running
        public decimal GetTaxAmount()
        {
            decimal tax = (destinationPrice + firstClassPrice + luggagePrice) * (decimal)taxRate;
            return tax;
        }

        //TODO sometihn
        public decimal GetTotalWithoutTax()
        {
            return destinationPrice + firstClassPrice + luggagePrice;
        }

        public decimal GetTotalWithTax()
        {
            decimal test = ((destinationPrice + firstClassPrice + luggagePrice)) * ((decimal)taxRate + 1);
            return Math.Round(test); //rounder up
        }
    }
}
