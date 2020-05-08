using Google.Protobuf.WellKnownTypes;
using System;

namespace DataStructures
{
    // TODO: Create Insert method to add node to LinkedList and adds new value to LinkedList.head DONE
    // TODO: Create Includes method thats to see if a given value is in the LinkedList and returns a boolean
    // TODO: Define method ToString which returns a string representing all the items in the list, see assignment for exmaple.
    public class LinkedLists
    {
        public Node Head = null;
        public Node Current = null;

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

        public override string ToString()
        {
            /*string output = "";
            if (this.Head == null)
            {
                 output = $"{this.Head.Value}";
            }

            return output; */

            if (Head == null)
            {
                return "";
            } else
            {
                return Head.Value.ToString();
            }

        }

        public void Insert(int newValue)
        {
            Node newNode = new Node(newValue);
            if(Head != null)
            { newNode.Next = Head; }
            Head = newNode;
        }
    }
}
