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
        //constructor
        public Game()
        {
            weather = new Weather();
        }

        //member methods
        public void RunGame()
        {
           weather.SetTemperature();
           weather.SetConditions();
           weather.DeclareWeather();

           weather.SetTemperature();
           weather.SetConditions();
           weather.DeclareForecast();
        }
    }
}
