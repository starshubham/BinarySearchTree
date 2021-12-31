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

            //UC2
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            binarySearch.GetSize();
            Console.WriteLine("*********Program End*********\n");
        }
    }
}
