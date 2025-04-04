using System;
using System.Collections.Generic;
using System.Threading;

namespace POE_part_1
{
    public static class SecurityTips
    {
        private static List<string> securityTips = new List<string>
        {
            "Use strong, unique passwords for each account.",
            "Enable two-factor authentication (2FA) whenever possible.",
            "Be cautious of phishing emails and links.",
            "Keep your software and operating system updated.",
            "Use a reputable antivirus and firewall.",
            "Avoid using public Wi-Fi for sensitive transactions.",
            "Regularly back up important data.",
            "Be mindful of the personal information you share online.",
            "Use a VPN when accessing sensitive information remotely.",
            "Lock your devices with strong passwords or biometrics."
        };

        public static void AddSecurityTip()
        {
            Console.Write("Enter a cybersecurity tip: ");
            string tip = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(tip))
            {
                securityTips.Add(tip);
                Console.WriteLine("Security tip added successfully.");
            }
            else
            {
                Console.WriteLine("Tip cannot be empty.");
            }
            Thread.Sleep(1000);
        }

        public static void DisplaySecurityTips()
        {
            Console.WriteLine("Cybersecurity Tips:");
            if (securityTips.Count > 0)
            {
                foreach (var tip in securityTips)
                {
                    Console.WriteLine("- " + tip);
                }
            }
            else
            {
                Console.WriteLine("No tips available.");
            }
            Thread.Sleep(2000);
        }
    }
}
