using System;
using System.Threading;

namespace PoorlyPerformingApplicationDemo
{
    public static class Sleep
    {
        public static void AlotAndOccasionallyPrint()
        {
            Console.WriteLine("This thread loops and sleeps");

            while (true)
            {
                Thread.Sleep(1000);
                Console.Write("z");
            }
        }
    }
}