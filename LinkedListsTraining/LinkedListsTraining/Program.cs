using LinkedListsTraining.ReverseLinkedList;
using System;

namespace LinkedListsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var linkedList = new MyLinkedList();
            //var reverseList = new Solution();
           // var revList = new MyLinkedList();


            /*for (int i = 0; i < 20; i++)
            {
                linkedList.AddAtTail(i);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(linkedList.Get(i));
            }*/
            //Console.WriteLine(linkedList.Get(0));
            //linkedList.AddAtIndex(0, 11);
            linkedList.AddAtHead(3);
            linkedList.AddAtTail(4);
            linkedList.AddAtHead(2);
            linkedList.AddAtTail(5);
            linkedList.AddAtIndex(0, 1);
            linkedList.displayList();

            //reverseList.ReverseList(linkedList.Head);
            

                        

            linkedList.AddAtIndex(1, 10);
            linkedList.displayList();

            linkedList.DeleteAtIndex(3);
            linkedList.displayList();

            linkedList.DeleteAtIndex(0);
            linkedList.displayList();


            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(5));


        }
    }
}
