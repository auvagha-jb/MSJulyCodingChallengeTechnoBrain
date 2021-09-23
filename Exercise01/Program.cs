using System;


namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new Validator();

            Console.WriteLine("The default regular expression checks for at least one digit.");
            Console.WriteLine("Enter a regular expression (or press ENTER to choose the default):");

            //Accept the Regex input
            validator.RegExp = "";

            Console.WriteLine(validator.RegExp);

            //Accept other input
            validator.Input = "hello";

            validator.Match = validator.inputMatchesRegex();

            validator.feedbackMessage();
        }
    }
}
