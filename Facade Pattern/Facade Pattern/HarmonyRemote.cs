using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Pattern
{
    public partial class HarmonyRemote : Form
    {
        Harmony remote;

        public HarmonyRemote()
        {
            InitializeComponent();
            remote = new Harmony();
            StatusRefresh();
        }

        private void StatusRefresh()
        {
            if (remote.GetTVStatus())
            {
                TVStatusLabel.Text = "Status: On";
            }
            else
            {
                TVStatusLabel.Text = "Status: Off";
            }
            TVInputLabel.Text = "Input: " + remote.GetTVInput();

            if (remote.GetSoundSystemStatus())
            {
                SoundSystemStatusLabel.Text = "Status: On";
            }
            else
            {
                SoundSystemStatusLabel.Text = "Status: Off";
            }
            SoundSystemVolumeLabel.Text = "Volume: " + remote.GetSoundSystemVolume() + "%";

            if (remote.GetLightsStatus())
            {
                LightsStatusLabel.Text = "Status: On";
            }
            else
            {
                LightsStatusLabel.Text = "Status: Off";
            }
            LightsBrightnessLabel.Text = "Brightness: " + remote.GetLightsBrightness() + "%";
        }

        private void MorningNewsButton_Click(object sender, EventArgs e)
        {
            remote.SetTVStatus(true);
            remote.SetTVInput("Channel 1");
            remote.SetSoundSystemStatus(true);
            remote.SetSoundSystsemVolume(50);
            remote.SetLightsStatus(true);
            remote.SetLightsBrightness(100);
            StatusRefresh();
        }

        private void AfternoonTVButton_Click(object sender, EventArgs e)
        {
            remote.SetTVStatus(true);
            remote.SetTVInput("Channel 2");
            remote.SetSoundSystemStatus(true);
            remote.SetSoundSystsemVolume(75);
            remote.SetLightsStatus(false);
            remote.SetLightsBrightness(100);
            StatusRefresh();
        }

        private void MovieNightButton_Click(object sender, EventArgs e)
        {
            remote.SetTVStatus(true);
            remote.SetTVInput("Netflix");
            remote.SetSoundSystemStatus(true);
            remote.SetSoundSystsemVolume(100);
            remote.SetLightsStatus(true);
            remote.SetLightsBrightness(25);
            StatusRefresh();
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            remote.SetTVStatus(false);
            remote.SetSoundSystemStatus(false);
            remote.SetLightsStatus(false);
            StatusRefresh();
        }
    }
}
