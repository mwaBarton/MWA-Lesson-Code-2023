using System;

namespace L172___Binary_Trees
{
    internal class Program
    {
        struct TreeNode
        {
            public string data;
            public int left, right;
        }

        static TreeNode[] binaryTree;

        static void PreOrder(TreeNode parent)
        {
            Console.WriteLine(parent.data);

            if (parent.left > -1) PreOrder(binaryTree[parent.left]);

            if (parent.right > -1) PreOrder(binaryTree[parent.right]);
        }


        static void Main(string[] args)
        {
            binaryTree = new TreeNode[] {
                new TreeNode() { data = "Humboldt", left = 1, right = 4},
                new TreeNode() { data = "Adelie", left = -1, right = 2},
                new TreeNode() { data = "Emperor", left = 3, right = 6},
                new TreeNode() { data = "African", left = -1, right = -1},
                new TreeNode() { data = "Macaroni", left = 7, right = 5},
                new TreeNode() { data = "Snares", left = -1, right = -1},
                new TreeNode() { data = "Fairy", left = -1, right = -1},
                new TreeNode() { data = "King", left = -1, right = -1}
            };

            foreach (TreeNode node in binaryTree)
            {
                if (node.left == -1 && node.right == -1)
                    Console.WriteLine($"{node.data} is a leaf node");
                else if (node.left == -1)
                    Console.WriteLine($"{node.data} has right child {binaryTree[node.right].data}");
                else if (node.right == -1)
                    Console.WriteLine($"{node.data} has left child {binaryTree[node.left].data}");
                else
                    Console.WriteLine($"{node.data} has left child {binaryTree[node.left].data} and has right child {binaryTree[node.right].data}");
            }
            Console.WriteLine();

            PreOrder(binaryTree[0]);

            Console.ReadKey();
        }
    }
}
