using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        private int temperature;
        private string condition;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

         public string Condition
        {
            get
            {
                return condition;
            }
            set
            {
                condition = value;
            }
        }
        

        List<string> conditions = new List<string>() {"sunny", "partly cloudy", "rainy", "foggy", "hazy", "overcast" };
       
        public Weather()
        {

        }
        public int SetTemperature()
        {
            Random random = new Random();
            temperature = random.Next(57, 98);
            return temperature;
        }

        public void SetConditions()
        {
            Random random = new Random();
            int index = random.Next(conditions.Count);
            condition = conditions[index];
        }

        public void DeclareWeather()
        {
            Console.WriteLine("Today's weather is " + temperature + " and " + condition + ".");
            Console.ReadLine();
        }

        public void DeclareForecast()
        {
            Console.WriteLine("Tomorrow's weather is forecast to be " + temperature + " and " + condition + ".");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
