using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    abstract class Iterator
    {
        public abstract string First();
        public abstract string Next();
        public abstract bool isDone();
        public abstract string CurrentItem();
    }
}
