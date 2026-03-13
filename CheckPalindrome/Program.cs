using System;
class Program
{
    static void Main()
    {
        string input = "tacocat";
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        if (input == result)
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}