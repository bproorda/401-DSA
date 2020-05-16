using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackAndQueue
{
    public class Stack<T>
    {
        private Node Top { get; set; } = null;

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node(T value)
            {
                this.Value = value;
                this.Next = null;
            }
        }
    }
}
