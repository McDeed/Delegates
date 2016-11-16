using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class SmartBuilding
    {
        public int fan_speed, CO2_levels;
        public bool ventilation_system, fire_alarm, CO2_warning_light;
        public float temp;

        public delegate void SmartBuildingEventHandler(object source, EventArgs e);
        public event SmartBuildingEventHandler Toxic_Fire;
        public event SmartBuildingEventHandler Excess_CO2_Levels;
        public event SmartBuildingEventHandler Normal_CO2_Levels;
        
        Random rand = new Random(DateTime.Now.Millisecond);
        public void rand_values()
        {
            Console.Clear();
            CO2_levels = (int)(rand.Next(2000));
            temp = (int)(rand.Next(100));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Co2 level = {0} and Temp = {1}", CO2_levels, temp);

            if (CO2_levels > 1500 && temp <= 75)
                OnExcess_CO2_Levels();
            if (CO2_levels <= 1500 && temp <= 75)
                OnNormal_CO2_Levels();
            if (CO2_levels > 1500 && temp > 75)
                OnToxic_Fire();
        }
        
        

        protected virtual void OnToxic_Fire()
        {
            if (Toxic_Fire != null)
            {
                Toxic_Fire(this, EventArgs.Empty);
            }
                

        }
        protected virtual void OnExcess_CO2_Levels()
        {
            if (Excess_CO2_Levels != null)
            {
                Excess_CO2_Levels(this, EventArgs.Empty);
            }
        }
        
        protected virtual void OnNormal_CO2_Levels()
        {
            if (Normal_CO2_Levels != null)
            {
                Normal_CO2_Levels(this, EventArgs.Empty);
            }
        }

    }
}
