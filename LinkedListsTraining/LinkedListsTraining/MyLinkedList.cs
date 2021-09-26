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
        public int Get(int index)
        {
            if (index >= size || index < 0)
                return -1;
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }
                return current.val;
            }
        }

        /** Add a node of val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode();
            newNode.val = val;
            newNode.next = Head;
            Head = newNode;

            size++;
        }

        /** Append a node of val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
            }
            else
            {
                ListNode newNode = new ListNode();
                newNode.val = val;

                ListNode current = Head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
                size++;
            }

        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > size || index < 0)
            {
                Console.WriteLine($"Index({index}) is out of range for this list.");
            }
            else if (index == 0)
            {
                AddAtHead(val);
            }
            else 
            {
                ListNode current = Head;

                ListNode newNode = new ListNode();
                newNode.val = val;

                for (int i = 0; i < index-1; i++)
                {
                    current = current.next;
                }

                ListNode temp = current.next;
                
                current.next = newNode;
                newNode.next = temp;
                size++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= size || index < 0)
            {
                Console.WriteLine($"Index({index}) is out of range for this list.");
            }
            else if (index == 0)
            {
                Head = Head.next;
                size--;
            }
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index-1; i++)
                {
                    current = current.next;
                }

                current.next = current.next.next;
                size--;
            }
        }
        public void displayList()
        {
            Console.WriteLine("---Current list--- ");
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

