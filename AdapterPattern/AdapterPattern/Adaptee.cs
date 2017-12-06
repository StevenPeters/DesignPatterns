using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Adaptee
    {
        public double ConvertFtoC(double tempF)
        {
            double tempC = (tempF - 32.0) * (5.0 / 9.0);

            return tempC;
        }

        public double ConvertCtoF(double tempC)
        {
            double tempF = (tempC * (9.0 / 5.0) + 32.0);

            return tempF;
        }
    }
}
