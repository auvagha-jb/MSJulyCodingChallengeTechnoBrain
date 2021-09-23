using System;

namespace Exercise02
{
    class Hello
    {
        public string NumberInput { set; get; }
        public string[] NumberInputArray { set; get; }




        public string numberToString()
        {
            string numberAsString = "";

            

            return numberAsString;
        }

        private string[] GenerateNumberArray()
        {
            return this.NumberInput.Split(',');
        }

    }
}
