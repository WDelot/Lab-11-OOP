using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_OOP
{
    public class EnginCalcCollection
    {
        private SortedList _legacyCalculators;

        private SortedList<string, EngineeringCalculator> _genericCalculators;

        public EnginCalcCollection()
        {
            _legacyCalculators = new SortedList();
            _genericCalculators = new SortedList<string, EngineeringCalculator>();
        }
        public void AddLegacyCalculator(string key, EngineeringCalculator calculator)
        {
            if (!_legacyCalculators.ContainsKey(key))
            {
                _legacyCalculators.Add(key, calculator);
            }
            else
            {
                Console.WriteLine($"Елемент з ключем '{key}' вже існує у колекції SortedList.");
            }
        }

        public EngineeringCalculator GetLegacyCalculator(string key)
        {
            return _legacyCalculators.ContainsKey(key) ? (EngineeringCalculator)_legacyCalculators[key] : null;
        }

        public void RemoveLegacyCalculator(string key)
        {
            if (_legacyCalculators.ContainsKey(key))
            {
                _legacyCalculators.Remove(key);
            }
        }

        public IEnumerable GetLegacyCalculators()
        {
            return _legacyCalculators.Values;
        }
        public void AddGenericCalculator(string key, EngineeringCalculator calculator)
        {
            if (!_genericCalculators.ContainsKey(key))
            {
                _genericCalculators.Add(key, calculator);
            }
            else
            {
                Console.WriteLine($"Елемент з ключем '{key}' вже існує у колекції SortedList<T>.");
            }
        }

        public EngineeringCalculator GetGenericCalculator(string key)
        {
            return _genericCalculators.ContainsKey(key) ? _genericCalculators[key] : null;
        }

        public void RemoveGenericCalculator(string key)
        {
            if (_genericCalculators.ContainsKey(key))
            {
                _genericCalculators.Remove(key);
            }
        }

        public IEnumerable<EngineeringCalculator> GetGenericCalculators()
        {
            return _genericCalculators.Values;
        }
        public string EnumerateLegacyCollection()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Елементи колекції SortedList (System.Collections):");
            foreach (DictionaryEntry entry in _legacyCalculators)
            {
                sb.AppendLine($"Ключ: {entry.Key}, Значення: {entry.Value}");
            }
            return sb.ToString();
        }
        public string EnumerateGenericCollection()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Елементи колекції SortedList<T> (System.Collections.Generic):");
            foreach (KeyValuePair<string, EngineeringCalculator> entry in _genericCalculators)
            {
                sb.AppendLine($"Ключ: {entry.Key}, Значення: {entry.Value}");
            }
            return sb.ToString();
        }
        public string GetLegacyElementInfo(string key)
        {
            EngineeringCalculator calculator = GetLegacyCalculator(key);
            if (calculator != null)
            {
                return $"Інформація про елемент (System.Collections) з ключем '{key}':\n{calculator.ToString()}";
            }
            return $"Елемент з ключем '{key}' не знайдено у колекції SortedList.";
        }
        public string GetGenericElementInfo(string key)
        {
            EngineeringCalculator calculator = GetGenericCalculator(key);
            if (calculator != null)
            {
                return $"Інформація про елемент (System.Collections.Generic) з ключем '{key}':\n{calculator.ToString()}";
            }
            return $"Елемент з ключем '{key}' не знайдено у колекції SortedList<T>.";
        }
    }
}