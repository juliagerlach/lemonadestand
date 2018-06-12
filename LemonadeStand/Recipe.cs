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

            public Inventory MakeRecipe(Inventory inventory)
            {
            Console.WriteLine("Time to create today's recipe! When prompted, indicate how much of each item you would like to use to make your lemonade. Each pitcher makes 12 cups. Press 'enter' to continue.");

            Console.ReadLine();
            inventory = DetermineLemonsPerPitcher(inventory);
            inventory = DetermineSugarPerPitcher(inventory);
            inventory = DetermineIcePerCup(inventory);
            Console.Clear();

            if (lemonCount <= inventory.LemonQuantity && sugarCount <= inventory.SugarQuantity && iceCount <= inventory.IceQuantity)
            {
                inventory.LemonQuantity -= lemonCount;
                inventory.SugarQuantity -= sugarCount;
                inventory.IceQuantity -= iceCount;
                Console.WriteLine("You just made one pitcher of lemonade.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your supplies have dwindled - not enough to make another pitcher!");
                Console.ReadLine();
                Console.Clear();
            }
            return inventory;
            }       
    }
}
