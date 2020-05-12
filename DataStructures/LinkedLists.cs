using Google.Protobuf.WellKnownTypes;
using System;

namespace DataStructures
{
    // TODO: Create Insert method to add node to LinkedList and adds new value to LinkedList.head DONE
    // TODO: Create Includes method thats to see if a given value is in the LinkedList and returns a boolean Done
    // TODO: Define method ToString which returns a string representing all the items in the list, see assignment for exmaple. DONE
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

        public override string ToString()
        {
            string output = "";
            Node Current = Head;
            bool toggle = true;
            if (Head != null)
            { 
               
                while(toggle)
                {
                    if (Current.Next == null)
                    {
                        toggle = false;
                    }
                    output += $"{{{Current.Value}}} => ";
                    Current = Current.Next;
                }
                   
               
            }
            return output + "NULL";
        }

        public void Insert(int newValue)
        {

            Node newNode = new Node(newValue);
            if(Head != null)
            { 
                newNode.Next = Head;
            }
            Head = newNode;
          
        }

        public bool Includes(int testValue)
        {
            bool result = false;
            bool continueOrBreak = true;
            while(continueOrBreak)
            {
                Node Current = Head;
                if (Current.Value == testValue)
                {
                    result = true;
                    continueOrBreak = false;
                }
                if (Current.Next != null)
                {
                    Current = Current.Next;
                } else
                {
                    continueOrBreak = false;
                }

                 
            }
            return result;
        }
        public void AppendToEnd(int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void InsertBefore(int value, int newValue)
        {

        }
    }
}
