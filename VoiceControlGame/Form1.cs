using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace VoiceControlGame
{
    public partial class Form1 : Form
    {
        private int NumTube = 3;
        private WaveIn recorder;
        public Form1()
        {
            InitializeComponent();

            recorder = new WaveIn();
            recorder.StartRecording();

            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            inputDevice.Items.AddRange(devices.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controlGameBtn_Click(object sender, EventArgs e)
        {
            globalTimer.Enabled = true;
            localTimer.Enabled = true;
        }

        public int voice;
        private void globalTimer_Tick(object sender, EventArgs e)
        {
            if(inputDevice.SelectedItem != null)
            {
                var selected = (MMDevice)inputDevice.SelectedItem;
                selected.AudioEndpointVolume.Mute = false;
                //voice = (int)(Math.Round(selected.AudioMeterInformation.MasterPeakValue * 300));
                textBox1.Text = voice.ToString();
                voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 300+0.5);
                voiceVolume.Value = voice;
            }
        }

        public void movehurdle()
        {
                if (tube.Left > 0)
                {
                    tube.Left += -4;
                }
                else
                {
                    tube.Left = 700;
                }

            if ((tube2).Left > 0)
            {
                tube2.Left += -4;
            }
            else
            {
                tube2.Left = 700;
            }

            if (tube3.Left > 0)
            {
                tube3.Left += -4;
            }
            else
            {
                tube3.Left = 700;
            }

            if (tube4.Left > 0)
            {
                tube4.Left += -4;
            }
            else
            {
                tube4.Left = 700;
            }

            //foreach()
        }

        public void gameover()
        {
            if(tube.Bounds.IntersectsWith(bird.Bounds) || tube2.Bounds.IntersectsWith(bird.Bounds) ||
               tube3.Bounds.IntersectsWith(bird.Bounds) || tube4.Bounds.IntersectsWith(bird.Bounds))
                {
                globalTimer.Enabled = false;
                localTimer.Enabled = false;
                MessageBox.Show("GameOver");
                
            }
        }
        private void localTimer_Tick(object sender, EventArgs e)
        {
            if(voice > 15)
            {
                bird.Top += -3;
            }
            else
            {
                if (bird.Top < 580)
                    bird.Top += 2;
            }
            movehurdle();
            gameover();
        }
    }
}
