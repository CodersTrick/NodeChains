using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeChains
{

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        
            // +-----+------+
            // |  10  | null +
            // +-----+------+
            Node objFirstNode = new Node() { Value = 10 };

            // +-----+------+    +-----+------+
            // |  10 | null +    |  20  | null +
            // +-----+------+    +-----+------+
            Node objMiddleNode = new Node() { Value = 20 };

            // +-----+------+    +-----+------+
            // |  10  |  *---+--->|  20  | null +
            // +-----+------+    +-----+------+
            objFirstNode.NextNode = objMiddleNode;

            // +-----+------+    +-----+------+   +-----+------+
            // |  10  |  *---+--->|  20  | null +   |  30 | null +
            // +-----+------+    +-----+------+   +-----+------+
            Node objLastNode = new Node() { Value = 30 };

            // +-----+------+    +-----+------+   +-----+------+
            // |  10 |  *---+--->|  20  |  *---+-->|  30  | null +
            // +-----+------+    +-----+------+   +-----+------+
            objMiddleNode.NextNode = objLastNode;

            // iterating over each node and printing the value of node
            PrintNodes(objFirstNode);
        }


        private static void PrintNodes(Node node)
        {
            while (node != null)
            {
                Console.WriteLine("Node value is {0}", node.Value);
                node = node.NextNode;
            }
            Console.ReadKey();
        }
    }
}
