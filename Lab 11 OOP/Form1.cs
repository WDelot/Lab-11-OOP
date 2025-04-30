using System;
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
        public Form1()
        {
            InitializeComponent();
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

            DecimalString difference = num1.Difference(num2);
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
    }
}
