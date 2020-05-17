using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class myQueue
    {
        public Node Top { get; set; } = null;
        public Node Rear { get; set; } = null;
        public class Node
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
