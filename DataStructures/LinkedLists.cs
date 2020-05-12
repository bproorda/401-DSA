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
            Node Current = Head;
            while (Current != null)
            {
                
                if (Current.Value == testValue)
                {
                    result = true;
                }

                    Current = Current.Next;
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
            Node newNode = new Node(newValue);
            Node current = Head;
            Node previousNode = null;
             newNode.Next = current;
          
            while(current != null)
            {
                if(current.Value == value)
                {
                    previousNode.Next = newNode;
                    newNode.Next = current;
                    break;
                } else
                {
                    previousNode = current;
                    current = current.Next;
                }
                
            }
        }

        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;
            while (current != null)
            {
                if(current.Value == value)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                } else
                {
                    current = current.Next;
                }
            }
        }
    }
}
