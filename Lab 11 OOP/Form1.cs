﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11_OOP
{

    public partial class Form1 : Form
    {
        private List<DecimalString> decimalStringList = new List<DecimalString>();
        private EnginCalcCollection _calcCollection;
        public Form1()
        {
            InitializeComponent();
            _calcCollection = new EnginCalcCollection();
        }

        private void buttonStringLength_Click(object sender, EventArgs e)
        {
            String customString = new String(textBoxStringInput.Text);
            labelStringLengthResult.Text = $"{customString.Length()}";
        }

        private void buttonStringLengthBytes_Click(object sender, EventArgs e)
        {
            String customString = new String(textBoxStringInput.Text);
            labelStringLengthBytesResult.Text = $"{customString.LengthInBytes()}";
        }

        private void buttonStringClear_Click(object sender, EventArgs e)
        {
            String customString = new String(textBoxStringInput.Text);
            customString.Clear();
            textBoxStringInput.Clear();
            listBox1.Items.Clear();
        }



        private void buttonDifference_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDecimal1.Text) || string.IsNullOrEmpty(textBoxDecimal2.Text))
            {
                MessageBox.Show("Введіть обидва числа.");
                return;
            }

            DecimalString num1 = new DecimalString(textBoxDecimal1.Text);
            DecimalString num2 = new DecimalString(textBoxDecimal2.Text);

            if (!num1.IsValid && !num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Обидві стрічки прийняли нульове значення";
                return;
            }
            else if (!num1.IsValid)
            {
                textBoxDecimalStringResult.Text = "Перша стрічка прийняла нульове значення";
                return;
            }
            else if (!num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Друга стрічка прийняла нульове значення";
                return;
            }

            DecimalString difference = (DecimalString)num1.Difference(num2);
            textBoxDecimalStringResult.Text = $"{difference.ToString()}";
        }

        private void buttonLessThan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDecimal1.Text) || string.IsNullOrEmpty(textBoxDecimal2.Text))
            {
                MessageBox.Show("Введіть обидва числа.");
                return;
            }
            DecimalString num1 = new DecimalString(textBoxDecimal1.Text);
            DecimalString num2 = new DecimalString(textBoxDecimal2.Text);

            if (!num1.IsValid && !num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Обидві стрічки прийняли нульове значення";
                return;
            }
            else if (!num1.IsValid)
            {
                textBoxDecimalStringResult.Text = "Перша стрічка прийняла нульове значення";
                return;
            }
            else if (!num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Друга стрічка прийняла нульове значення";
                return;
            }

            textBoxDecimalStringResult.Text = $"{num1.IsLessThan(num2)}";
        }

        private void buttonGreaterThan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDecimal1.Text) || string.IsNullOrEmpty(textBoxDecimal2.Text))
            {
                MessageBox.Show("Введіть обидва числа.");
                return;
            }
            DecimalString num1 = new DecimalString(textBoxDecimal1.Text);
            DecimalString num2 = new DecimalString(textBoxDecimal2.Text);

            if (!num1.IsValid && !num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Обидві стрічки прийняли нульове значення";
                return;
            }
            else if (!num1.IsValid)
            {
                textBoxDecimalStringResult.Text = "Перша стрічка прийняла нульове значення";
                return;
            }
            else if (!num2.IsValid)
            {
                textBoxDecimalStringResult.Text = "Друга стрічка прийняла нульове значення";
                return;
            }

            textBoxDecimalStringResult.Text = $"{num1.IsGreaterThan(num2)}";
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 10)
            {
                MessageBox.Show("Досягнуто 10 елементів! Лістбокс буде очищено.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimalStringList.Clear();
                listBox1.Items.Clear();
                return;
            }
            if (decimalStringList.Count > 0)
            {
                decimalStringList.Sort();
                listBox1.Items.Clear();
                foreach (var decString in decimalStringList)
                {
                    listBox1.Items.Add(decString.ToString());
                }
            }
            else
            {
                MessageBox.Show("Список DecimalString порожній. Сортування неможливе.", "Повідомлення");
            }
        }

        private void Clone_Click(object sender, EventArgs e)

        {
            if (listBox1.Items.Count >= 10)
            {
                MessageBox.Show("Досягнуто 10 елементів! Лістбокс буде очищено.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimalStringList.Clear();
                listBox1.Items.Clear();
                return;
            }
            if (decimalStringList.Count == 0)
            {
                MessageBox.Show("Список DecimalString порожній. Клонування неможливе.", "Повідомлення");
                return;
            }


            List<DecimalString> clonedStrings = new List<DecimalString>();
            foreach (var decString in decimalStringList)
            {
                clonedStrings.Add(decString.Clone() as DecimalString);
            }

            decimalStringList.AddRange(clonedStrings);
            foreach (var clonedString in clonedStrings)
            {
                listBox1.Items.Add(clonedString.ToString());
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 10)
            {
                MessageBox.Show("Досягнуто 10 елементів! Лістбокс буде очищено.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimalStringList.Clear();
                listBox1.Items.Clear();
                return;
            }
            if (string.IsNullOrEmpty(textBoxDecimal1.Text))
            {
                MessageBox.Show("Список DecimalString не відповідає умовам створення.", "Повідомлення");
                return;
            }

            string input = textBoxDecimal1.Text;
            DecimalString newDecimalString = new DecimalString(input);

            if (newDecimalString.IsValid)
            {
                decimalStringList.Add(newDecimalString);
                listBox1.Items.Add(newDecimalString.ToString());
                textBoxDecimal1.Clear();
            }
            else
            {
                MessageBox.Show("Введено некоректний рядок для DecimalString.", "Помилка");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCalculator_Click(object sender, EventArgs e)
        {
            string model = textBoxCalcModel.Text;
            if (!double.TryParse(textBoxCalcPrice.Text, out double price))
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну.", "Помилка введення");
                return;
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Будь ласка, введіть модель калькулятора.", "Помилка введення");
                return;
            }

            EngineeringCalculator newCalc = new EngineeringCalculator(model, price);

            // Додаємо в обидві колекції (використовуємо модель як ключ для прикладу)
            _calcCollection.AddLegacyCalculator(model, newCalc);
            _calcCollection.AddGenericCalculator(model, newCalc);

            MessageBox.Show($"Калькулятор '{model}' додано.", "Додано");
            UpdateCalculatorListBoxes();
            textBoxCalcModel.Clear();
            textBoxCalcPrice.Clear();
        }

        private void buttonShowLegacyCalc_Click(object sender, EventArgs e)
        {
            string key = textBoxCalcKey.Text;
            string info = _calcCollection.GetLegacyElementInfo(key);
            MessageBox.Show(info, "Інформація про калькулятор (SortedList)");
        }

        private void buttonShowGenericCalc_Click(object sender, EventArgs e)
        {
            string key = textBoxCalcKey.Text;
            string info = _calcCollection.GetGenericElementInfo(key);
            MessageBox.Show(info, "Інформація про калькулятор (SortedList<T>)");
        }

        private void buttonEnumerateLegacy_Click(object sender, EventArgs e)
        {
            string enumeration = _calcCollection.EnumerateLegacyCollection();
            MessageBox.Show(enumeration, "Перелік елементів SortedList");
        }

        private void buttonEnumerateGeneric_Click(object sender, EventArgs e)
        {
            string enumeration = _calcCollection.EnumerateGenericCollection();
            MessageBox.Show(enumeration, "Перелік елементів SortedList<T>");
        }

        private void buttonRemoveLegacyCalc_Click(object sender, EventArgs e)
        {
            string keyToRemove = textBoxCalcKey.Text;
            _calcCollection.RemoveLegacyCalculator(keyToRemove);
            MessageBox.Show($"Елемент з ключем '{keyToRemove}' видалено з SortedList (якщо існував).", "Видалення");
            UpdateCalculatorListBoxes();
        }

        private void buttonRemoveGenericCalc_Click(object sender, EventArgs e)
        {
            string keyToRemove = textBoxCalcKey.Text;
            _calcCollection.RemoveGenericCalculator(keyToRemove);
            MessageBox.Show($"Елемент з ключем '{keyToRemove}' видалено з SortedList<T> (якщо існував).", "Видалення");
            UpdateCalculatorListBoxes();
        }

        private void UpdateCalculatorListBoxes()
        {
            listBoxLegacyCalculators.Items.Clear();
            foreach (EngineeringCalculator calc in _calcCollection.GetLegacyCalculators())
            {
                listBoxLegacyCalculators.Items.Add(calc.ToString());
            }

            listBoxGenericCalculators.Items.Clear();
            foreach (EngineeringCalculator calc in _calcCollection.GetGenericCalculators())
            {
                listBoxGenericCalculators.Items.Add(calc.ToString());
            }
        }
    }
}
