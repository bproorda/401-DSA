using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class myQueue<T>
    {
        public Node Front { get; set; } = null;
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

        public void enQueue(T value)
        {
            Node newNode = new Node(value);

            if (Front == null && Rear == null)
            {
                Rear = newNode;
                Front = newNode;
            } else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
           

        }

        public T deQueue()
        {
            if (isEmpty())
            {
                throw new QueueEmptyException();
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                if (Rear == temp)
                {
                    Rear = null;
                }
                return temp.Value;
            }
        }

        public T peek()
        {
            if (isEmpty())
            {
                throw new QueueEmptyException();
            } else
            {
                return Front.Value;
            }
        }

        public bool isEmpty()
        {
            if (Front == null)
            {
                return true;

            } else
            {
                return false;
            }
        }
    }

    public class QueueEmptyException : Exception
    {

    }
}
