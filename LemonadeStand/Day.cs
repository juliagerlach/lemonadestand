using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        private int numberOfDays;
        private int numberOfCustomers;
        public int NumberOfDays
        {
            get { return numberOfDays; }
            set { numberOfDays = value; }
        }

        public int NumberOfCustomers
        {
            get { return numberOfCustomers; }
            set { numberOfCustomers = value; }
        }

        public Day()
        {

        }
        public int EstablishDays()
        {
            string daysInGame;
            Console.WriteLine("How many days would you like your game to be? Please enter any whole number between 7 and 21.");
            daysInGame = Console.ReadLine();
            if (int.TryParse(daysInGame, out int number1))
            {
                numberOfDays += Int32.Parse(daysInGame);
            }
            else
            {
                Console.WriteLine("Error: Must enter an integer.");
                Console.ReadLine();
            }
            return numberOfDays;
        }

        public int GenerateCustomers()
        {
            Random random = new Random();
            numberOfCustomers = random.Next(50, 100);
            return numberOfCustomers;
        }
    

    public void GenerateDays(Weather weather, Inventory inventory, Recipe recipe, Day day, Wallet wallet)
    {
        for (int i = 0; i < day.NumberOfDays; i++) 
        {
                weather.SetTemperature();
                weather.SetConditions();
                weather.DeclareWeather();

                weather.SetTemperature();
                weather.SetConditions();
                weather.DeclareForecast();
                inventory.PurchaseSupplies(wallet);
                inventory = recipe.MakePitcher(inventory);
                recipe.DeterminePriceOfLemonade();
                GenerateCustomers();

            }
    }
  }
}
