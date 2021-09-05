using System;
using System.Collections.Generic;
using System.Text;

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




    }


    
}
