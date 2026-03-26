using System;
using System.Threading;
using System.Diagnostics;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();

            crono1.Start();

            Thread.Sleep(500);

            Stopwatch crono2 = new Stopwatch();

            crono2.Start();

            Thread.Sleep(250);

            crono1.Stop();
            crono2.Stop();

            TimeSpan crono1Ts = crono1.Elapsed;
            TimeSpan crono2Ts = crono2.Elapsed;

            string crono1TsFormatted = $"{crono1Ts.Seconds}.{crono1Ts.Milliseconds:04}";

            Console.WriteLine("RunTime " + crono1TsFormatted);

            string crono2TsFormatted = $"{crono2Ts.Seconds}.{crono2Ts.Milliseconds:04}";

            Console.WriteLine("RunTime " + crono2TsFormatted);
        }
    }
}
