using System;
using System.Diagnostics; 
using System.Threading; 
class StopWatch
{
    static void Main(string[] args)
    {
        Stopwatch stop_watch = new Stopwatch();
        while (true)
        {

            stop_watch.Start();
            Thread.Sleep(1000);
            stop_watch.Stop();
            TimeSpan tspan = stop_watch.Elapsed;
            Console.Clear();
            string elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            Console.WriteLine(" RunTime " + elapsedTime);
        }

    }
}