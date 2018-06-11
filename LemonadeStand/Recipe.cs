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

        public int LemonCount
        {
            get { return lemonCount; }
            set { lemonCount = value; }
        }
            
            //how many of each per pitcher:
        //lemons
        //sugar


        //how much per cup:
        //ice
        //1 cup

        //12 cups per pitcher

        //calculate how much

        public void SetRecipe()
        {
            string useLemons;

            Console.WriteLine("Time to create today's recipe! When prompted, indicate how many of each item you would like to use to make a pitcher of lemonade. Each pitcher makes 12 cups. Press 'enter' to continue.");
            Console.ReadLine();
            Console.WriteLine("How many lemons? Please enter an integer and then press 'enter' to continue.");
            useLemons = Console.ReadLine();
            if (int.TryParse(useLemons, out int number1))
            {
                lemonCount += Int32.Parse(useLemons);

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
                SetRecipe();
            }

        }

    }
}
