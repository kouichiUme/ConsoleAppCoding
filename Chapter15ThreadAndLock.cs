using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    public class Chapter15ThreadAndLock 
    {

        public static void sread()
        {

            Console.WriteLine("");

            return;
        }

        public static void sreadCaller()
        {

            DateTime beforeStart = DateTime.Now;
            
            
            Console.WriteLine("");

            Thread t = new Thread(new ThreadStart(sread));

            t.Start();

            TimeSpan ts  = beforeStart  - DateTime.Now;

            Console.WriteLine(ts);



        }

    }
}
