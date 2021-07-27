using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Chapter4Problem1Graph<T> where T : IComparable
    {

        Class4Graph<T> g;

        public Chapter4Problem1Graph()
        {

            this.g = new Class4Graph<T>();

        }


        class ExtendedT<G> where G : Class4Graph<T>.GraphNode
        {
            public G t;
            public state s;
            LinkedList<ExtendedT<Class4Graph<T>.GraphNode>> adjacents;

            public ExtendedT(G t)
            {
                this.t = t;
                this.s = state.Unvisited;

                adjacents = new LinkedList<ExtendedT<Class4Graph<T>.GraphNode>>();


                foreach (Class4Graph<T>.GraphNode g in t.getAdjacent())
                {
                    adjacents.AddLast(new ExtendedT<Class4Graph<T>.GraphNode>(g));

                }


            }


            //Class4Graph<T>.GraphNode を Gと書きたい
            public IEnumerable<ExtendedT<Class4Graph<T>.GraphNode>> getAdjacnet(){

                // 
                return this.adjacents;
            }
        }

        enum state
        {
            Unvisited, Visited, Visiting
        }

        /// <summary>
        ///  グラフは thisで代用する
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>

        public bool search(T start, T end)
        {


            bool result = false;


            LinkedList<ExtendedT<Class4Graph<T>.GraphNode>> q = new LinkedList<ExtendedT<Class4Graph<T>.GraphNode>>();
            LinkedList<ExtendedT<Class4Graph<T>.GraphNode>> tmpGraph = new LinkedList<ExtendedT<Class4Graph<T>.GraphNode>>();


            // 状態を追加して再設定
            foreach (T t in g.getNodes())
            {
                ExtendedT<Class4Graph<T>.GraphNode> et = new ExtendedT<Class4Graph<T>.GraphNode>(new Class4Graph<T>.GraphNode(t));
                et.s = state.Unvisited;
                tmpGraph.AddLast(et);
            }

            ExtendedT<Class4Graph<T>.GraphNode> startNode = new ExtendedT<Class4Graph<T>.GraphNode>(new Class4Graph<T>.GraphNode(start));

            q.AddLast(startNode);


            ExtendedT<Class4Graph<T>.GraphNode> u;
            bool finined = false;
            while (q.Count != 0 || finined)
            {
                u = q.First.Value;
                q.RemoveFirst();


                if(u != null)
                {
                    foreach(ExtendedT<Class4Graph<T>.GraphNode> v in u.getAdjacnet())
                    {

                        // まだだったら
                        if(v.s == state.Unvisited)
                        {
                            // vがendと同じか？
                            if (v.Equals(end))
                            {
                                // 
                                // コーディングレビュー
                                // ここでリターンしないとどうなるか？
                                // break ? goto　などループから抜ける？
                                // 
                                v.s = state.Visited;
                                // break whileBreak;
                                // goto whileBreak;
                                finined = true;
                                break;
                                // return true;
                            }
                            else
                            {
                                v.s = state.Visiting;
                                q.AddLast(v);
                            }

                        }

                    }
                    
                    u.s = state.Visited;
                }

            }
        // whileBreak:

            ExtendedT<Class4Graph<T>.GraphNode > endNode = new ExtendedT<Class4Graph<T>.GraphNode>(new Class4Graph<T>.GraphNode(end));
            // result を返すのではなくて
            // falseでいいかも
            // c/c++だったとしたらメモリ管理上どうなるか？
            // if(end.s == state.Visisted){
            // result = true;
            // }
            //
            return result;
        }



    }




}
