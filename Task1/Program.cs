using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            intList.Add(6);
            intList.Add(1);
            intList.Add(7);
            Console.WriteLine(intList[0]);
            Console.WriteLine(intList.Count);
        }
    }
}
