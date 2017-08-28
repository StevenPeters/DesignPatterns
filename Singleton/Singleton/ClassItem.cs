using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeList
{
    class ClassItem
    {
        private string name;

        public ClassItem(string itemName)
        {
            name = itemName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
