using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg
{
    class GenericEg
    {
        public static void Main()
        {
            List<string> l1 = new List<string>();
            l1.Add("Welcome");
            l1.Add("Bye");
            l1.Add("Training");
            l1.Sort();
            Console.WriteLine("Looping through L1");
            foreach(string item in l1)
            {
                Console.WriteLine(item);
            }
            List<int> l2 = new List<int>();
            l2.Add(10);
            l2.Add(50); 
            l2.Add(25);
            l2.Sort();
            Console.WriteLine("Looping through L1");
            foreach (int item in l2)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
