using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Toxic_Fire    :   SmartBuilding
    {
        public void OnToxic_Fire(object source, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TOXIC FIRE DETECTED \nVentilation System: False \nFan speed = 0 \nFire Alarm::True");
            fan_speed = 0;
            fire_alarm = true;
            ventilation_system = false;
        }

	
    }
}
