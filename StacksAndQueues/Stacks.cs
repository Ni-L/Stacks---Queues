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
            this.top = null;
        }

            // Pushing element in statck
            //object of node is created and initialized with data

            public void Push(int data)
            { 
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                //Address of new data filled with top and node will become new top
                node.next = this.top;
            }
            //node become new top
            //Address of old value added
            this.top = node;
            Console.WriteLine("Element Inserted In Stack:\t{0}", top.data);
        }  

        //Displaying stack
        public void Display()
        {
            //create 1 temp variable
            Node temp = this.top;
            Console.WriteLine("\nDisplaying the Stack");
            //value of temp is Equals to null then stacks in empty
            if(temp==null)
            {
                Console.WriteLine("Statck is empty");
            }
            //Loop runs until null value is obtained in data.
            while (this.top != null)
            {
                Console.WriteLine(this.top.data);
                top = top.next;
            }
        }
        //Created Peek method
        //This method returns the object at the beginning of the Queue without removing it
        //For dispalying top value in statck
        public int Peek()
        {
            //IF top value is null the Stack is empty
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Displaying top value in stacks");
            Console.WriteLine(this.top.data);
            return this.top.data;
        }
        //Creating Method for Poping element
        //Removes and returns the object at the top of the Stack.
        //For removing of top values 
        public void Pop()
        {
            //IF top value is null the Stack is empty
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Removing the top value from stack");
            //Pointer goes top to next node
            this.top = this.top.next;
            //Calling Display method for display elements
            Display();
        }
        //For Removing All Elements
        public void IsEmpty()
        {
            Console.WriteLine("Removing all the values from stack");
            //Top is not Equal to Null
            while (this.top != null)
            {
                //Calling Peek Method
                Peek();
                //Calling Pop Method
                Pop();
            }

        }
        
        
    }
}
