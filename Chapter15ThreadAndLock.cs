using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{

    class ChopStick
    {
        private ReaderWriterLock _lock;
        private ChopStick pair;

        public ChopStick()
        {
            _lock = new ReaderWriterLock();

        }

        public bool pickUp()
        {
            // AquireReadLock needs timeout
            _lock.AcquireReaderLock(1000);
            if (!pair.pickUp()) {
                _lock.ReleaseReaderLock();
                return false;
            }

            return true;

        }

        public void putDown()
        {
            _lock.ReleaseReaderLock();

        }

    }


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


            ChopStick chopStick = new ChopStick();
            Console.WriteLine("");

            Thread t = new Thread(new ThreadStart(sread));

            t.Start();

            TimeSpan ts  = beforeStart  - DateTime.Now;

            Console.WriteLine(ts);

            lock (chopStick)
            {
                

            }

        }

    }
}
