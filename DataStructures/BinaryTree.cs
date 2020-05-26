using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinaryTree<T>
    {
        Node Root { get; set; }

        public class Node 
        {
            T Value { get; set; }
            Node Left { get; set; }
            Node Right { get; set; }

        }

    }

    public class BinarySearchTree : BinaryTree<int>
    {

    }
}
