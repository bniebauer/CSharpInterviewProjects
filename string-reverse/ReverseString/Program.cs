using System;
class Program
{
    static void Main()
    {
        string input = "ReverseMe";
        Console.WriteLine($"The input to be reversed: {input}");
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        Console.WriteLine($"Reversed: {result}");
    }
}