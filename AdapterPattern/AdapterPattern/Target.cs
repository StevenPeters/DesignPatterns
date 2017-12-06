using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    abstract class Target
    {
        abstract public double[] ConvertCArray(double[] FArray);
        abstract public double[] ConvertFArray(double[] CArray);
    }
}
