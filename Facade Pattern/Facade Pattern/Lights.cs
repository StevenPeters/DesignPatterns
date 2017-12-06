using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Lights
    {
        private bool isOn;
        private int brightness;

        public Lights()
        {
            isOn = false;
            brightness = 100;
        }

        public bool GetStatus()
        {
            return isOn;
        }

        public int GetBrightness()
        {
            return brightness;
        }

        public void SetStatus(bool newStatus)
        {
            isOn = newStatus;
        }

        public void SetBrightness(int newBrightness)
        {
            if (newBrightness <= 0)
            {
                brightness = 1;
            }
            if (newBrightness > 100)
            {
                brightness = 100;
            }
            if (newBrightness > 0 && newBrightness <= 100)
            {
                brightness = newBrightness;
            }
        }
    }
}
