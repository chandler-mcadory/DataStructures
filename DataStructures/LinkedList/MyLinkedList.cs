using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class MyLinkedList<T>
    {
        private LinkedListNode? First { get; set; }


        public void Add(T x)
        {
            if (First == null)
            {
                First = new LinkedListNode() { Data = x };   // First.Data = x 
            }
            else
            {
                LinkedListNode? pointer = First;
                while(pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = new LinkedListNode() { Data = x };
            }
            return;
        }


        private class LinkedListNode
        {
            public T? Data { get; set;}
            public LinkedListNode? Next { get; set;}
        }


        public void Delete(T x)
        {
            LinkedListNode? pointer = First;
            if(pointer?.Data?.Equals(x) == true)
            {
                First = First?.Next;
            }
            while(pointer?.Next?.Data?.Equals(x) == false)
            {
                pointer = pointer.Next;
            }
            if (pointer != null)
            {
                pointer.Next = pointer.Next?.Next;
            }
        }
    }
}
