using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Weather weather;
        public Inventory inventory;
        public Recipe recipe;
        public Customer customer;
        public Wallet wallet;
        public Day day;
        public Player player;
        static Random random;

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
            random = new Random();
        }

        //member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to 'Lemonade Stand', the game that lets you turn lemons into lemonade. \n\nPurchase the supplies you need, set the price, and watch the thirsty customers arrive in droves -- or not! \n\nIf you set your price too high or if the weather takes a turn for the worse, you may not be able to move your inventory. \n\nGet the equation right, and you'll be rolling in cash. Press 'enter' to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void RunGame()
        {
            player.SetPlayerName();
            day.EstablishDays();
            day.GenerateDays(weather, inventory, recipe, day, wallet);
            
            customer.VisitStand(day, weather, recipe, wallet, inventory);
            inventory.DeclareCupsSold();
            inventory.DeclareInventory();
            player.DeclareCashBalance(wallet);
        }
    }
}
