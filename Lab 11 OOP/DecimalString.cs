using System;
using System.Linq;
using System.Text;

namespace Lab_11_OOP
{
    public class DecimalString : IDecimalString
    {
        private char[] _characters;
        private int _lengthInBytes;

        public bool IsValid { get; private set; }
        private const int MaxDecimalStringLength = 50; 
        private const int MinDecimalStringLength = 1;  
        public DecimalString(string value)
        {
            IsValid = false;
            if (string.IsNullOrEmpty(value))
            {
                _characters = new char[0];
                _lengthInBytes = 0;
                IsValid = true;
                return;
            }
            if ((value.StartsWith("-") || value.StartsWith("+")) && value.Length > 1)
            {
                string numberPart = value.Substring(1);
                if (numberPart.All(char.IsDigit))
                {
                    _characters = value.ToCharArray();
                    _lengthInBytes = Encoding.UTF8.GetByteCount(value);
                    IsValid = true;
                }
                else
                {
                    _characters = new char[0];
                    _lengthInBytes = 0;
                }
            }
            else if (value.All(char.IsDigit))
            {
                _characters = value.ToCharArray();
                _lengthInBytes = Encoding.UTF8.GetByteCount(value);
                IsValid = true;
            }
            else
            {
                _characters = new char[0];
                _lengthInBytes = 0;
            }
        }

        public DecimalString(int number) : this(number.ToString()) { }

        public DecimalString() : this("") { }

        public override string ToString()
        {
            return new string(_characters);
        }

        public IDecimalString Difference(IDecimalString otherString)
        {
            if (!(otherString is DecimalString otherDecimalString))
            {
                return new DecimalString("");
            }

            if (!this.IsValid || !otherDecimalString.IsValid)
            {
                return new DecimalString("");
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherDecimalString.ToString(), out decimal secondNumber))
            {
                decimal result = firstNumber - secondNumber;
                return new DecimalString(result.ToString());
            }
            else
            {
                return new DecimalString("");
            }
        }

        public bool IsGreaterThan(IDecimalString otherString)
        {
            if (!(otherString is DecimalString otherDecimalString))
            {
                return false;
            }

            if (!this.IsValid || !otherDecimalString.IsValid)
            {
                return false;
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherDecimalString.ToString(), out decimal secondNumber))
            {
                return firstNumber > secondNumber;
            }
            return false;
        }

        public bool IsLessThan(IDecimalString otherString)
        {
            if (!(otherString is DecimalString otherDecimalString))
            {
                return false;
            }

            if (!this.IsValid || !otherDecimalString.IsValid)
            {
                return false;
            }
            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherDecimalString.ToString(), out decimal secondNumber))
            {
                return firstNumber < secondNumber;
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            IDecimalString other = obj as IDecimalString;
            if (other == null)
            {
                throw new ArgumentException("Об'єкт для порівняння повинен бути типу IDecimalString");
            }
            DecimalString otherDecimalString = other as DecimalString;
            if (otherDecimalString == null)
            {
                throw new ArgumentException("Об'єкт для порівняння не є коректним DecimalString");
            }


            if (!this.IsValid || !otherDecimalString.IsValid)
            {
                if (!this.IsValid && !otherDecimalString.IsValid) return 0;
                return this.IsValid ? 1 : -1;
            }

            if (decimal.TryParse(this.ToString(), out decimal firstNumber) &&
                decimal.TryParse(otherDecimalString.ToString(), out decimal secondNumber))
            {
                return firstNumber.CompareTo(secondNumber);
            }
            else
            {
                throw new InvalidOperationException("Неможливо порівняти DecimalString");
            }
        }

        public object Clone()
        {
            return new DecimalString(this.ToString());
        }

        public int Length()
        {
            return _characters.Length;
        }

        public int LengthInBytes()
        {
            return _lengthInBytes;
        }

        public void Clear()
        {
            _characters = new char[0];
            _lengthInBytes = 0;
        }
    }
}