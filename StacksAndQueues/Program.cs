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
            Stacks stacks = new Stacks();
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Display();
            Console.ReadLine();
        }
    }
}
