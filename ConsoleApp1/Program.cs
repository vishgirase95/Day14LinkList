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
     

        public void InsertBetween(int prev, int data)
        {

            LinkedListNode node = new LinkedListNode(data);
            if (prev == null)
            {
                Console.WriteLine("Previous node cannot be null");
                //head = node;
            }
            else
             
            {
                LinkedListNode SearchNode = head;

                while (!SearchNode.data.Equals(prev))
                {
                    SearchNode = SearchNode.next;
                }
                LinkedListNode tempNode = SearchNode.next;
                SearchNode.next = node;
                SearchNode.next.next = tempNode;
                

            }

        }

        public void DeleteFirstElement()
        {
            head = head.next;
        }
        public void DeleteLastNumber()
        {

            LinkedListNode temp = head;
            LinkedListNode prev = null;

            while (temp.next != null)
            {

                prev = temp;
                temp = temp.next;
            }
            prev.next = null;




        }


        public int count = 0;
        public void searchElement(int search)
        {
            LinkedListNode temp = head;

            while (temp!=null)
            {
                if (temp.data == search)
                {

                    Console.WriteLine("Element found");
                    count++;
                    break;

                }
              
            
                   temp= temp.next;


            }




            if (count ==0)
            {
                Console.WriteLine("Elemet Not found");
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




            
            obj.searchElement(33);

            obj.printList();





        }


    }
}
