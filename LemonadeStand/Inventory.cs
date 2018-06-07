using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Inventory
    {
        //member variables  

        private string item;
        private int quantity;
        private int price;

        public string Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }

        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //no constructor in abstract parent class
        //member methods

        public abstract void GetPrice();
        public void PurchaseInventory()
        {

        }

    }
       
    
}
