using System;
using System.Collections.Generic;
using System.Threading;

namespace PoorlyPerformingApplicationDemo
{
    public class Program
    {
        private static void Main()
        {
            new List<Thread>
            {
                new Thread(Sleep.AlotAndOccasionallyPrint),
                new Thread(Pi.Calculate),
                new Thread(SomethingElse.ThatSecretlyCalculatesPiOnce)

            }.ForEach(x=>x.Start());

            Console.WriteLine("Doing some stuff. Press any key to exit");
            Console.ReadKey();
        }
    }
}
