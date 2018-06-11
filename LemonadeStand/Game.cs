using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //member variables
        //public Weather weather;
        public Inventory inventory;
        public Recipe recipe; 
        //constructor
        public Game()
        {
            //weather = new Weather();
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //member methods
        public void RunGame()
        {
            //weather.SetTemperature();
            //weather.SetConditions();
            //weather.DeclareWeather();

            //weather.SetTemperature();
            //weather.SetConditions();
            //weather.DeclareForecast();
            inventory.PurchaseSupplies();
            inventory = recipe.MakeRecipe(inventory);
        }
    }
}
