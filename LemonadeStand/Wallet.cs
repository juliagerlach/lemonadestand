using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        private double cashBalance;

        public double CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }
        public Wallet()
        {
            cashBalance = 20.00;
        }
    }
}
