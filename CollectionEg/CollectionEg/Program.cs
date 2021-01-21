using System;

namespace CollectionEg
{
    namespace third
    {
        class S
        {
            public int r1;
            public int r2;

        }
    }
}
namespace sample
{ 
    class Program
    {
        static void Main(string[] args)
        {
            CollectionEg.third.S obj1 = new CollectionEg.third.S();
            obj1.r1 = 10;
            obj1.r2 = 20;
            Console.WriteLine("The values of r1 and r2 of obj1 :" + obj1.r1 + " " + obj1.r2);
            S obj2 = new S();
            obj2 = obj1;
            Console.WriteLine("The values of r1 and r2 of obj2 :" + obj2.r1 + " " + obj2.r2);
            obj1.r1 = 40;
            obj1.r2 = 50;
            Console.WriteLine("The values of r1 and r2 of obj1 :" + obj1.r1 + " " + obj1.r2);
            Console.WriteLine("The values of r1 and r2 of obj2 :" + obj2.r1 + " " + obj2.r2);
            Console.Read();
        }
    }
}
}