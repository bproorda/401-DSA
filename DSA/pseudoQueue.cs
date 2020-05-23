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
            return default;
        }

        public T peek()
        {
           return addStack.peek();
        }
    }
}
