using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4Graph<T> where T : IComparable
    {


        LinkedList<T> vertexes;
        LinkedList<KeyValuePair<T,T>> edges;

        public LinkedList<T> getNodes()
        {
            return vertexes;
        }


        public void findNodeToNode()
        {

        }



        class GraphNode<T> where T : IComparable
        {
            
        }

        internal class GraphNode
        {
            public IEnumerable<GraphNode> getAdjacent()
            {

                return new LinkedList<GraphNode>();

            }

        }
    }
}
