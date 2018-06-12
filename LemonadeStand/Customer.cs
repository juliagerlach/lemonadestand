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
        private Random _rnd = new Random();
        public bool RandomPurchaseLikelihood(double probability)
        {
            return _rnd.NextDouble() < probability;
        }

        public List<int> people = new List<int>();



        //constructor
        public Customer()
        {

        }

        //member methods


        public void ChecksWeatherAndPrice(Weather weather, Recipe recipe)
        {
            if (weather.Temperature >= 80 && weather.Condition == "sunny" && recipe.LemonadePrice <= 0.50)
            {
                RandomPurchaseLikelihood(0.9);
            }

            else if (weather.Temperature >= 80 && weather.Condition == "sunny" && recipe.LemonadePrice >= 0.51)
            {
                RandomPurchaseLikelihood(0.8);
            }

            else if (weather.Temperature >= 80 && weather.Condition != "sunny" && recipe.LemonadePrice <= 0.50)
            {
                RandomPurchaseLikelihood(0.70);
            }

            else if (weather.Temperature >= 80 && weather.Condition != "sunny" && recipe.LemonadePrice >= 0.51)
            {
                RandomPurchaseLikelihood(0.60);
            }

            else if (weather.Temperature <= 79 && weather.Condition == "sunny" && recipe.LemonadePrice <= 0.50)
            {
                RandomPurchaseLikelihood(0.55);
            }
            else if (weather.Temperature <= 79 && weather.Condition == "sunny" && recipe.LemonadePrice >= 0.51)
            {
                RandomPurchaseLikelihood(0.5);
            }

            else if (weather.Temperature <= 79 && weather.Condition != "sunny" && recipe.LemonadePrice <= 0.50)
            {
                RandomPurchaseLikelihood(0.40);
            }
            else if (weather.Temperature <= 79 && weather.Condition != "sunny" && recipe.LemonadePrice >= 0.51)
            {
                RandomPurchaseLikelihood(0.25);
            }
            else
            {
                RandomPurchaseLikelihood(0.10);
            }
            }
        }
    }
