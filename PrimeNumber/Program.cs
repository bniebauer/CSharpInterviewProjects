using System;
class Program
{
    static void Main()
    {
        int num = 7;
        bool isPrime = true;

        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine($"{num} is " + (isPrime ? "Prime" : "not Prime"));
    }
}