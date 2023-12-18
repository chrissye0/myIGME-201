using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestFinal_Q3
{
    // Author: Christine Espeleta
    // Final Unit Test Question #5
    // Using the console application created in #3, implement Dijkstra's shortest path algorithm to output the shortest path of colors from red to green.

    enum Colors
    {
        LightBlue,
        Blue,
        Red,
        Gray,
        Orange,
        Purple,
        Yellow,
        Green
    }
    public class Program
    {
        static bool[,] mGraph = new bool[,]
        {                       // "Light Blue"  "Blue"  "Red"  "Gray"  "Orange"  "Purple"  "Yellow"  "Green"
                /* Light Blue */ {  false,        true,  false,  true,   false,    false,    false,    false },
                /* Blue */       {  true,         false,  false, false,  false,    false,    true,     false },
                /* Red */        {  false,        true,   false, true,   false,    false,    false,    false },
                /* Gray */       {  true,         false,  false, false,  true,     false,    false,    false },
                /* Orange */     {  false,        false,  false, false,  false,    true,     false,    false },
                /* Purple */     {  false,        false,  false, false,  false,    false,    true,     false },
                /* Yellow */     {  false,        false,  false, false,  false,    false,    false,    true  },
                /* Green */      {  false,        false,  false, false,  false,    false,    false,    false }
        };

        static int[][] lGraph = new int[][]
        {
            /* Light Blue */ new int[] { (int)Colors.Blue, (int)Colors.Gray },
            /* Blue */       new int[] { (int)Colors.LightBlue, (int)Colors.Yellow },
            /* Red */        new int[] { (int)Colors.Blue, (int)Colors.Gray },
            /* Gray */       new int[] { (int)Colors.LightBlue, (int)Colors.Orange },
            /* Orange */     new int[] { (int)Colors.Purple },
            /* Purple */     new int[] { (int)Colors.Yellow },
            /* Yellow */     new int[] { (int)Colors.Green },
            /* Green */      null
        };

        static List<Node> game = new List<Node>();

        static void Main(string[] args)
        {
            Node node;
            // add nodes for all colors
            node = new Node((int)Colors.LightBlue);
            game.Add(node);

            node = new Node((int)Colors.Blue);
            game.Add(node);

            node = new Node((int)Colors.Red);
            game.Add(node);

            node = new Node((int)Colors.Gray);
            game.Add(node);

            node = new Node((int)Colors.Orange);
            game.Add(node);

            node = new Node((int)Colors.Purple);
            game.Add(node);

            node = new Node((int)Colors.Yellow);
            game.Add(node);

            node = new Node((int)Colors.Green);
            game.Add(node);

            // add the weighted edges for each color
            game[(int)Colors.LightBlue].AddEdge(0, game[(int)Colors.Gray]);
            game[(int)Colors.LightBlue].AddEdge(1, game[(int)Colors.Blue]);
            game[(int)Colors.LightBlue].edges.Sort();

            game[(int)Colors.Blue].AddEdge(1, game[(int)Colors.LightBlue]);
            game[(int)Colors.Blue].AddEdge(8, game[(int)Colors.Yellow]);
            game[(int)Colors.Blue].edges.Sort();

            game[(int)Colors.Red].AddEdge(1, game[(int)Colors.Blue]);
            game[(int)Colors.Red].AddEdge(5, game[(int)Colors.Gray]);
            game[(int)Colors.Red].edges.Sort();

            game[(int)Colors.Gray].AddEdge(0, game[(int)Colors.LightBlue]);
            game[(int)Colors.Gray].AddEdge(1, game[(int)Colors.Orange]);
            game[(int)Colors.Gray].edges.Sort();

            game[(int)Colors.Orange].AddEdge(1, game[(int)Colors.Purple]);
   
            game[(int)Colors.Purple].AddEdge(1, game[(int)Colors.Yellow]);

            game[(int)Colors.Yellow].AddEdge(6, game[(int)Colors.Green]);

            List<Node> shortestPath = GetShortestPathDijkstra();

            foreach (Node spNode in shortestPath)
            {
                Console.WriteLine((Colors)spNode.nState);
            }
        }

        static public List<Node> GetShortestPathDijkstra()
        {
            // set up all distances from every vertex to the start vertex
            DijkstraSearch();

            // the list of nodes that will be the shortest path from the start
            List<Node> shortestPath = new List<Node>();

            // add the target node (green)
            shortestPath.Add(game[(int)Colors.Green]);

            // populate the List of nodes from the target node back to the start
            BuildShortestPath(shortestPath, game[(int)Colors.Green]);

            // reverse the List to give the path from the start to the finish
            shortestPath.Reverse();

            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            // starting node (red)
            Node start = game[(int)Colors.Red];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            // next 2 lines are equivalent
            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 5 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(nodeOrderBy).ToList();
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in node.edges)
                // if we do not sort each list of edges after populating them for a node,
                // we can create a temporary sorted list for this loop
                //foreach (Edge cnn in node.edges.OrderBy(delegate(Edge n) { return n.cost; }))
                {
                    // look at the neighbor connected to this edge
                    Node neighborNode = cnn.connectedNode;
                    if (neighborNode.visited)
                    {
                        // skip if we already visited this neighbor
                        continue;
                    }

                    // if this neighbor has not been evaluated yet or
                    // it is closer than the current path to start
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // update the cost to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;

                        // set the node heading back to start from this neighbor to the 
                        // node we got here by
                        neighborNode.nearestToStart = node;

                        // if we don't have this neighbor in our queue
                        if (!prioQueue.Contains(neighborNode))
                        {
                            // add it
                            prioQueue.Add(neighborNode);
                        }
                    }
                }

                // set this node as visited
                node.visited = true;

                // if we reached the target node
                if (node == game[(int)Colors.Green])
                {
                    // we're done!
                    return;
                }

                // stay in this loop while there are any items left in our queue
            } while (prioQueue.Any());
        }
    }

    public class Node : IComparable<Node>
    {
        public int nState;
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }
}