using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MultiThread
    {
        public dynamic transPose()
        {
            decimal l= 0M;
            dynamic lockObject = new Object();

            lock(lockObject)
            {

                l = 1.0M;


            }

            dynamic resultObject = new Object();
            resultObject["result"] = l;


            return resultObject;


        }
    }
}
