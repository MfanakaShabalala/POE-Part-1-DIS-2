using System;
using System.Threading;
using NAudio.Wave;

namespace POE_part_1
{
    public static class AudioManager
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                using (var audioFile = new AudioFileReader("Cybersecurity.wav"))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(500);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }

        public static void PlaySecurityAlert()
        {
            Console.Beep(1000, 500); // Play a beep sound
            Console.WriteLine("Security alert sound played.");
        }
    }
}
