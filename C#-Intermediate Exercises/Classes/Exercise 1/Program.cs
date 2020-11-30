using System;
using System.Threading;

namespace Exercise_1
{


    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            Thread.Sleep(5000);
            stopWatch.Stop();
            TimeSpan duration = stopWatch._duration;
            Console.WriteLine(duration);

        }
    }
}
