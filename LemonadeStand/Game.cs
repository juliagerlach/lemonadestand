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
        //constructor
        public Game()
        {
            //weather = new Weather();
            inventory = new Inventory();
        }

        //member methods
        public void RunGame()
        {
            //weather.SetTemperature();
            //weather.SetConditions();
            //weather.DeclareWeather();

            // weather.SetTemperature();
            //weather.SetConditions();
            //weather.DeclareForecast();
            inventory.PurchaseCups();
            inventory.PurchaseLemons();
            inventory.PurchaseSugar();
            inventory.PurchaseIce();
        }
    }
}
