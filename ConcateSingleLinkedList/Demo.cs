using System;
using System.Collections.Generic;
using System.Text;

namespace ConcateSingleLinkedList
{
    class Demo
    {
    static void Main(string[] args)
        {
            ConcateSingleLinkedList list1 = new ConcateSingleLinkedList();
            ConcateSingleLinkedList list2 = new ConcateSingleLinkedList();

            Console.WriteLine(" Enter first list : ");
            list1.CreateList();
            Console.WriteLine(" Enter second list : ");
            list2.CreateList();

            Console.Write(" First ");
            list1.DisplayList();
            Console.Write("Second ");
            list2.DisplayList();

            list1.Concate(list2);
            Console.Write(" First ");
            list1.DisplayList();
        }
    
    
    }
}
