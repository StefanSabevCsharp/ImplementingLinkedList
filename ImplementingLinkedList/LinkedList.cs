using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class LinkedList
    {
        const int capacity = 10;
        public int[] Numbers { get; set; }
        public int Count { get; set; }
        //node
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void AddLast(int value)
        {
            Node node = new Node { Value = value };
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
      
   
       public int this[int index]
        {
            get
            {
                return Numbers[index];
            }
            set
            {
                Numbers[index] = value;
            }
        }   
        public LinkedList() 
        {
            Numbers = new int[capacity];

        }
        public void Add(int value)
        {
            Numbers[Count] = value;
            
            Count++;
        }
       
        public int Next(int index)
        {
            IsValidIndex(index);
            return Numbers[index + 1];
        }
     
        public int Previous(int index)
        {
            IsValidIndex(index);
            return Numbers[index - 1];
        }
 
        public bool IsValidIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                return false;
            }
            return true;
        }
        public void Clear()
        {
            Numbers = new int[capacity];
        }
        private void Resize()
        {
            int[] temp = new int[capacity * 2];
            for (int i = 0; i < Numbers.Length; i++) 
            {
                temp[i] = Numbers[i];
            }
            Numbers = temp;
        }

    }
}
