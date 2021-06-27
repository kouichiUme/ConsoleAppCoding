using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter2Link<T> where T : new ()

    {

        public T getNewItem()
        {
            return new T();
        }

        public static void deleteDuplicatedNode(LinkedList<T> ll ,T v)
        {

            

            LinkedListNode < T > n = null;
            do
            {
                n = ll.Find(v);

                if (n != null)
                {
                    ll.Remove(n);
                }

            }
            while (n != null);


            return;

        }



    }
}
