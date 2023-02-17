using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class StimulateStopWatchProg
    {
        public static void StopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();

            
            stopwatch.Start(); // Begin timing.

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome To BridgeLab Solution Training center");
                Thread.Sleep(500); // we can also take wait methode
            }

            
            stopwatch.Stop();   // Stop timing.

            
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
