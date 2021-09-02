using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    public class Queues<T>
    {
        List<T> contents = new List<T>();
        //constructor
        public Queues()
        {

        }
        //gets the number of items in queues
        public int count
        {
            get
            {
                return contents.Count;
            }
        }
        //enqueue method add item to the queue
        public void Enqueue(T item)
        {
            contents.Add(item);
        }
        //dequeuemethod removes front item from queue and returns it
        public T Dequeue()
        {
            if(contents.Count==0)
            {
                throw new InvalidOpeartionException("Cant remove from queue");
            }
            else
            {
                //retrieve front of queue ,remove and return
                T item = contents[0];
                contents.RemoveAt(0);
                return item;
            }
        }
    }
}