using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class TV
    {
        private string input;
        private bool isOn;

        public TV()
        {
            isOn = false;
            input = "Channel 1";
        }

        public bool GetStatus()
        {
            return isOn;
        }

        public string GetInput()
        {
            return input;
        }

        public void SetStatus(bool newStatus)
        {
            isOn = newStatus;
        }

        public void SetInput(string newInput)
        {
            input = newInput;
        }
    }
}
