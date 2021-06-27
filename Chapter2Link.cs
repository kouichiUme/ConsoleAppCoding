using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chapter2Link<T> where T :  new()


    {
        class Node<T> where T : new()
        {
            public T t;
            public Node<T> next;

        }

        private Node<T> node;
        public long size =0;

        public Chapter2Link(){
            node = null;
        }




        public void add(T a)
        {
            Node<T> node = new Node<T>();
            node.t = a;
            node.next = null;

            Node<T> end;
            if(this.node == null)
            {
                this.node = node;
            }
            else
            {
                for (end = this.node; end.next != null; end = end.next)
                {
                    // なにもしない
                }

                end.next = node;

            }

        }

        public T find3rdNode(int k)
        {
            Node<T> d = new Node<T>();
            Node<T> second = new Node<T>();
            Node<T> end;


            LinkedList<Node<T>> l = new LinkedList<Node<T>>();
            int count = 0;
            for (end = this.node; count < k-1;   count++)
            {
                end = end.next;
            }

            // 
            for (d= this.node; end.next != null; )
            {
                end = end.next;
                d = d.next;
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
