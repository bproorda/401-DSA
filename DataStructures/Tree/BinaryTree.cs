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

        public int[] DepthHandler(string choice)
        {
            int[] result = new int[Count];
            MyStack<int> treeStack = new MyStack<int>();
            Node current = Root;
            switch (choice)
            {
                case "preorder":
                    PreOrder(treeStack, current);
                    break;
                case "inorder":
                    InOrder(treeStack, current);
                    break;
                case "postorder":
                    PostOrder(treeStack, current);
                    break;
                default:
                    break;
            }

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

        public void InOrder(MyStack<int> treestack, Node current)
        {
            if (current.Left != null)
            {
                InOrder(treestack, current.Left);
            }

            treestack.push(current.Value);

            if (current.Right != null)
            {
                InOrder(treestack, current.Right);
            }

        }

        public void PostOrder(MyStack<int> treestack, Node current)
        {
            if (current.Left != null)
            {
                PostOrder(treestack, current.Left);
            }


            if (current.Right != null)
            {
                PostOrder(treestack, current.Right);
            }

            treestack.push(current.Value);
        }



        public List<int> Breadth()
        {
            List<int> result = new List<int>();
            myQueue<Node> treeQueue = new myQueue<Node>();
            Node current = Root;
            treeQueue.enQueue(current);
            Breadth(treeQueue, result,  current);

            return result;
        }

        public void Breadth(myQueue<Node> treeQueue, List<int> result,  Node current)
        {
            while (treeQueue.Front != null)
            {
                Node front = treeQueue.deQueue();
                result.Add(front.Value);

                if (front.Left != null)
                {
                    treeQueue.enQueue(front.Left);
                }

                if (front.Right != null)
                {
                    treeQueue.enQueue(front.Right);
                }

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

