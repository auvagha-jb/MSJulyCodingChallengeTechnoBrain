using System;
using System.Text.RegularExpressions;

namespace Exercise01
{
    class Validator
    {
        public string _input;

        public string Input
        {
            get
            {
                return this._input;
            }

            set
            {
                if(!this.valueWasEntered()) {
                    
                }
                this._regExp = regexWasEntered ? value : defaultRegex;
            }
        }

        private string _regExp;
        public string RegExp
        {
            get
            {
                return this._regExp;
            }

            set
            {
                string defaultRegex = "^[a-z]+$";
                this._regExp = this.valueWasEntered(value) ? value : defaultRegex;
            }
        }
        public bool Match { set; get; }

        /**
        * Validates the length of the user's input to ensure the value entered was not blank
        */
        public bool valueWasEntered(string value)
        {
            return value.Trim().Length > 0;
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
