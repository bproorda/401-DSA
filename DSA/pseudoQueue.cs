using DataStructures;
using DataStructures.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class pseudoQueue<T>
    {
        public MyStack<T> addStack = new MyStack<T>();
        public MyStack<T> subtractStack = new MyStack<T>();

        public void enqueue(T value)
        {
            addStack.push(value);

        }

        public T dequeue()
        {
            if(addStack.Top == null && subtractStack == null)
            {
                throw new QueueEmptyException();
            }

            while (addStack.Top != null)
            {
                subtractStack.push(addStack.pop());
            }
            T result = subtractStack.pop();

            while (subtractStack.Top != null)
            {
                addStack.push(subtractStack.pop());
            }
            return result;
        }

        public T peekRear()
        {
           return addStack.peek();
        }

        public T peekFront()
        {
            if (addStack.Top == null && subtractStack == null)
            {
                throw new QueueEmptyException();
            }

            while (addStack.Top != null)
            {
                subtractStack.push(addStack.pop());
            }
            T result = subtractStack.peek();

            while (subtractStack.Top != null)
            {
                addStack.push(subtractStack.pop());
            }
            return result;
        }
    }
}
