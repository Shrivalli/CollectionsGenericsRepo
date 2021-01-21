using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEg
{
    class HashtableEg
    {
        public static void Main()
        {
            SortedList ht = new SortedList();
            ht.Add("101", "CTS");
            ht.Add("102", "TCS");
            ht.Add("103", "LTI");
            ht.Add("104", "Infy");
            Console.WriteLine("Printing Keys");
            foreach(object item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Printing Values");
            foreach (object item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Printing both key and value");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+ "  "+de.Value);
                
            }
            Console.WriteLine("Enter the key to Search");
            string search = Console.ReadLine();
            if(ht.ContainsKey(search))
            {
                Console.WriteLine(ht[search]);
            }
            else
            {
                Console.WriteLine("Sorry the key is not present");
            }
            Console.Read();
        }
    }
}
