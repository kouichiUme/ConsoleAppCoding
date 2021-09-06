using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class MergeSort<T,V> 
        where T :  class,new()
        where V : struct
  
    {


        public delegate string delegateBroker(string a,string b);

        public event delegateBroker messageBusBrokerEvent;


        public void getFirstNode()
        {

            delegateBroker d;

            try
            {
                checked
                {

                }
            }
            catch(OverflowException ofException)
            {
                // 

            }

            // delegate
            d = delegate (string a, string b)
            {

                return a;
            };

            messageBusBrokerEvent = delegate(string a,string b)
            {
                return "event ";

            };

            string a="a", b="b";
            messageBusBrokerEvent(a,b);


        }


        public void templateGenerics<W>(W w) where W : struct
        {

            int[] a = new int[100];

            // linq

            var tmpList = from e in a
                          where e > a.Average()
                          select e;

            return;
        }


        public unsafe void templatePointer()
        {
            double* dp;

            double v = 1.0;

            dp = &v;



        }



    }


    
}
