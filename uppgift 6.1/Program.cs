using System;
using System.Diagnostics;

namespace uppgift
{
    class Ptogram
    {
        static void Main(string[] args)
        {

            add(5, 3, 10);
            Console.WriteLine(add(5, 3, 10));
           
        }
        static int add(int tal1, int tal2, int tal3)
        {
            return (tal1 + tal2 + tal3);
        }

    }
}