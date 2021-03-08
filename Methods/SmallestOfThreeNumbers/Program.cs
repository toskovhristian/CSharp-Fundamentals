using System;
namespace SmallestOfThreeNumbers
{
    class Program
    {
         static void Main()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = GetSmallestNumber(numbers);
            Console.WriteLine(result);
        }

        static int GetSmallestNumber(int[] numbers)
        {
            int result = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                result = SmallerNumber(numbers[i], result);
            }

            return result;
        }

        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }
    }
}
