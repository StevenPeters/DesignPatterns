using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeList
{
    class DormItem
    {
        private string name;

        public DormItem(string itemName)
        {
            name = itemName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
