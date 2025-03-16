using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace linked_lists
{
    internal class MyList
    {
        private Node Head { get; set; }

        public MyList()
        {
            Head = null;
        }

        public void AddHead(string el)
        {
            Node n = new Node(el);
            n.Next = Head;
            Head = n;
        }

        public void AddTail(string el)
        {
            Node n = new Node(el);

            if (Head == null)
            {
                Head = n;
                return;
            }
            Node i = Head;
            while (i.Next != null)
            {
                i = i.Next;
            }
            i.Next = n;
        }

        public void RemoveHead()
        {
            Head = Head.Next;
        }

        public void RemoveTail()
        {

            if (Head.Next == null)
            {
                Head = null;
                return;
            }

            Node curr = Head;
            while (curr.Next.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = null;
        }

        public override string ToString()
        {
            string s = "[";
            Node i = Head;

            while (i != null) 
            {
                s = s + " " + i.ToString() + " ";
                i = i.Next; 
            }

            s += "]";

            return s;
        }
    }
}
