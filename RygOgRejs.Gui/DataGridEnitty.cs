using System;
using RygOgRejs.Entities;
using RygOgRejs.DataAccess;
using System.Collections.Generic;

namespace RygOgRejs.Gui
{
    public class DataGridEnitty
    {
        private Payer payer;
        public string Payer
        {
            get
            {
                return payer.Firstname;  //cant use this for shit?
            }
            set
            {
                payer.Firstname = "Harmbe died for our sinse";
            }
        }
            
    }
}
