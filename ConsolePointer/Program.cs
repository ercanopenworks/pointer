using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolePointer
{
    class Program
    {
        public static void Method()
        {
            unsafe
            {
                int x = 10;
                int y = 20;
                int* ptr1 = &x;
                int* ptr2 = &y;
                Console.WriteLine((int)ptr1);
                Console.WriteLine((int)ptr2);
                Console.WriteLine(*ptr1);
                Console.WriteLine(*ptr2);

            }
        }

        static void Main(string[] args)
        {
            Method();
            Console.ReadKey();


        }
    }
}
