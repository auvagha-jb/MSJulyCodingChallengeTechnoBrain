using System;
using System.Text.RegularExpressions;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new Validator();
            string defaultRegex = "^[a-z]+$";

            Console.WriteLine("The default regular expression checks for at least one digit.");
            Console.WriteLine("Enter a regular expression (or press ENTER to choose the default):");
            string regex = Console.ReadLine();

            Console.WriteLine(validator.hasInput(regex));

            if (!validator.hasInput(regex))
            {
                regex = defaultRegex;
            }

            string input = Console.ReadLine();

            var match = Regex.Match(input, default).Success;

            if (match)
            {
                Console.WriteLine($"The input {input} matches the regex {regex}");
            }
            else
            {
                Console.WriteLine($"The input {input} does not match the regex {regex}");
            }
        }
    }
}
