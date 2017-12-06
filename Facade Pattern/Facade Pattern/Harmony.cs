using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Harmony
    {
        TV TV1 = new TV();
        SoundSystem SoundSystem1 = new SoundSystem();
        Lights Light1 = new Lights();

        public Harmony()
        {

        }

        public void SetTVStatus(bool status)
        {
            TV1.SetStatus(status);
        }

        public void SetTVInput(string input)
        {
            TV1.SetInput(input);
        }

        public bool GetTVStatus()
        {
            return TV1.GetStatus();
        }

        public string GetTVInput()
        {
            return TV1.GetInput();
        }

        public void SetSoundSystemStatus(bool status)
        {
            SoundSystem1.SetStatus(status);
        }

        public void SetSoundSystsemVolume(int volume)
        {
            SoundSystem1.SetVolume(volume);
        }

        public bool GetSoundSystemStatus()
        {
            return SoundSystem1.GetStatus();
        }

        public int GetSoundSystemVolume()
        {
            return SoundSystem1.GetVolume();
        }

        public void SetLightsStatus(bool status)
        {
            Light1.SetStatus(status);
        }

        public void SetLightsBrightness(int brightness)
        {
            Light1.SetBrightness(brightness);
        }

        public bool GetLightsStatus()
        {
            return Light1.GetStatus();
        }

        public int GetLightsBrightness()
        {
            return Light1.GetBrightness();
        }
    }
}
