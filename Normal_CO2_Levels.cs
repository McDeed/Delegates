using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Normal_CO2_Levels :   SmartBuilding
    {
        public void OnNormal_CO2_Levels(object source, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O.K. \nFan speed = 30 \nExcess CO2 Light :: False\nFire Alarm::False");
            fan_speed = 30;
            CO2_warning_light = false;
            fire_alarm = false;
        }
    }
}
