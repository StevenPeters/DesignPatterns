using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class SoundSystem
    {
        private bool isOn;
        private int volume;

        public SoundSystem()
        {
            isOn = false;
            volume = 0;
        }

        public bool GetStatus()
        {
            return isOn;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetStatus(bool newStatus)
        {
            isOn = newStatus;
        }

        public void SetVolume(int newVolume)
        {
            if (newVolume < 0)
            {
                volume = 0;
            }
            if (newVolume > 100)
            {
                volume = 100;
            }
            if (newVolume >= 0 && newVolume <= 100)
            {
                volume = newVolume;
            }
        }
    }
}
