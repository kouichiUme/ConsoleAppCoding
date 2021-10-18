using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter13
    {


        // private コンストラクタの利用方法
        // 外部で直接 new されたくない
        // singletonのようなインスタンス化をコントロールしたいときに利用する
        //
        private Chapter13()
        {
            return;
        }

        public class innerClassA{
        
        }



        public static void checkReturn()
        {
            try
            {
                Console.WriteLine("Return!");
                return;
            }
            catch
            {
            }
            finally
            {

                Console.WriteLine("After Return!");
            }

        }

    }
}
