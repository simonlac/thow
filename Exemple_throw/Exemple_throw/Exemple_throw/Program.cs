// Code tiré de https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/throw
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_throw
{
    public class NumberGenerator
    {
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int GetNumber(int index)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return numbers[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new NumberGenerator();
            int index = 5;
            try
            {
                int value = gen.GetNumber(index);
                Console.WriteLine($"Retrieved {value}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.GetType().Name}: {index} is outside the bounds of the array");
            }
            Console.ReadKey();

        }
    }
}
