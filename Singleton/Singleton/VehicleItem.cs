using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeList
{
    class VehicleItem
    {
        private static VehicleItem Vehicle;
        private static string name;

        private VehicleItem(string itemName)
        {
            name = itemName;
        }
        public static VehicleItem CreateInstance(string itemName)
        {
            if (Vehicle == null)
            {
                Vehicle = new VehicleItem(itemName);
            }

            return Vehicle;
        }

        public static string GetName()
        {
            return name;
        }
    }
}
