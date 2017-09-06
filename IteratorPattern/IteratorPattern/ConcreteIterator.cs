using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate guestList;
        private int currentItem = 0;

        public ConcreteIterator(ConcreteAggregate GuestList)
        {
            this.guestList = GuestList;
        }

        public override string First()
        {
            currentItem = 0;
            return guestList.getGuest(currentItem++);
        }
        public override string Next()
        {
            return guestList.getGuest(currentItem++);
        }
        public override bool isDone()
        {
            if (currentItem < guestList.getLength() - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string CurrentItem()
        {
            return guestList.getGuest(currentItem);
        }
    }
}
