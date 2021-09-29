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
            ListNode head1;
            ListNode head2;
            int carry = 0;
            int sum;

            ListNode res = null;
            ListNode prev = null;
            ListNode temp = null;

            // while both lists exist
            while (l1 != null || l2 != null)
            {
               
               
                sum = carry + (l1 != null ? l1.val : 0)
                      + (l2 != null ? l2.val : 0);

                // update carry for next calculation
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10
                sum = sum % 10;

                // Create a new node with sum as data
                temp = new ListNode(sum);

                // if this is the first node then set it as head
                // of the resultant list
                if (res == null)
                {
                    res = temp;
                }

                // If this is not the first
                // node then connect it to the rest.
                else
                {
                    prev.next = temp;
                }

                // Set prev for next insertion
                prev = temp;

                // Move first and second pointers to next nodes
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new ListNode(carry);
            }

            // return head of the resultant list
            return res;
        }
       
    }
}
    

