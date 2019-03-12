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
            /*
            Console.WriteLine(l.value);
            Console.WriteLine(l.next.value);
            Console.WriteLine(l.next.next.value);
            Console.WriteLine(l.next.next.next.value);
            Console.WriteLine(l.next.next.next.next.value);
            Console.WriteLine(l.next.next.next.next.next.value);
            */
            //printLinkedList(l); 
            var k = 5;
            removeKFromList(l, k);

        }

        // create an Linked list from an integer list
        static ListNode<int> CreateLinkedList(List<int> input)
        {
            // instantiate the generic class ListNode<T> to create a head
            ListNode<int> head = new ListNode<int>();

            var currNode = head;
            for (var i = 0; i < input.Count; i++)
            {
                currNode.value = input[i];
                if (i < input.Count - 1)
                {
                    // create next node 
                    currNode.next = new ListNode<int>();
                    currNode = currNode.next;
                }
            }

            return head;

        }

        static void printLinkedList(ListNode<int> l)
        {
            Console.WriteLine("In Print linked list method");
            ListNode<int> head = l;
            if(l == null)
            {
                Console.WriteLine("List node is null");
            }

            var currNode = l;
            Console.WriteLine(currNode.value);
            while(currNode.next != null)
            {
                currNode = currNode.next;
                Console.WriteLine(currNode.value);
            }


        }
        static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            Console.WriteLine("In removeKFromList method");
            Console.WriteLine(l.value);

            ListNode<int> traveller = l;

            if (l == null)
            {
                return l;
            }
            var currNode = l;
            
            while(currNode != null)
            {
                currNode = currNode.next;
                Console.WriteLine("currNode: " + currNode.value);
                if(currNode.value == k)
                {
                    var previousNode = currNode.next;
                }
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
