﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables  
        private int cupQuantity;
        private double cupPrice;
        private int cupPurchase;
        private int lemonQuantity;
        private double lemonPrice;
        private int lemonPurchase;
        private int sugarQuantity;
        private double sugarPrice;
        private int sugarPurchase;
        private int iceQuantity;
        private double icePrice;
        private int icePurchase;
        private int cupsSold;

        public int CupQuantity
        {
            get { return cupQuantity; }
            set { cupQuantity = value; }
        }

        public double CupPrice
        {
            get { return cupPrice; }
        }

        public int CupPurchase
        {
            get { return cupPurchase; }
            set { cupPurchase = value; }
        }

        public int LemonQuantity
        {
            get { return lemonQuantity; }
            set { lemonQuantity = value; }
        }

        public double LemonPrice
        {
            get { return lemonPrice; }
        }

        public int LemonPurchase
        {
            get { return lemonPurchase; }
            set { lemonPurchase = value; }
        }

        public int SugarQuantity
        {
            get { return sugarQuantity; }
            set { sugarQuantity = value; }
        }

        public double SugarPrice
        {
            get { return sugarPrice; }
        }

        public int SugarPurchase
        {
            get { return sugarPurchase; }
            set { sugarPurchase = value; }
        }

        public int IceQuantity
        {
            get { return iceQuantity; }
            set { iceQuantity = value; }
        }

        public double IcePrice
        {
            get { return icePrice; }
        }

        public int IcePurchase
        {
            get { return icePurchase; }
            set { icePurchase = value; }
        }

        public int CupsSold
        {
            get { return cupsSold; }
            set { cupsSold = value; }
        }

        public void PurchaseSupplies(Wallet wallet)
        {
            Console.WriteLine("It's time to purchase supplies. When prompted, type the quantity you wish to purchase. For eaach item, please enter an integer and then press 'enter'.");

            Console.ReadLine();
            PurchaseCups(wallet);
            PurchaseLemons(wallet);
            PurchaseSugar(wallet);
            PurchaseIce(wallet);
            Console.Clear();
        }
        public Wallet PurchaseCups(Wallet wallet)
        {
            cupQuantity = 0;
            cupPrice = 0.05;
            string buyCups;
            Console.WriteLine("How many cups would you like to purchase? They cost $" + cupPrice + " each. Please enter an integer.");
            buyCups = Console.ReadLine();
            if (int.TryParse(buyCups, out int number1))
            {
                cupPurchase += Int32.Parse(buyCups);
                Console.WriteLine("You purchased " + cupPurchase + " cups for $" + (cupPrice * cupPurchase) + ". You had " + cupQuantity + " cups in inventory so you now have " + (cupQuantity + cupPurchase) + " cups. Press 'enter' to continue.");
                Console.ReadLine();
                cupQuantity += cupPurchase;
                wallet.CashBalance -= (cupPrice * cupPurchase);
                Console.WriteLine("You have $" + wallet.CashBalance + " remaining.");
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                wallet = PurchaseCups(wallet);
            }
            
            return wallet;
        }

        public Wallet PurchaseLemons(Wallet wallet)
        {
            lemonQuantity = 0;
            lemonPrice = 0.15;
            string buyLemons;
            Console.WriteLine("How many lemons would you like to purchase? They cost $" + lemonPrice + " each. Please enter an integer.");
            buyLemons = Console.ReadLine();
            if (int.TryParse(buyLemons, out int number1))
            {
                lemonPurchase += Int32.Parse(buyLemons);
                Console.WriteLine("You purchased " + lemonPurchase + " lemons for $" + (lemonPrice * lemonPurchase) + ". You had " + lemonQuantity + " lemons in inventory so you now have " + (lemonQuantity + lemonPurchase) + " lemons. Press 'enter' to continue.");
                Console.ReadLine();
                lemonQuantity += lemonPurchase;
                wallet.CashBalance -= (lemonPrice * lemonPurchase);
                Console.WriteLine("You have $" + wallet.CashBalance + " remaining.");
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                wallet = PurchaseLemons(wallet);
            }
            return wallet;
        }

        public Wallet PurchaseSugar(Wallet wallet)
        {
            sugarQuantity = 0;
            sugarPrice = 0.08;
            string buySugar;
            Console.WriteLine("How much sugar would you like to purchase? It costs $" + sugarPrice + " per cup. Please enter an integer.");
            buySugar = Console.ReadLine();

            if (int.TryParse(buySugar, out int number1))
            {
                sugarPurchase += Int32.Parse(buySugar);
                Console.WriteLine("You purchased " + sugarPurchase + " cups of sugar for $" + (sugarPrice * sugarPurchase) + ". You had " + sugarQuantity + " cups of sugar in inventory so you now have " + (sugarQuantity + sugarPurchase) + " cups of sugar. Press 'enter' to continue.");
                Console.ReadLine();
                sugarQuantity += sugarPurchase;
                wallet.CashBalance -= (sugarPrice * sugarPurchase);
                Console.WriteLine("You have $" + wallet.CashBalance + " remaining.");
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                wallet = PurchaseSugar(wallet);
            }
            return wallet;
        }

        public Wallet PurchaseIce(Wallet wallet)
        {
            iceQuantity = 0;
            icePrice = 0.01;
            string buyIce;
            Console.WriteLine("How much ice would you like to purchase? It costs $" + icePrice + " per cube. Please enter an integer.");
            buyIce = Console.ReadLine();
            if (int.TryParse(buyIce, out int number1))
            {
                icePurchase += Int32.Parse(buyIce);
                Console.WriteLine("You purchased " + icePurchase + " cubes of ice for $" + (icePrice * icePurchase) + ". You had no ice cubes in inventory so you now have " + icePurchase + " cubes of ice. Press 'enter' to continue.");
                Console.ReadLine();
                iceQuantity += icePurchase;
                wallet.CashBalance -= (icePrice * icePurchase);
                Console.WriteLine("You have $" + wallet.CashBalance + " remaining.");
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                wallet = PurchaseIce(wallet);
            }
            return wallet;
        }

        //constructor 
        public Inventory()
        {

        }
        //member methods

        public void DeclareInventory()
        {
            Console.WriteLine("Your current inventory contains: " + cupQuantity + " cups, " + lemonQuantity + " lemons, " + sugarQuantity + " cups of sugar, " + iceQuantity + " ice cubes. Press 'enter' to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void DeclareCupsSold()
        {
            Console.WriteLine("You sold " + cupsSold + " today and made $" + (cupsSold * cupPrice) + ".");
            Console.ReadLine();
            Console.Clear();
        }
        public void GetInventoryValue()
        {
            int inventoryValue;
            Console.WriteLine("The total value of your current inventory is " + ((cupQuantity * cupPrice) + (lemonQuantity * lemonPrice) + (sugarQuantity * sugarPrice)));
            inventoryValue = Convert.ToInt32(Console.ReadLine());
        }

    }
}
