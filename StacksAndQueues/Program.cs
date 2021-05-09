using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+++++++=Welcome To Stack and Queues========s");
            Console.WriteLine("Stack Program");
            //Creating object for statcks
            Stacks stacks = new Stacks();
            //Pushing the Values
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Push(16);
            //For display Element
            stacks.Display();
            //for peeking out the top value
            stacks.Peek();
            //For poping out the top values
            stacks.Pop();
            Console.ReadLine();
        }
    }
}
