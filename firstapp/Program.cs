using System;
using System.Collections.Generic;

namespace firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
                var FibNumbers = new List<int> { 1, 1 };

                while (FibNumbers.Count<20)
                {
                    var first = FibNumbers[FibNumbers.Count - 2];
                    //Console.WriteLine($"First is {first}");

                    var second = FibNumbers[FibNumbers.Count - 1];
                    //Console.WriteLine($"Second is {second}");

                    FibNumbers.Add(first + second);

                }

                foreach (var item in FibNumbers)
                    Console.WriteLine(item);
        }
    }
}
