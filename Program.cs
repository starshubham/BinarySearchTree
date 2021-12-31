using System;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree!");

            //UC1
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.Display();
            Console.WriteLine("*********End UC1 Program*********\n");

        }
    }
}
