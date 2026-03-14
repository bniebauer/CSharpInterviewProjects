using System;
class Program
{
    static void Main()
    {
        int n = 20, a = 0, b = 1, c;

        Console.Write(a + " ");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}