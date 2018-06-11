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
        private int startingCash;
        private int cashBalance;

        public int StartingCash
        {
            set { startingCash = 20; }
        }

        public int CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }




        //contructor
        public Wallet()
        {

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
