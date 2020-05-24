using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.AnimalShelter
{
    public class MyAnimalShelter<T>
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

        public TAnimal TakeHomeWhich<TAnimal>(string input)
            where TAnimal : Animal 
        {
            
            if (input == "dog")
            {
                var pet = TakeHome<dog>();
                TAnimal output = pet as TAnimal;
                return output;
            }
            else if( input == "cat")
            {
                var pet = TakeHome<cat>();
                TAnimal output = pet as TAnimal;
                return output;
            }
            else if (input == "either")
            {
                var pet = TakeHome<Animal>();
                TAnimal output = pet as TAnimal;
                return output;
            }
            else
            {
                throw new AnimalNotFoundException();
            }
           
        }

        public TAnimal TakeHome<TAnimal>()
            where   TAnimal : Animal
        {
            Node previous = Front;
            Node current = Front;
            if (current.Value is TAnimal)
            {
                Front = current.Next;
                current.Next = null;
                return current.Value as TAnimal;
            } else
            {
                current = current.Next;
            }

            while (current != null)
            {
                if (current.Value is TAnimal)
                {
                    previous.Next = current.Next;
                    current.Next = null;
                    return current.Value as TAnimal;
                }
                else
                {
                    previous = previous.Next;
                    current = current.Next;
                }
            }



            throw new AnimalNotFoundException();
        }
    }
    public class AnimalNotFoundException : Exception
    {

    }
}
