using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class MyStack<T>
    {
        private Node Top { get; set; } = null;

        private class Node
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
