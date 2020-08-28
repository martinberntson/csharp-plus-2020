using System;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var integerValuesName = nameof(integerValues);

            for (var i = 0; i < integerValues.Length; i++)
            {
                var value = integerValues[i];
                Console.WriteLine($"Index {i} i arrayen {integerValuesName} har värdet: {value}.");
            }

            var doWhileIndex = 0;

            do
            {
                var value = integerValuesName[doWhileIndex];
                Console.WriteLine($"Index {doWhileIndex} i arrayed {integerValuesName} ");
            }
            while (doWhileIndex < integerValues.Length);
            {
                var value = integerValues[doWhileIndex];

                Console.WriteLine($"While Index {doWhileIndex} i arrayen {integerValuesName} har värdet {value}.");
            }
        }
    }
}
