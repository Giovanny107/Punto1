using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to type the first text.
            Console.Write("Type a text, and then press Enter: ");
            var input1 = Console.ReadLine();

            // Ask the user to type the second text.
            Console.Write("Type a text, and then press Enter: ");
            var input2 = Console.ReadLine();

            MergedString mergedString = new MergedString();
            var result = mergedString.MergedText(input1, input2);

            Console.Write("Result Merged String: " + result);
            Console.ReadLine();
        }
    }
}
