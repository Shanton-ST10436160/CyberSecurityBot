using System;
using System.Threading;

namespace CyberSecurityBot
{
    // This class handles all console UI elements (visual styling)
    internal class UIHelper
    {
        // Displays the ASCII logo when the program starts
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
      .----.
     /      \
    | 0  0  |   WARNING!
    |  --   |  Your password
    |  ><   |  is probably ""1234""
     \______/  
    / |    | \
   |  |    |  |
   '~~'    '~~'
 CYBERSECURITY
 AWARENESS BOT
");

            // Reset colour back to default
            Console.ResetColor();
        }

        // Displays a divider line to improve readability
        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }

        // Simulates typing by printing characters one at a time
        public static void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20); // Small delay to simulate typing
            }
            Console.WriteLine();
        }
    }
}