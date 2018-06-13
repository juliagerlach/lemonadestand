using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //member variables
        private int lemonCount;
        private int sugarCount;
        private int iceCount;
        private int cupCount;
        private int cupsInPitcher;
        private double lemonadePrice;

        public int LemonCount
        {
            get { return lemonCount; }
            set { lemonCount = value; }
        }

        public int SugarCount
        {
            get { return sugarCount; }
            set { sugarCount = value; }
        }

        public int IceCount
        {
            get { return iceCount; }
            set { iceCount = value; }
        }

        public int CupCount
        {
            get
            { return cupCount; }
            set
            { cupCount = value; }
        }

        public int CupsInPitcher
        {
            get
            { return cupsInPitcher; }
            set
            { cupsInPitcher = value; }
        }

        public double LemonadePrice
        {
            get
            {
                return lemonadePrice;
            }
            set
            {
                lemonadePrice = value;
            }
        }

        public Recipe()
        {

        }

        public Inventory DetermineLemonsPerPitcher(Inventory inventory)
        {
            string useLemons;
            Console.WriteLine("How many lemons per pitcher? Please enter an integer and then press 'enter' to continue.");
            useLemons = Console.ReadLine();
            if (int.TryParse(useLemons, out int number1))
            {
                lemonCount += Int32.Parse(useLemons);

            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                inventory = DetermineLemonsPerPitcher(inventory);
            }
            return inventory;
        }

        public Inventory DetermineSugarPerPitcher(Inventory inventory)
        {
            string useSugar;
            Console.WriteLine("How many cups of sugar per pitcher? Please enter an integer and then press 'enter' to continue.");
            useSugar = Console.ReadLine();
            if (int.TryParse(useSugar, out int number2))
            {
                sugarCount += Int32.Parse(useSugar);
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                inventory = DetermineSugarPerPitcher(inventory);
            }
            return inventory;
        }

        public Inventory DetermineIcePerCup(Inventory inventory)
        {
            string useIce;
            Console.WriteLine("How much ice per cup? Please enter an integer and then press 'enter' to continue.");
            useIce = Console.ReadLine();
            if (int.TryParse(useIce, out int number3))
            {
                iceCount += Int32.Parse(useIce);
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                inventory = DetermineIcePerCup(inventory);
            }
            return inventory;
        }

        public Inventory MakePitcher(Inventory inventory)
        {
            cupsInPitcher = 0;
            Console.WriteLine("Time to create today's recipe! When prompted, indicate how much of each item you would like to use to make your lemonade. Each pitcher makes 12 cups. Press 'enter' to continue.");
            Console.ReadLine();
            inventory = DetermineLemonsPerPitcher(inventory);
            inventory = DetermineSugarPerPitcher(inventory);
            inventory = DetermineIcePerCup(inventory);
            Console.Clear();

            if (lemonCount <= inventory.LemonQuantity && sugarCount <= inventory.SugarQuantity && iceCount <= inventory.IceQuantity && cupCount <= inventory.CupQuantity)
            {
                inventory.LemonQuantity -= lemonCount;
                inventory.SugarQuantity -= sugarCount;
                inventory.IceQuantity -= iceCount;
                cupsInPitcher = 12;
                Console.WriteLine("You just made a pitcher of lemonade.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your supplies have dwindled - you don't have enough to make another pitcher! No more lemonade sales today.");
                Console.ReadLine();
                Console.Clear();
            }
            return inventory;
        }

        public double DeterminePriceOfLemonade()
        {
            double x;
            string pricePerCup;
            do
            {
                do
                {
                    Console.WriteLine("How much do you want to sell each cup of lemonade for today? Please use '0.00' format to indicate dollars and cents and then press 'enter'.");
                    pricePerCup = Console.ReadLine();
                }while (!double.TryParse(pricePerCup, out x));
            } while((Convert.ToDouble(pricePerCup) > 1)||(Convert.ToDouble(pricePerCup) <= 0));
            LemonadePrice = Convert.ToDouble(pricePerCup);
            
            return lemonadePrice;
        }
            public Inventory DecrementLemonade(Inventory inventory)
            {
                if (cupsInPitcher > 0)
                {
                    cupsInPitcher--;
                }
                else
                {
                MakePitcher(inventory);
                }

                return inventory;
            }      
        }
    }
