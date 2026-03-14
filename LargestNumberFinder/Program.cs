using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 5, 40, 15 };
        Console.WriteLine("[{0}]", string.Join(", ", arr) );
        int max = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The largest number in the array is: {max}!");
    }
}