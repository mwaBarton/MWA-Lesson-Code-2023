using System;

namespace L172___Binary_Trees
{
    internal class Program
    {
        public struct Node
        {
            public int left, right;
            public string data;
        }

        static Node[] tree;

        static void populateWithPenguins()
        {
            tree = new Node[] {
                new Node() { left = 2, data = "Humboldt", right = 5 },
                new Node() { left = 0, data = "Adelie", right = 3 },
                new Node() { left = 4, data = "Emperor", right = 7 },
                new Node() { left = 0, data = "African", right = 0 },
                new Node() { left = 8, data = "Macaroni", right = 6 },
                new Node() { left = 0, data = "Snares", right = 0 },
                new Node() { left = 0, data = "Fairy", right = 0 },
                new Node() { left = 0, data = "King", right = 0 }
            };


            int[] a = new int[] { 1, 2, 3 };
        }

        static void preOrder(Node currentNode)
        {
            // Visit node
            Console.WriteLine(currentNode.data);

            // Traverse left subtree
            if (currentNode.left > 0) preOrder(tree[currentNode.left - 1]);

            // Traverse right subtree
            if (currentNode.right > 0) preOrder(tree[currentNode.right - 1]);
        }

        static void printTree()
        {
            foreach (Node n in tree)
            {
                if (n.left == 0 && n.right == 0)
                {
                    Console.WriteLine($"{n.data} is a leaf penguin.");
                }
                else if (n.left == 0)
                {
                    Console.WriteLine($"{n.data} has right child {tree[n.right - 1].data}");
                }
                else if (n.right == 0)
                {
                    Console.WriteLine($"{n.data} has left child {tree[n.left - 1].data}");
                }
                else
                {
                    Console.WriteLine($"{n.data} has left child {tree[n.left - 1].data} and right child {tree[n.right - 1].data}");
                }
            }
        }

        static void preOrderTraversal(Node currentNode, int depth)
        {
            Console.Write(new string(' ', depth * 3));
            Console.WriteLine(currentNode.data);

            if (currentNode.left > 0 || currentNode.right > 0)
            {
                Console.Write(new string(' ', depth * 3));
                Console.WriteLine("(");
            }

            // Traverse left
            if (currentNode.left > 0)
            {
                preOrderTraversal(tree[currentNode.left - 1], depth + 1);
                Console.Write(new string(' ', depth * 3 + 3));
                Console.WriteLine(",");
            }

            // Traverse left
            if (currentNode.right > 0)
            {
                preOrderTraversal(tree[currentNode.right - 1], depth + 1);
            }

            if (currentNode.left > 0 || currentNode.right > 0)
            {
                Console.Write(new string(' ', depth * 3));
                Console.WriteLine(")");
            }
        }


        static void Main(string[] args)
        {
            populateWithPenguins();
            printTree();

            Console.WriteLine();

            preOrderTraversal(tree[0], 1);

            Console.ReadKey();
        }
    }
}
