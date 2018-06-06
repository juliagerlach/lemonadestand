using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables
        //conditions(sunny, cloudy, raining, hazy, 
        public int temperature;
        List<string> conditions = new List<string>() {"sunny", "cloudy", "rainy", "foggy", "hazy", "overcast" };
 
        //constructor
        public Weather()
        {

        }

        //member methods
        public int SetTemperature()
        {
            Random random = new Random();
            temperature = random.Next(57, 98);
            return temperature;
        }

        public void SetConditions()
        {

        }
    }
}
