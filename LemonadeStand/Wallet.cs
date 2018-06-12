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
        private double cashBalance;

        public double CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }




        //contructor
        public Wallet()
        {
            cashBalance = 20.00;
        }

        //member methods

        public void IncrementMoney()
        {

        } 
    }
}
