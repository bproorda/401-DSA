using DataStructures;
using DataStructures.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public int Count { get; set; }

        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

        }

        public int[] PreOrderHandler()
        {
            int[] result = new int[Count];
            MyStack<int> treeStack = new MyStack<int>();
            Node current = Root;
            PreOrder(treeStack, current);

            for (int i = (Count - 1); i >= 0; i--)
            {
                result[i] = treeStack.pop();
            }

            return result;
        }

        public void PreOrder(MyStack<int> treestack, Node current)
        {
            treestack.push(current.Value);

            if (current.Left != null)
            {
                PreOrder(treestack, current.Left);
            }
            if (current.Right != null)
            {
                PreOrder(treestack, current.Right);
            }

        }

    }

    public class BinarySearchTree : BinaryTree
    {


        public void add(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (Root == null)
            {
                Root = newNode;
            } else
            {
                Node current = Root;
                bool toggle = true;
                while (toggle)
                {
                    if (value > current.Value)
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        } else
                        {
                            current = current.Right;
                        }
                    }
                    else if (value <= current.Value)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            break;
                        } else
                        {
                            current = current.Left;
                        }
                    }


                }
            }
            Count++;
        }

    
}   }

