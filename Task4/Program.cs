using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> IntEx = new MyClass<int>();
            MyClass<char> CharEx = new MyClass<char>();
            MyClass<bool> BoolEx = new MyClass<bool>();
            Console.WriteLine(IntEx.GetType());
            Console.WriteLine(CharEx.GetType());
            Console.WriteLine(BoolEx.GetType());
        }
    }
}
