using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.AnimalShelter
{
    public class AnimalShelter<T>
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

        public void ArriveAtShelter<TAnimal>(T value)
            where   TAnimal : Animal
        {
            Node newNode = new Node(value);

            if (Front == null && Rear == null)
            {
                Rear = newNode;
                Front = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }


        }
    }
}
