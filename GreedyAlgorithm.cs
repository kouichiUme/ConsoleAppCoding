using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GreedyAlgorithm
    {

        Stack<int> stack;



        public void huffman(int c)
        {




        }



        public int[] multiPop(int k)
        {
            Stack<int> res = new Stack<int>();

            while (k > 0 || this.stack.Count >= 0)
            {
                res.Push(this.stack.Pop());
                k--;
            }
            return res.ToArray();
        }
    }
}
