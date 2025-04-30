using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_OOP
{
    public class String
    {
        protected char[] _characters;

        protected int _lengthInBytes;

        // Конструктор без параметрів
        public String()
        {
            _characters = new char[0];
            _lengthInBytes = 0;
        }

        // Конструктор string
        public String(string value)
        {
            _characters = value.ToCharArray();
            _lengthInBytes = (byte)Encoding.UTF8.GetByteCount(value);
        }

        // Конструктор char
        public String(char character)
        {
            _characters = new char[1] { character };
            _lengthInBytes = 1;
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