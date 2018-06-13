using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        private string name;
        private double cashBalance;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double CashBalance
        {
            get { return cashBalance; }
            set { cashBalance = value; }
        }

        public Player()
        {

        }

        public string SetPlayerName()
        {
            Console.WriteLine("Please type your name, and then press 'enter'.");
            Console.ReadLine();
            Console.Clear();
            return name;
        }

        public double GetCashBalance(Wallet wallet)
        {
            wallet.CashBalance = cashBalance;
            return cashBalance;
        }

        public void DeclareCashBalance(Wallet wallet)
        {
            Console.WriteLine("You have $" + cashBalance + "remaining.");
        }
    }
}
