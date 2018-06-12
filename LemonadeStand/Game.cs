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
        public Weather weather;
        public Inventory inventory;
        public Recipe recipe;
        public Customer customer;
        public Wallet wallet;
        public Day day;
        public Player player;
        //constructor
        public Game()
        {
            weather = new Weather();
            inventory = new Inventory();
            recipe = new Recipe();
            customer = new Customer();
            wallet = new Wallet();
            day = new Day();
            player = new Player();
            
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
            inventory.PurchaseSupplies(wallet);
            inventory = recipe.MakePitcher(inventory);
            recipe.DeterminePriceOfLemonade();

        }
    }
}
