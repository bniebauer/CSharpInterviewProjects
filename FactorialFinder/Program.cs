using System;
using System.CommandLine;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var numOption = new Option<int>("--num", "Number");

        var rootCommand = new RootCommand { numOption };

        rootCommand.SetAction((num) =>
        {
            Console.WriteLine(num);
        });
        int num = 5;
        int fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine(fact);
    }
}