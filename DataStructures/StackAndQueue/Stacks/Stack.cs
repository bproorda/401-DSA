using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class MyStack<T>
    {

        public Node Top { get; set; } = null;

        public class Node
        {
           public  T Value { get; set; }
             public Node Next { get; set; }
            public Node(T value)
            {
                this.Value = value;
                this.Next = null;
            }
        }

        public void push(T value)
        {
            Node newNode = new Node(value);
            if (isEmpty())
            {
                Top = newNode;
            } else
            {
                newNode.Next = Top;
                Top = newNode;
            }
           
          
        }

        public T peek()
        {
            bool isItEmpty = isEmpty();
            if (!isItEmpty)
            {
                return Top.Value;
            } else
            {
                throw new StackEmptyException();
            }
           
            
        }

        public T pop()
        {
            bool isItEmpty = isEmpty();
            if (!isItEmpty)
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                T answer = temp.Value;
                return answer;
            }
            else
            {
                throw new StackEmptyException();
            }

        }

        public bool isEmpty()
        {
            if (Top == null)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    public class StackEmptyException : Exception
    {

    }
}
