using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter2Link<T> where T : new()



    {
        class Node<T> where T : new()
        {
            public T t;
            public Node<T> next;

        }

        private Node<T> node;

        public Chapter2Link(){
            node = new Node<T>();
        }




        public void add(T a)
        {
            Node<T> node = new Node<T>();
            node.t = a;

            Node<T> end;
            for (end = this.node;end.next !=null;end = end.next)
            {
                // なにもしない
            }
            
            end.next = node;
        }

        public T find3rdNode()
        {
            Node<T> d = new Node<T>();
            Node<T> second = new Node<T>();
            Node<T> end;
            int count = 0;
            for(end = node; end.next != null; end = end.next)
            {
                if (count > 2)
                {
                    d = second ;

                }


                if (count > 1)
                {
                    
                    second = end;
                    
                }
                count++;

            }

            return d.t;


        }


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
