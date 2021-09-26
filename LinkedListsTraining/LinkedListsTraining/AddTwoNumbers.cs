using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var newList = new MyLinkedList();
            int total, carry = 0;

            ListNode current1 = l1;
            ListNode current2 = l2;

            if (l1 == null && l2 == null) 
                return newList.Head;
            else
            {
                while (current1 != null || current2 != null)
                {
                    if (current1 == null)
                    {
                        total = current2.val + carry;
                        current2 = current2.next;
                    }
                    else if (current2 == null)
                    {
                        total = current1.val + carry;
                        current1 = current1.next;
                    }
                    else
                    {
                        total = current1.val + current2.val + carry;

                        current1 = current1.next;
                        current2 = current2.next;
                    }
                    if (total > 9)
                    {
                        total = total - 10;
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                    newList.AddAtTail(total);
                }
                if (carry == 1)
                    newList.AddAtTail(carry);

                return newList.Head;
            }
        }
    }
}
