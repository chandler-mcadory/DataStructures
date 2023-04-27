using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private LinkedListNode? First { get; set; }


        public void Add(int x)
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

        public override string ToString() 
        {
            return First.Data.ToString();
        }


        private class LinkedListNode
        {
            public int Data { get; set;}
            public LinkedListNode? Next { get; set;}
        }
    }
}
