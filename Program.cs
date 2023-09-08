using System;
using System.Security.Cryptography.X509Certificates;

namespace GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximun Integer Value is : " + MaximumInt.MaxInteger(40, 50, 70));
            Console.WriteLine("Maximun Integer Value is : " + GenericsMax.MaxValue(40, 50, 70));

            Console.WriteLine("Maximun Float Value is : " + MaximumFloat.MaxFloat(40.55f, 50.4567f, 70.55f));
            Console.WriteLine("Maximun Float Value is : " + GenericsMax.MaxValue(40.55f, 50.4567f, 70.55f));

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            PrintArray.printArray(arr1);

            string[] arr2 = {"abcde", "efghi"};
            PrintArray.printArray(arr2);
        }
    }
}
