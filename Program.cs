using System;
using System.Collections.Generic;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lookingValue = 11;
            var testArray = new List<int>
            {
                4,
                5,
                7,
                11,
                12,
                15,
                15,
                21,
                40,
                45
            };

            var index = Search.BinarySearch(testArray, lookingValue);

            Console.WriteLine($"Index of valus {lookingValue} is {index}");
        }
    }
}
