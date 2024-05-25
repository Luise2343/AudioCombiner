using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;
using NAudio.Wave;

namespace AudioCombiner
{
    public partial class Form1 : Form
    {
        private string customerMp3Path;
        private string windowMp3Path;
        private string numberMp3Path;
        private string ttsText;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos MP3|*.mp3"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                customerMp3Path = openFileDialog.FileName;
            }
        }

        private void btnLoadWindow_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos MP3|*.mp3"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                windowMp3Path = openFileDialog.FileName;
            }
        }

        private void btnLoadNumber_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos MP3|*.mp3"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                numberMp3Path = openFileDialog.FileName;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ttsText = txtCustomerName.Text; 
            string ttsPath = Path.Combine(Path.GetTempPath(), "tts.wav");

            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult, 0, new System.Globalization.CultureInfo("es-ES"));
                synthesizer.SetOutputToWaveFile(ttsPath);
                synthesizer.Speak(ttsText);
            }

            PlaySequentialAudio(new[] { customerMp3Path, ttsPath, windowMp3Path, numberMp3Path });
        }

        private void PlaySequentialAudio(string[] audioFiles)
        {
            var waveOut = new WaveOutEvent();
            int currentIndex = 0;
            waveOut.PlaybackStopped += (s, e) =>
            {
                currentIndex++;
                if (currentIndex < audioFiles.Length)
                {
                    System.Threading.Thread.Sleep(10); // 
                    PlayNextAudio(waveOut, audioFiles[currentIndex]);
                }
                else
                {
                    waveOut.Dispose();
                }
            };

            PlayNextAudio(waveOut, audioFiles[currentIndex]);
        }

        private void PlayNextAudio(WaveOutEvent waveOut, string audioFile)
        {
            var reader = new AudioFileReader(audioFile);
            var resampler = new MediaFoundationResampler(reader, WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
            {
                ResamplerQuality = 60
            };
            waveOut.Init(resampler);
            waveOut.Play();
        }
    }
}


