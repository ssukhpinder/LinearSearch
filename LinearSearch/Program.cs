using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.WriteLine("Current rray Elements " + string.Join(" , ", arr));
            Console.WriteLine("Enter the element to be searched");
            int value = Convert.ToInt32(Console.ReadLine());
            var index = LinearSearch(arr, value);
            if (index != -1)
                Console.WriteLine($"Element {value} found at index {index}");
            else
                Console.WriteLine("Element not found");
        }

        static int LinearSearch(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
