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

        }

        public static void sreadCaller()
        {

            Thread t = new Thread(new ThreadStart(sread));



        }

    }
}
