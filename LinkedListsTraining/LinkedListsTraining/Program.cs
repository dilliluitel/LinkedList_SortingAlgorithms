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
           
            // 5, 2, 3, 7
            //linkedList.AddAtIndex(1, 5);

            linkedList.displayList();

            linkedList.DeleteAtIndex(1);
            linkedList.displayList();

            /*Console.WriteLine(linkedList.GetNode(0));
            Console.WriteLine(linkedList.GetNode(1));
            Console.WriteLine(linkedList.GetNode(3));
*/

        }
    }
}
