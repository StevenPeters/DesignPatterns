using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class ConcreteAggregate : Aggregate
    {
        private List<string> guestList = new List<string>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public void AddGuest(string newGuest)
        {
            guestList.Add(newGuest);
        }
        
        public string getGuest(int index)
        {
            return guestList[index];
        }

        public int getLength()
        {
            return guestList.Count;
        }
    }
}
