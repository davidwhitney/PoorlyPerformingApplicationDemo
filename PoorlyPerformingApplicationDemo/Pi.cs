using System;

namespace PoorlyPerformingApplicationDemo
{
    public static class Pi
    {
        public static void Calculate()
        {
            Console.WriteLine("This thread calculates PI");
            
            while (true)
            {
                const int digits = 8000;
                ActuallyDoIt(digits);
                Console.WriteLine("Calculated PI to " + digits + " digits. Starting again...");
            }
        }

        private static void ActuallyDoIt(int digits)
        {
            digits++;

            var x = new uint[digits*3 + 2];
            var r = new uint[digits*3 + 2];

            for (var j = 0; j < x.Length; j++)
            {
                x[j] = 20;
            }

            for (var i = 0; i < digits; i++)
            {
                uint carry = 0;
                for (var j = 0; j < x.Length; j++)
                {
                    var num = (uint) (x.Length - j - 1);
                    var dem = num*2 + 1;

                    x[j] += carry;

                    var q = x[j]/dem;
                    r[j] = x[j]%dem;

                    carry = q*num;
                }

                if (i < digits - 1)
                {
                }

                r[x.Length - 1] = x[x.Length - 1]%10;

                for (var j = 0; j < x.Length; j++)
                {
                    x[j] = r[j]*10;
                }
            }
        }
    }
}