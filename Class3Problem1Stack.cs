using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1
{

    class NodeOfThree<T> where T : new()
    {
        public T t;
        public int no;

        public NodeOfThree(T i, int v)
        {
            this.t = i;
            this.no = v;
        }
    }

    //
    class Class3Problem1Stack
    {
        private LinkedList<NodeOfThree<int>> node = new LinkedList<NodeOfThree<int>>(2000);

        public void initThreeStacksInARow()
        {
            this.node = new LinkedList<NodeOfThree<int>>();


        }

        public void addFirst(int i)
        {
            node.AddLast(new NodeOfThree<int>(i, 1));


        }

        public void addSecond(int i)
        {
            node.AddLast(new NodeOfThree<int>(i, 2));
        }

        public void addThird(int i)
        {
            node.AddLast(new NodeOfThree<int>(i, 3));
        }

        public int popFirst()
        {
            int result= 0 ;
            
            foreach( NodeOfThree<int> no3 in node)
            {
                if (node.Last.Value.no == 1)
                {
                    result = node.Last.Value.t;

                }

            }




            return result;
        }

    }

    class Class3Problem2Stack<T > where T : IComparable
    {

        private LinkedList<T> listStack = null;
        private T min ;
        private LinkedList<T> minStack = null;



        public void push(T t)
        {
            listStack.AddLast(t);
            if(t.CompareTo(min) < 0)
            {
                min = t;
                minStack.AddLast(t);
            }

        }

        // これだとO(1)ではない
        public T pop()
        {
            T t = listStack.Last.Value;
            
            // 最後のノードが最小値だった場合
            if (t.CompareTo(min) ==0 )
            {
                minStack.RemoveLast();                

            }

            listStack.RemoveLast();

           return t;
        }

        // O(1) table-key/value or static
        // min 
        public T getMin()
        {

            return this.min;
        }



    }


}

    
