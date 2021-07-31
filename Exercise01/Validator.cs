using System;

namespace Exercise01
{
    class Validator
    {
        /**
        Chacks whether the user has entered a value of postive length
        */
        public bool hasInput(string input)
        {
            return input.Trim().Length > 0;
        }
    }
}
