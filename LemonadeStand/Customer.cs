using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //member variables

        
        private double thirst;

        public double Thirst
        {
            get
            { return thirst; }
            set
            { thirst = value; }
        }

        //constructor
        public Customer()
        {

        }

        //member methods

        public void VisitStand(Day day, Weather weather, Recipe recipe, Wallet wallet, Inventory inventory)
        {
            for (int j = 0; j < day.NumberOfCustomers; j++)
            {
                CheckWeather(weather, recipe, wallet, inventory);
                CheckPrice(recipe, weather, wallet, inventory);
                BuyLemonade(recipe, wallet, inventory);
            }
        }
        public void CheckWeather(Weather weather, Recipe recipe, Wallet wallet, Inventory inventory)
        {
            Random random = new Random();
            if (weather.Temperature >= 80 && weather.Condition == "sunny")
            {
                thirst = random.Next(70, 100);
            }

            else if (weather.Temperature >= 80 && weather.Condition != "sunny")
            {
                thirst = random.Next(60, 90);
            }

            else if (weather.Temperature <= 79 && weather.Condition == "sunny")
            {
                thirst = random.Next(50, 80);
            }
            else if (weather.Temperature <= 79 && weather.Condition != "sunny")
            {
                thirst = random.Next(40, 70);
            }
            else
            {
                thirst = .10;
            }
            CheckPrice(recipe, weather, wallet, inventory);
        }

        public Recipe CheckPrice(Recipe recipe, Weather weather, Wallet wallet, Inventory inventory)
        {
            if (recipe.LemonadePrice <= (thirst * weather.Temperature)/100)
            {
                BuyLemonade(recipe, wallet, inventory);
                inventory.CupsSold++;
            }
            else
            {

            }
        return recipe;
        }
        public void BuyLemonade(Recipe recipe, Wallet wallet, Inventory inventory)
        {
            if (recipe.CupsInPitcher > 0)
            {
                wallet.CashBalance += recipe.LemonadePrice;
                inventory.CupQuantity--;
            }

            else
            {
                recipe.MakePitcher(inventory);
            }
        }
    }

}
