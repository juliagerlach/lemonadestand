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
        private int people;

        public int People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
            }
        }

        public List<int> peopleCount = new List<int>();

        //constructor
        public Customer()
        {

        }

        //member methods
        public void CreatePeople(List<int> peopleCount)
        {
            Random random = new Random();
            people = random.Next(50, 100);
            
        }

        public void CreateCustomer()
        {

        }

        public void BuyLemonade()
        {
            for (int i = 0; i < people; i++)
            {

            }
        }
    }
}
