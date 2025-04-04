using System;
using System.Collections.Generic;
using System.Threading;

namespace POE_part_1
{
    public static class ThreatReports
    {
        private static List<string> threatReports = new List<string>();

        public static void ReportThreat()
        {
            Console.Write("Describe the cybersecurity threat: ");
            string threat = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(threat))
            {
                threatReports.Add(threat);
                Console.WriteLine("Threat reported successfully.");
            }
            else
            {
                Console.WriteLine("Threat description cannot be empty.");
            }
            Thread.Sleep(1000);
        }

        public static void DisplayThreatReports()
        {
            Console.WriteLine("Reported Threats:");
            if (threatReports.Count > 0)
            {
                foreach (var threat in threatReports)
                {
                    Console.WriteLine("- " + threat);
                }
            }
            else
            {
                Console.WriteLine("No threats reported.");
            }
            Thread.Sleep(2000);
        }
    }
}
