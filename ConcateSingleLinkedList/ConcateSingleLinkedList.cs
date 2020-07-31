using System;
using System.Collections.Generic;

namespace ConcateSingleLinkedList
{
    class ConcateSingleLinkedList
    {
        private Node start;
        public ConcateSingleLinkedList()
        {
            start = null;
        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes");

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }
        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            p = start;
            while (p.link != null)
            {
                p = p.link;

            }
            p.link = temp;
        }

        public void Concate(ConcateSingleLinkedList list)
        {
          if(start == null)
            {
                start = list.start;
                return;
            }
            if (list.start == null)
                return;
            Node p = start;
            while (p.link != null)
                p = p.link;
            p.link = list.start;
        }

        

        

    }
}
