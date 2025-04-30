using System;
using System.Linq;

namespace Lab_11_OOP
{
    public class DecimalString : String
    {
        private const string AllowedCharacters = "0123456789+-";
        public bool IsValid { get; private set; }

        public DecimalString(string value) : base("")
        {
            IsValid = false;
            if (string.IsNullOrEmpty(value))
            {
                base._characters = new char[0];
                IsValid = true; 
                return;
            }

            if ((value.StartsWith("-") || value.StartsWith("+")) && value.Length > 1)
            {
                string numberPart = value.Substring(1);
                if (numberPart.All(char.IsDigit))
                {
                    base._characters = value.ToCharArray();
                    IsValid = true;
                }
                else
                {
                    base._characters = new char[0];
                }
            }
            else if (value.All(char.IsDigit))
            {
                base._characters = value.ToCharArray();
                base._lengthInBytes = (byte)value.Length;
                IsValid = true;
            }
            else
            {
                base._characters = new char[0];
                base._lengthInBytes = 0;
            }
        }

        public DecimalString(int number) : this(number.ToString()) { }

        public DecimalString() : this("") { }

        public override string ToString()
        {
            return new string(base._characters);
        }

        public DecimalString Difference(DecimalString otherString)
        {
            if (!this.IsValid || !otherString.IsValid)
            {
                return new DecimalString(""); 
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherString.ToString(), out decimal secondNumber))
            {
                decimal result = firstNumber - secondNumber;
                return new DecimalString(result.ToString());
            }
            else
            {
                return new DecimalString("");
            }
        }

        public bool IsGreaterThan(DecimalString otherString)
        {
            if (!this.IsValid || !otherString.IsValid)
            {
                return false;
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherString.ToString(), out decimal secondNumber))
            {
                return firstNumber > secondNumber;
            }
            return false;
        }

        public bool IsLessThan(DecimalString otherString)
        {
            if (!this.IsValid || !otherString.IsValid)
            {
                return false;
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherString.ToString(), out decimal secondNumber))
            {
                return firstNumber < secondNumber;
            }
            return false;
        }
    }
}