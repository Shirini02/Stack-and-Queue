using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class Stack<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Stack()
        {

        }
        public int count
        {
            get
            {
                return contents.Count;
            }
        }
        //push method (pushes the item on the stack)
        public void Push(T item)
        {
            contents.Add(item);
        }
        //pop method(removes the item from the stack)
        public T pop()
        {
            if(contents.Count==0)
            {
                throw new InvalidOperationException("Cant pop from a stack");

            }
            else
            {
                //retrieve top of stack,remove and return
                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }
        //peek method(peeks at the top item on the stack)
        public T Peek()
        {
            if(contents.Count==0)
            { throw new InvalidOperationException("Cant peek froma stack");
            }
            else
            {
                return contents[contents.Count - 1];
            }
        }
    }
}
