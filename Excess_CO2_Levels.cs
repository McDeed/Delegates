using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Excess_CO2_Levels :   SmartBuilding
    {
        public void OnExcess_CO2_Levels(object source, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("EXCESS CO2 DETECTED \nFan speed increased to = 100 \nExcess CO2 Light ::True ");
            fan_speed = 100;
            CO2_warning_light = true;
            fire_alarm = false;
            
        }
    }
}
