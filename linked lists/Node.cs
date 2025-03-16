using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_lists
{
    internal class Node
    {
        public Node(string element)
        {
            Element = element;
            Next = null;
        }

        public string Element { get; set; }
        public Node Next { get; set; }

        public override string ToString()
        {
            return "{" + Element + "}";
        }
    }
}
