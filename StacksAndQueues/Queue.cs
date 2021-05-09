using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Queue
    {
        //creating the node head
        public Node head;

        // adding the values in queue
        public void Enqueue(int data)
        {
            //creating and initializing node with data
            Node node = new Node(data);
            Node temp = head;
            //if head is null,first value of node is addressed to head
            //head contains the address of first element
            if (head == null)
            {
                head = node;
            }
            else
            {
                //last element is taken out in queue and node address is passed in last node.
                Node lastNode = GetLastNode(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in queue:\t{0}", node.data);

        }
        //Adding Method
        /// Getting the last element of queue
        public Node GetLastNode(Node temp)
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
       //Adding Display Method
        /// Displays the queue
        public void DisplayQueue()
        {
            Console.WriteLine("\nDisplaying the Queue");
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("empty queue");
            }
            else
            {
                //loop is running, until the last element of queue becomes null
                //prints the queue
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}