using System;
using System.Linq;

namespace dotNetAssig1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Action1
            Console.WriteLine("Action 1: input integer number n and output n!");
            bool ifInt = int.TryParse(Console.ReadLine(), out int result);

            Console.WriteLine($"The input number is:{result}");
            Console.WriteLine($"The n! is:{Factorial(result)}");
            Console.WriteLine("");

            //Action2
            Console.WriteLine("To get sum of first n(input) even numbers");
            bool ifInter = int.TryParse(Console.ReadLine(), out int sum);
            Console.WriteLine($"The sum of first n even number is: {GetSum(sum)}");

            //Action3
            Console.WriteLine("Enter the lenght of the array you want to create:");
            bool ifIntArr = int.TryParse(Console.ReadLine(), out int arrLength);
            string[] arrData = new string[arrLength];

            for(int arrElem = 0; arrElem < arrLength; arrElem++)
            {
                Console.WriteLine("Enter elements of the array you want to create:");
                arrData[arrElem] = Console.ReadLine();
            }
            Console.WriteLine($"Your array: [ {string.Join(", ", arrData)} ] ");

            //Action4
            Console.WriteLine("Enter the element in the array you want to search:");
            var searchElem = Console.ReadLine();
            bool has = arrData.Contains(searchElem);
            if (has)
            {
                Console.WriteLine($"The elem: {searchElem} is in elem is at index {Array.IndexOf(arrData, searchElem)}");
            }
            else
            {
                Console.WriteLine("No such element");
            }
            

            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            int facter = n;
            for (int i = n - 1; i >= 1; i--)
            {
                facter = facter * i;
            }
            return facter;
        }

        public static int GetSum(int n)
        {
            var sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"even numbers: {i}");
                    sum += i;
                }
            }
            return sum;
        }
    }
}
