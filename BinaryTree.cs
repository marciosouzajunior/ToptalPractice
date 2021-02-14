using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalPractice
{

    public class BinaryTree
    {

        public static void BTree()
        {

            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.right = new Node(6);
            root.right.right.left = new Node(7);
            root.right.right.right = new Node(8);

            //Traverse(root);
            Console.WriteLine("Max sum: {0}.", FindMaxSum(root));
            Console.WriteLine("Max path: {0}.", FindMaxPath(root));

        }

        public static void Traverse(Node root)
        {

            if (root == null)
                return;

            Console.WriteLine("Node = {0}", root.value);

            Traverse(root.left);
            Traverse(root.right);

        }

        public static int FindMaxSum(Node root)
        {

            if (root == null)
                return 0;

            // Recursive calls
            int left = FindMaxSum(root.left);
            int right = FindMaxSum(root.right);

            // Consider the maximum sum child
            if (left > right)
            {
                return left + root.value;
            } else
            {
                return right + root.value;
            }

        }

        public static int FindMaxPath(Node root)
        {

            if (root == null)
                return 0;

            // Recursive calls
            int left = FindMaxPath(root.left);
            int right = FindMaxPath(root.right);

            // Consider the maximum path child
            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }

        }

    }

    public class Node
    {

        public int value;
        public Node left;
        public Node right;

        public Node(int val)
        {
            value = val;
            left = null;
            right = null;
        }

    }

}
