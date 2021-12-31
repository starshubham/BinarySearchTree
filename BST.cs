﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item) > 0))
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }

        bool flag;
        public bool Search(T element, BinarySearchTree<T> node)
        {
            
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                flag = true;
            }           
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);

            }

            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.LeftTree);
            }
            else if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.RightTree);
            }
            return flag;
        }

        //Or We can Use this method for Searchin an element

        //bool flag;
        //public bool Search(T item, BinarySearchTree<T> tree) //search the node in the binary tree
        //{

        //    if (tree == null)
        //        return false;
        //    if (tree.NodeData.Equals(item))
        //    {
        //        flag = true;
        //    }
        //    else if (tree.NodeData.CompareTo(item) < 0)
        //    {
        //        Search(item, tree.RightTree);
        //    }
        //    else
        //    {
        //        Search(item, tree.LeftTree);
        //    }
        //    return flag;
        //}
    }
}
