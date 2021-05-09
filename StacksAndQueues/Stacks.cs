using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace StacksAndQueues
{
    /// <summary>
    /// Adding Stack Method
    /// </summary>
    class Stacks
    {
        //Defining a node which is assigned null value in constructor
        //head points to firstnode
        public Node top;
        //Initialized node top as all
        public Stacks()
        {
            top = null;
        }

            // Pushing element in statck
            //object of node is created and initialized with data

            public void Push(int data)
            { 
            Node node = new Node(data);
            //Address of new data filled with top and node will become new top
            node.next = top;
            //node become new top
            //Address of old value added
            top = node;
            Console.WriteLine("Element Inserted In Stack:\t{0}", top.data);
        }  

        //Displaying statck
        public void Display()
        {
            Console.WriteLine("\nDisplaying the Stack");
            //Loop runs until null value is obtained in data.
            while (top != null)
            {
                Console.WriteLine(top.data);
                top = top.next;
            }
        }
    }
}
