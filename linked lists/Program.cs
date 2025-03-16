using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            list.AddTail("Aronne");
            list.AddTail("tomas");
            list.AddTail("Domenico");

            Console.WriteLine(list.ToString());

            list.RemoveHead();
            Console.WriteLine(list.ToString());

            list.RemoveTail();
            Console.WriteLine(list.ToString());
        }
    }
}
