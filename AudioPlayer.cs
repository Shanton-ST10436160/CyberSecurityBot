using System;
using System.Media;

namespace CyberSecurityBot
{
    // This class is responsible for handling audio playback
    internal class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Creates a SoundPlayer object and loads the WAV file
                SoundPlayer player = new SoundPlayer("Assets/greeting.wav");

                // Plays the audio file and waits until it finishes before continuing
                player.PlaySync();
            }
            catch (Exception)
            {
                // If an error occurs (e.g., file not found), display an error message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Unable to play greeting audio.");
                Console.ResetColor();
            }
        }
    }
}