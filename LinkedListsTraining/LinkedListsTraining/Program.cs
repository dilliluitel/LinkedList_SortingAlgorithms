using System;

namespace LinkedListsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running the program does nothing!");

            MyLinkedList linkedList = new MyLinkedList();

            linkedList.AddAtHead(2);
            linkedList.AddAtTail(3);
            linkedList.AddAtHead(5);
            linkedList.AddAtTail(7);
            linkedList.displayList();

            linkedList.AddAtIndex(1, 10);
            linkedList.displayList();

            linkedList.DeleteAtIndex(3);
            linkedList.displayList();

            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(4));


        }
    }
}
