using System;
using System.Threading;

namespace POE_part_1
{
    public static class AsciiArt
    {
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"  Shabalala's Cybersecurity AI Assistant  ");
            Console.WriteLine(@"   Protecting your online presence!  ");
            Console.WriteLine(@"  ");
            Console.WriteLine(@"  ST10450875                        ");
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}
