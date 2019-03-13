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
            
            var k = 3;
            l = removeKFromList(l, k);
            printLinkedList(l); 

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
            Console.WriteLine("In Print linked list method\n");
            var head = l;
            if(head == null)
            {
                Console.WriteLine("List node is null");
            }

            var currNode = head;
            ListNode<int> previousNode = null;

            while (currNode != null)
            {
                Console.WriteLine("currNode: " + currNode.value);
                if (previousNode != null)
                {
                    //Console.WriteLine("previousNode: " + previousNode.value);
                }
                previousNode = currNode;
                currNode = currNode.next;
                
                if (currNode != null)
                {
                    //Console.WriteLine("nextNode: " + currNode.value);
                }
                Console.WriteLine("");
            }


        }
        static ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            Console.WriteLine("In removeKFromList method");
            //Console.WriteLine(l.value);

            ListNode<int> head = l;

            if (head == null)
            {
                return head;
            }
            var currNode = head;
            ListNode<int> previousNode = null;
            
            while(currNode != null)
            {
                if(currNode.value == k)
                {
                    if (previousNode == null)
                    {
                        l = currNode.next;
                    }
                    else
                    {
                        previousNode.next = currNode.next;
                    }
                }
                previousNode = currNode;
                currNode = currNode.next;
                
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
