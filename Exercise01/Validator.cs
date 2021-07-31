using System;
using System.Text.RegularExpressions;

namespace Exercise01
{
    class Validator
    {

        public string Input { set; get; }
        public string RegExp { set; get; }
        public bool Match { set; get; }

        public bool hasInput()
        {
            return this.Input.Trim().Length > 0;
        }
        public void validateRegex()
        {
            string defaultRegex = "^[a-z]+$";
            bool regexWasEntered = this.RegExp.Trim().Length > 0;
            
            if (!regexWasEntered)
            {
                this.RegExp = defaultRegex; 
            }
        }

        public bool inputMatchesRegex() 
        {
            return Regex.Match(this.Input, this.RegExp).Success;
        }

        public void feedbackMessage()
        {
            if (this.Match)
            {
                Console.WriteLine($"The input {this.Input} matches the regex {this.RegExp}");
            }
            else
            {
                Console.WriteLine($"The input {this.Input} does not match the regex {this.RegExp}");
            }
        }

    }
}
