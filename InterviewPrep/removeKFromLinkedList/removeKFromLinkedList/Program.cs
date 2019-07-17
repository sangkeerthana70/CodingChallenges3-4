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
            int k = 3;
            Node head = CreateLinkedList(input);
            Console.WriteLine("head " + head.value);
            

        }

        static Node CreateLinkedList(List<int> integerList)
        {
            Node head = new Node();

            var currNode = head;

            for(int i = 0; i < integerList.Count; i++)
            {
                currNode.value = integerList[i];
                Console.WriteLine("currNode.value " + currNode.value);

                if(i < integerList.Count - 1)
                {
                    currNode.Next = new Node();
                    currNode = currNode.Next;
                }
            }
            return head;
        }
    }
}
