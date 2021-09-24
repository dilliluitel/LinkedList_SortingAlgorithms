using System;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        public int size;      // to keep track of index

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
            size = 0;
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public ListNode GetNode(int index)
        {
            //throw new NotImplementedException();
            /*if (index >= size || index < 0)
                return -1;
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                return current.val;
            }*/
            if (index >= size)
            {
                Console.WriteLine("Invalid index"); ;
            }
            ListNode result = new ListNode();
            result = Head;
            while (index > 0)
            {
                result = result.next;
                --index;

            }
            return result;
        }

        /** Add a node of val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            //throw new NotImplementedException();
            ListNode newNode = new ListNode();
            newNode.val = val;
            newNode.next = Head;
            Head = newNode;

            size++;
        }

        /** Append a node of val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            //throw new NotImplementedException();
            ListNode current = Head;
            while (current.next != null)
            {
                current = current.next;
            }

            ListNode newNode = new ListNode();
            newNode.val = val;
            current.next = newNode;

            size++;

        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            //throw new NotImplementedException();
            /*if (index >= size || index < 0)
            {
                Console.WriteLine("Provided index is out of range for this list.");
            }                
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                ListNode newNode = new ListNode();
                newNode.val = val;
                current.next = newNode;

                size++;*/
            Console.WriteLine("Now adding at index " + index + " with a value: " + val);

            if (index == 0)
            {
                ListNode newNode = new ListNode();
                newNode.val = val;
                Head = newNode;
            }
            else
            {
                ListNode prevNode = GetNode(index - 1);
                ListNode nextNode = prevNode.next;

                ListNode newNode = new ListNode();
                newNode.val = val;
                newNode.next = nextNode;

                prevNode.next = newNode;
            }
            size++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            // throw new NotImplementedException();
            if (index >= size || index < 0)
            {
                Console.WriteLine("Provided index is out of range for this list.");
            }
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }

                current.next = current.next.next;

                size--;
            }
        }

        public void displayList()
        {
            Console.WriteLine("List (first -- last) ");
            ListNode current = Head;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}

