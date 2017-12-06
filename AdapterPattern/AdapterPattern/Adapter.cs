using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override double[] ConvertFArray(double[] FArray)
        {
            int index = 0;

            foreach(double F in FArray)
            {
                FArray[index] = adaptee.ConvertFtoC(F);
                index++;
            }

            return FArray;
        }

        public override double[] ConvertCArray(double[] CArray)
        {
            int index = 0;

            foreach (double C in CArray)
            {
                CArray[index] = adaptee.ConvertCtoF(C);
                index++;
            }

            return CArray;
        }
    }
}
