using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinkedList
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            string[] str = { "quick", "fox", "the", "lazy" };
            LinkedList<string> list = new LinkedList<string>(str);
           
            LinkedListNode<string> temp = list.Find("quick");
            LinkedListNode<string> temp1 = list.Find("fox");

            list.AddFirst("the");
            list.AddAfter(temp, "brown");
            var newNode = list.AddAfter(temp1, "jumps");
            list.AddAfter(newNode, "over");
            list.AddLast("fox");


            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
