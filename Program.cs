using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

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

            var reader = new FileConsoleReader();
            try
            {
                Console.WriteLine(reader.ReadFileTxt("testFile"));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //czas lokalny i globalby

            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Now);

            //konwertowanie c# do json
            string jsonString = JsonSerializer.Serialize(testArray);

            //json do c#
            var value  = JsonSerializer.Deserialize<List<int>>(jsonString);

        }
    }
}
