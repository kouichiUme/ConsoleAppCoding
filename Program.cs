using System;
using log4net;
using log4net.Config;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        // build
        // msbuild /t:Metrics
        static void Main(string[] args)
        {
            BasicConfigurator.Configure();


            log.Info("Entering application.");
            Console.WriteLine("Hello World!");
        }
    }
}
