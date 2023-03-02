using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaListAndArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of list : ");
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine("Numbers count is " + numbersList.Count);

            Console.Write("Enter numbers of 1st array : ");
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToList(numbersList, numbersArray);

            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());
            IsNumInList(numbersList, num);

            Console.Write("Enter numbers of 2nd array : ");
            int[] numbersArray2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayToList2(numbersList, numbersArray2);
        }

        private static void AddArrayToList2(List<int> numbersList, int[] numbersArray2)
        {
            numbersList.InsertRange(3, numbersArray2);
            numbersList.Sort();
            Console.WriteLine(string.Join("*", numbersList));
        }

        private static void IsNumInList(List<int> numbersList, int num)
        {
            if (numbersList.Contains(num))
            {
                Console.WriteLine($"The number {num} is on index {numbersList.IndexOf(num)}");
            }
            else
            {
                Console.WriteLine($"{num} is not in list");
            }
        }

        private static void AddArrayToList(List<int> numbersList, int[] numbersArray)
        {
            numbersList.AddRange(numbersArray);
            numbersList.Sort();
            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}
