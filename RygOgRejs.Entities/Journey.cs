using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejs.Entities
{
   public class Journey
    {
        protected int adults;
        protected int children;
        protected PriceDetails currenPriceDetails;
        protected DateTime depatureDate;
        protected Destiantion destiantion;
        protected bool isFirstClass;
        protected double luggaAmount;

        public Journey(Destiantion destiantion, DateTime depatureDate, bool isFirstClass, int adults, int children, double luggaAmount)
        {
            Destination = destiantion;
            this.depatureDate = depatureDate;
            this.isFirstClass = isFirstClass;
            Adults = adults;
            Children = children;
            LuggaAmount = luggaAmount;
        }

        public void AddLuggage(double amount)
        {
            luggaAmount += amount; //??????
        }

        public void AddPersons(int adults, int children)
        {
            Adults += adults;
        }

        public void ChangeDestination(Destiantion newDestination)
        {
            Destination = newDestination;
        }

        public decimal GetCurrentTotal()
        {
            return 2;
        }

        public void RemoveLuggae(double amount)
        {
            luggaAmount -= amount;
        }

        public void RemovePerson(int adults, int children)
        {
            Adults -= adults;
            Children -= children; //dis im not sure is working as intended
        }

        
        public int Children
        {
            get
            {
                return children;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ikke et gyldig værdig " + nameof(value));
                children = value; //test dis later
            }
        }
        public int Adults
        {
            get
            {
                return adults;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ikke et gyldig værdig " + nameof(value));
                adults = value; //test dis later
            }
        }

        public Destiantion Destination
        {
            get
            {
                return destiantion;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Destiantion), value))
                    throw new ArgumentException("ikke en gyldig destination" + value);
                destiantion = value;
            }
        }

        public double LuggaAmount
        {
            get
            {
                return luggaAmount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("ikke et gyldig værdig" + nameof(value));
                luggaAmount = value;
            }

        }



        public enum Destiantion
        {
            Billund,
            Copenhagen,
            PalmaDeMalkorca
        }
    }
}
