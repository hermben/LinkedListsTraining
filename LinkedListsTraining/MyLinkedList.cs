using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
        //    // Verify that there is no elements in list and return -1
        //  //  if(Head == null)
        ////   {
        //        return -1;
        //    }

            // Loop list elements until we arrived at node that index = "index" or the end of list
            ListNode currentNode = Head;
            var currentIndex = 0;
            while(currentNode != null && currentIndex <= index)
            {
                // if current element index == "index", return current node val
                if (currentIndex == index)
                {
                    return currentNode.val;
                }

                // Go to next node
                currentNode = currentNode.next;
                currentIndex++;
            }

            // if end of list , return -1
            return -1;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            // initiate new node and assign val
            ListNode newNode = new ListNode(val);

            // make next of new node as head
            newNode.next = Head;
            //move head to point to new head
            Head = newNode;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {

            ListNode newNode = new ListNode(val);
            //newNode.next = null;
            

            //check if list is empty or not 
            //if empty make newNode as head
            // if not else
            if(Head==null)
            {
                Head = newNode;

            }else
            {    
                 // travels to the last node
                ListNode temp = new ListNode();
                temp = Head;
                while (temp.next != null)
                    temp = temp.next;

                temp.next = newNode;
              
            }


        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            ListNode newNode = new ListNode();
            if (index == 0)
            {
                newNode.next = Head;
                Head = newNode;
            }
            else
            {
                ListNode temp = new ListNode();
                temp = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    if (temp != null)
                        temp = temp.next;
                }

                if (temp != null)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index==0 && Head != null)
            {
          
                Head = Head.next;

            }
            else
            {
                ListNode temp = new ListNode();
                temp = Head;

                for(int i = 0; i < index-1; i++)
                {
                    if (temp !=null)
                    {
                        temp = temp.next;
                    }

                   
                }

                if (temp.next != null)
                {
                    temp.next = temp.next.next;

                }
            }

        }
    }
}
