using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejs.Entities
{
    class Payer
    {
        protected string firstname;
        protected string lastname;
        protected string ssn;
        
        public Payer(string firstname, string lastname, string ssn)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                foreach (char c in value)
                    if (char.IsLetter(c))
                        throw new ArgumentException();
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException();
                foreach (char c in value)
                    if (char.IsLetter(c))
                        throw new ArgumentException();
                lastname = value;
            }
        }

        public string Ssn
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length != 9)
                    throw new ArgumentOutOfRangeException();
                foreach(char c in value)
                    if(!char.IsDigit(c))
                        throw new ArgumentException();
                ssn = value;

            }
        }
    }
}
