using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cups : Inventory
    {
        //member variables

        //constructor
        public Cups()
        {

        }

        //member methods
        public override void GetPrice()
        {
            Console.WriteLine("How many cups would you like to purchase? Prices are as follows: ");
        }
    }
}
