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

    class Class3Stack
    {
        private LinkedList<NodeOfThree<int>> node;

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

    }

    class Class3Problem2Stack<T > where T : IComparable
    {

        private LinkedList<T> listStack = null;
        private T min ;



        public void add(T t)
        {
            listStack.AddLast(t);
            if(t.CompareTo(min) < 0)
            {
                min = t;
            }

        }

        // これだとO(1)ではない
        public T pop()
        {
            T t = listStack.Last.Value;
            
            // 最後のノードが最小値だった場合
            if (t.CompareTo(min) ==0 )
            {
                T i = listStack.First.Value;
                foreach(T x in listStack)
                {
                    if (x.CompareTo(i) < 0)
                    {
                        min = x;
                        
                    }

                }


            }


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

    
