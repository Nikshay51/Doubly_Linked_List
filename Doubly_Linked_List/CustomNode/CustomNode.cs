using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleLinkedList
{
    internal class CustomNode
    {
        //double forwards and backs
        public CustomNode Next;
        public CustomNode Prev;
        public string data;

        public CustomNode()
        {
            //good practice
        }

        public CustomNode(string data)
        {
            this.data = data;
        }

        


    }
}
