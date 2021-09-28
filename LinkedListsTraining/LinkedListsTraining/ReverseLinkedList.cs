using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            else
            {
                MyLinkedList reverseList = new MyLinkedList();
                ListNode current = head;

                reverseList.AddAtHead(current.val);

                while (current.next != null)
                {
                    current = current.next;
                    reverseList.AddAtHead(current.val);

                }

                return reverseList.Head;
            }
        }

        //Couldn't get it working recursively
        /*public ListNode ReverseList(ListNode head)
        {
           ListNode current = head;
           if (head == null || head.next == null) return head;
            else
            {

               ListNode temp = current;

               current = current.next;
               current.next = temp;

               return ReverseList(current);
            }
        }*/
    }
}
