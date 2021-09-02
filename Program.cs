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


            XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));

            log.Info("Entering application.");
            
            Console.WriteLine("Hello World!");


            log.Info("End application.");

        }
    }
}
