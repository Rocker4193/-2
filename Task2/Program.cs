using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(1, "Kiev");
            cities.Add(2, "Moscow");
            cities.Add(3, "New-York");
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities.Count);
        }
    }
}
