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

        private decimal billundA = 395.00M;
        private decimal billundC = 295.00M;

        private decimal copenhagenA = 1595;
        private decimal copenhagenC = 1395;

        private decimal palA = 4995;
        private decimal palC = 3089;

        private decimal totalPrice = 0;

        public PriceDetails(Destination destination, int adults,int children,bool isFirstClass, double luggageAmount)
        {
            if(destination == Destination.Billund )
            {
                destinationPrice = adults * billundA + children * billundC;
                if (isFirstClass == true)
                    firstClassPrice = 1699;
                else
                    firstClassPrice = 0;
                if (luggageAmount > 25)
                    luggagePrice = ((decimal)luggageAmount - 25) * 290;
                else
                    luggagePrice = 0;
                totalPrice = luggagePrice + (firstClassPrice * adults * children) + destinationPrice;
            }
            else if (destination == Destination.Copenhagen)
            {
                destinationPrice = adults * copenhagenA + children * copenhagenC;
                if (isFirstClass == true)
                    firstClassPrice = 1699;
                else
                    firstClassPrice = 0;
                if (luggageAmount > 25)
                    luggagePrice = ((decimal)luggageAmount - 25) * 290;
                else
                    luggagePrice = 0;
                totalPrice = luggagePrice + (firstClassPrice * adults * children) + destinationPrice;
            }
            else if (destination == Destination.PalmaDeMalkorca)
            {
                destinationPrice = adults * palA + children * palC;
                if (isFirstClass == true)
                    firstClassPrice = 1699;
                else
                    firstClassPrice = 0;
                if (luggageAmount > 25)
                    luggagePrice = ((decimal)luggageAmount - 25) * 290;
                else
                    luggagePrice = 0;
                totalPrice = luggagePrice + (firstClassPrice * adults * children) + destinationPrice;
            }

        }


        //TODO just return calculation when program is up running (should be doen)
        public decimal GetTaxAmount()
        { 
            return totalPrice * (decimal)taxRate;
        }

        //TODO sometihn
        public decimal GetTotalWithoutTax()
        {
            return totalPrice;
        }

        public decimal GetTotalWithTax()
        {
            decimal totalWithTax = GetTaxAmount() + GetTotalWithoutTax();
            return Math.Round(totalWithTax); //rounder up for a awesome readable number <3
        }
    }
}
