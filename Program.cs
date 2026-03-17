using System;
using CyberSecurityBot;

class Program
{
    // Entry point of the application
    static void Main()
    {
        // Set console window title
        Console.Title = "Cybersecurity Awareness Bot";

        // Display logo
        UIHelper.ShowLogo();

        // Play voice greeting
        AudioPlayer.PlayGreeting();

        // Get user details
        User user = GetUser();

        // Create chatbot instance with user's name
        Chatbot bot = new Chatbot(user.Name);

        // Start chatbot interaction
        bot.StartChat();
    }

    // Method to get and validate user name input
    static User GetUser()
    {
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        // Input validation loop
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("⚠️ Please enter a valid name: ");
            name = Console.ReadLine();
        }

        // Return a new User object with the entered name
        return new User { Name = name };
    }
}