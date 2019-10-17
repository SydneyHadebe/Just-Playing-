using System;
using System.Collections.Generic;
using System.Text;

namespace GamingLogic
{
   public class ShippingInformation
    {
        public enum Zones
        {
            zone1, 
            zone2,
            zone3,
            zone4
        }

        public delegate string DifferentCities(string destination, int price); 

        public string GetDetailsOfTheCurrentCity()
        {
            string name = string.Empty;

            return name;
        }
    }
}
