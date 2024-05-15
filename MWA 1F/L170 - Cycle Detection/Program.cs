using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace L170___Cycle_Detection
{
    public class Node
    {
        private int nodeNum;
        private bool visited = false;
        public Node parent;

        public Node(int nodeNum)
        { 
            this.nodeNum = nodeNum; 
        }

        public void visit()
        {
            visited = true;
            //Console.WriteLine("Visiting node " + nodeNum);
        }

        public bool isVisited() => visited;

        public void reset()
        {
            visited =false;
            parent = null;
        }

        public override string ToString() => nodeNum.ToString();
    }

    public class UndirectedUnweightedGraph
    {
        private Dictionary<Node, List<Node>> adjList;

        public UndirectedUnweightedGraph()
        {
            adjList = new Dictionary<Node, List<Node>>();
        }
        public void AddNode(Node node)
        {
            adjList.Add(node, new List<Node>());
        }
        public void AddEdge(Node n, Node m)
        {
            adjList[n].Add(m);
            adjList[m].Add(n);
        }
        public List<Node> GetNeighbours(Node n) => adjList[n];

        public List<Node> GetNodes() => adjList.Keys.ToList();

        public void ResetNodes()
        {
            foreach (Node n in adjList.Keys)
            {
                n.reset();
            }
        }

        public void CycleDetection()
        {
            List<List<Node>> cycles = new List<List<Node>>();

            foreach (Node start in adjList.Keys)
            {
                ResetNodes();
                Stack<Node> stack = new Stack<Node>();
                stack.Push(start);

                while (stack.Count > 0)
                {
                    Node n = stack.Pop();

                    //Console.WriteLine();
                    n.visit();
                    //Console.WriteLine($"Current stack: " + string.Join<Node>(",", stack.ToArray()));

                    foreach (Node neigh in GetNeighbours(n))
                    {
                        if (stack.Contains(neigh))
                        {
                            //Console.WriteLine("There is a cycle through node " + neigh);

                            Node source = neigh.parent;

                            List<Node> cycle = new List<Node>();
                            cycle.Add(neigh.parent);
                            cycle.Add(neigh);

                            Node p = n;
                            do
                            {
                                cycle.Add(p);
                                p = p.parent;
                            } while (p != source);

                            bool match = false;
                            foreach (List<Node> otherCycle in cycles)
                            {
                                if (otherCycle.Count != cycle.Count) continue;

                                bool different = false;
                                foreach (Node otherNode in otherCycle)
                                {
                                    if (!cycle.Contains(otherNode))
                                    {
                                        different = true;
                                    }
                                }

                                foreach (Node otherNode in cycle)
                                {
                                    if (!otherCycle.Contains(otherNode))
                                    {
                                        different = true;
                                    }
                                }

                                if (!different) match = true;
                            }
                            
                            if (!match) cycles.Add(cycle);

                            //Console.WriteLine($"Potential Cycle: {string.Join(", ", cycle)}");
                        }
                        else if (!neigh.isVisited())
                        {
                            neigh.parent = n;
                            stack.Push(neigh);
                            //Console.WriteLine("Adding " + n + "'s neighbour " + neigh);
                        }
                    }
                }
            }

            if (cycles.Count == 0)
            {
                Console.WriteLine("No cycles were found.");
            } else
            {
                Console.WriteLine($"{cycles.Count} cycle(s) were found: \n");
                foreach (List<Node> cycle in cycles)
                {
                    Console.WriteLine(string.Join(", ", cycle));
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UndirectedUnweightedGraph graph = new UndirectedUnweightedGraph();

            graph.AddNode(new Node(0));
            graph.AddNode(new Node(1));
            graph.AddNode(new Node(2));
            graph.AddNode(new Node(3));
            graph.AddNode(new Node(4));

            List<Node> nodes = graph.GetNodes();
            graph.AddEdge(nodes[0], nodes[1]);
            graph.AddEdge(nodes[1], nodes[2]);
            graph.AddEdge(nodes[2], nodes[0]);
            graph.AddEdge(nodes[3], nodes[4]);

            graph.CycleDetection();

            Console.ReadKey();
        }
    }
}
