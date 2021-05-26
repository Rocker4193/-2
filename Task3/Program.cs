using System;

namespace Task3
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            intList.Add(6);
            intList.Add(1);
            intList.Add(7);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
            var array = intList.GetArray();

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];
            for (int i = 0; i < result.Length; i++)
                result[i] = list[i];
            return result;
        }
    }
}
