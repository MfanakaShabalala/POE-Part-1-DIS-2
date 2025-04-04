using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace POE_part_1
{
    class Program
    {
        static void Main()
        {
            ShowLogo(); // Open the image when the app starts
            AudioManager.PlayVoiceGreeting();
            AsciiArt.DisplayAsciiArt();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==== Cybersecurity AI Chatbot Menu ====");
                Console.ResetColor();
                Console.WriteLine("1. Report a Threat");
                Console.WriteLine("2. View Reported Threats");
                Console.WriteLine("3. Add a Security Tip");
                Console.WriteLine("4. View All Security Tips");
                Console.WriteLine("5. Play Security Alert Sound");
                Console.WriteLine("6. Clear Page");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ThreatReports.ReportThreat(); break;
                    case "2": ThreatReports.DisplayThreatReports(); break;
                    case "3": SecurityTips.AddSecurityTip(); break;
                    case "4": SecurityTips.DisplaySecurityTips(); break;
                    case "5": AudioManager.PlaySecurityAlert(); break;
                    case "6": Console.Clear(); Console.WriteLine("Page Cleared."); Thread.Sleep(1000); break;
                    case "7": return;
                    default: Console.WriteLine("Invalid choice. Try again."); Thread.Sleep(1000); break;
                }
            }
        }

        static void ShowLogo()
        {
            string imagePath = @"C:\Users\RC_Student_lab\source\repos\POE part 1\AI Assistance.png";

            try
            {
                if (File.Exists(imagePath))
                {
                    Process.Start(new ProcessStartInfo(imagePath) { UseShellExecute = true });
                }
                else
                {
                    Console.WriteLine("⚠️ Logo not found at: " + imagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening logo: " + ex.Message);
            }
        }
    }
}
