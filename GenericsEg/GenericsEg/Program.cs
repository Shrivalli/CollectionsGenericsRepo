using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("LTI");
            //al.Add(87);
            //al.Add(56.67f);
            //al.Add(false);
           // al.Add("welcome");
            Console.WriteLine("The list of items");
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
           // al.Insert(2, "Chocolate");
            ArrayList l1 = new ArrayList();
            l1.Add(10);
            l1.Add(20);
            l1.Add(8);
            l1.Add(35);
            l1.Add(15);
            l1.Sort();
           // al.InsertRange(2, l1);
            //al.Remove("LTI");
            //al.RemoveAt(4);
            Console.WriteLine("New list :");
            //al.Sort();
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count: "+al.Count);
            Console.WriteLine("Capacity: " + al.Capacity);
            Console.Read();

        }
    }
}
