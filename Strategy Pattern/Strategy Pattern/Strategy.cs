using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    abstract class Strategy
    {
        public abstract int[] Sort(int[] array, int size);
    }
}
