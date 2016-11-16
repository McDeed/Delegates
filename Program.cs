using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SmartBuilding();
            var ev = new Toxic_Fire();
            var a = new Normal_CO2_Levels();
            var d = new Excess_CO2_Levels();
            obj.Toxic_Fire += ev.OnToxic_Fire;
            obj.Normal_CO2_Levels += a.OnNormal_CO2_Levels;
            obj.Excess_CO2_Levels += d.OnExcess_CO2_Levels;
            while (true)
            {
                obj.rand_values();
                Console.ReadKey();
            }
            
            
          
        }
    }
}
