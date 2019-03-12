using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeKFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 3, 1, 2, 3, 4, 5 };
            var l = CreateLinkedList(input);
            Console.WriteLine(l.value);
            Console.WriteLine(l.next.value);
            Console.WriteLine(l.next.next.value);

        }

        static ListNode<int> CreateLinkedList(List<int> input)
        {
            ListNode<int> head = new ListNode<int>();

            var currNode = head;
            for (var i = 0; i < input.Count; i++)
            {
                currNode.value = input[i];
                if (i < input.Count - 1)
                {
                    currNode.next = new ListNode<int>();
                    currNode = currNode.next;
                }
            }

            return head;

        }

        static void printLinkedList(ListNode<int> l)
        {

        }
        static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {

            ListNode<int> traveller = l;

            if (l == null)
            {
                return l;
            }


            return l;
        }



        //Definition for singly-linked list:
        class ListNode<T>
        {
            public T value { get; set; }
            
            public ListNode<T> next { get; set; }
        }

        

    }
}
