using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        //member variables
        private int cashBalance;

        public int CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }




        //contructor
        public Wallet()
        {
            cashBalance = 20;
        }

        //member methods

        public void PayForSupplies()
        {

        }

        public void IncrementMoney()
        {

        } 
    }
}
