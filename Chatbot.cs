using System;

namespace CyberSecurityBot
{
    // This class contains the chatbot logic and responses
    internal class Chatbot
    {
        // Stores the user's name for personalised interaction
        private string userName;

        // Constructor assigns the user's name when chatbot is created
        public Chatbot(string name)
        {
            userName = name;
        }

        // Starts the chatbot conversation loop
        public void StartChat()
        {
            UIHelper.Divider();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {userName}! 👋 Ask me anything about cybersecurity.");
            Console.ResetColor();

            UIHelper.Divider();

            // Infinite loop to keep chatbot running until user exits
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                // Read user input and convert to lowercase for easier matching
                string input = Console.ReadLine()?.ToLower();

                // Input validation: check for empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("⚠️ Please enter something.");
                    continue;
                }

                // Exit condition
                if (input.Contains("exit"))
                {
                    Console.WriteLine("👋 Goodbye! Stay safe online.");
                    break;
                }

                // Process user input
                Respond(input);
            }
        }

        // This method determines how the bot responds to input
        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");
            Console.ResetColor();

            // Check for keywords and respond accordingly

            if (input.Contains("how are you"))
            {
                UIHelper.TypingEffect("I'm functioning perfectly and ready to help you stay safe online! 😄");
            }
            else if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                UIHelper.TypingEffect("My purpose is to educate you about cybersecurity and help you avoid online threats.");
            }
            else if (input.Contains("password"))
            {
                UIHelper.TypingEffect("Use strong passwords with uppercase, lowercase, numbers, and symbols. Never reuse passwords!");
            }
            else if (input.Contains("phishing"))
            {
                UIHelper.TypingEffect("Phishing scams try to trick you into giving personal info. Always verify suspicious emails.");
            }
            else if (input.Contains("link") || input.Contains("url"))
            {
                UIHelper.TypingEffect("Avoid clicking unknown links. Always check the URL before opening.");
            }
            else if (input.Contains("safe browsing"))
            {
                UIHelper.TypingEffect("Use secure websites (https), avoid public Wi-Fi for sensitive tasks, and keep your browser updated.");
            }
            else if (input.Contains("what can i ask"))
            {
                UIHelper.TypingEffect("You can ask me about passwords, phishing, safe browsing, and general cybersecurity tips.");
            }
            else
            {
                // Default response if input is not recognised
                UIHelper.TypingEffect("I didn’t quite understand that. Could you rephrase?");
            }
        }
    }
}