using System;

namespace ConsoleApp1
{

    class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    class LinkkedList{
      
        LinkedListNode head =null;
       
        public void AddInfront(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
          
        }

        public void printList()
        {
            LinkedListNode runner = head;
         

            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }

        }

    }



    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            
            
            LinkkedList obj = new LinkkedList();
          
            obj.AddInfront(56);
            obj.AddInfront(30);
            obj.AddInfront(70);

            obj.printList();

        }
    }
}
