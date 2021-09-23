using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter11Test
    {

        public static void printUnsignedInt()
        {

            int i = 0;
            uint ui = 0;
            System.Console.WriteLine("{0}", i);
            System.Console.WriteLine("{0}", ui);
        }



        public static void randomCrash()
        {
            
            for(int i = 0; i< 10; i++)
            {
                System.Console.WriteLine("{10}", i);
            }


        }

        /// <summary>
        /// x、yに移動できるかどうかを返す
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static bool canMoveTo(int x , int y)
        {



            return false;
        }
        






    }
}
