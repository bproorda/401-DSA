using Google.Protobuf.WellKnownTypes;
using System;

namespace DataStructures
{
    // TODO: Create Insert method to add node to LinkedList and adds new value to LinkedList.head
    // TODO: Create Includes method thats to see if a given value is in the LinkedList and returns a boolean
    // TODO: Define method ToString which returns a string representing all the items in the list, see assignment for exmaple.
    public class LinkedLists
    {
        public Node Head = null;

        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node(int value)
            {
                this.Value = value;
                this.Next = null;
        }
        }
    }
}
