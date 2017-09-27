using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RygOgRejs.Entities
{

    //amazing 
    public struct Transactions
    {
        private decimal amount;
        private Journey journey;
        private Payer payer;
        private DateTime timeStamp;
        public Transactions(decimal amount, Journey journey, Payer payer)
        {
            this.amount = amount;
            this.payer = payer;
            this.journey = journey;
            timeStamp = DateTime.Now;
        }
    }
}
