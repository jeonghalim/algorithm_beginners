using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    public enum State { Unvisited, Visited, Visiting }
    public class Node
    {
        public State state;
        public Node[] getAdjacent()
        {
            return null;
        }
    }

    public class Graph
    {
        public Node[] getNodes()
        {
            return null;
        }
    }

    class Program
    {
        public bool search(Graph g, Node start, Node end)
        {
            if (start == end) return true;

            // == 초기화 ==
            for (Node u : g.getNodes())
            {
                u.state = State.Unvisited;
            }

            // == 너비우선탐색(BFS) - queue ==
            List<Node> q = new List<Node>();
            start.state = State.Visiting;
            q.Add(start);
            Node u;
            while (q.Count !=0)
            {
                u = (Node)q.();

                if (u != null)
                {
                    for (Node v : u.getAdjacent())
                    {
                        if (v.state == State.Unvisited)
                        {
                            if (v == end)
                            {
                                return true;
                            }
                            else
                            {
                                v.state = State.Visiting;
                                q.Add(v);
                            }
                        }
                    }
                    u.state = State.Visited;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

        }
    }
}
