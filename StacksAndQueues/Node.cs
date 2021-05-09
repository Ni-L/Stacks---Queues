using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{/// <summary>
/// Class for Nodes
/// </summary>
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)//Adding Method For Node
        {
            //Instace of class
            this.data = data;
        }
    }
}
