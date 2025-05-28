namespace Lab_11_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStringInput = new System.Windows.Forms.TextBox();
            this.textBoxDecimal1 = new System.Windows.Forms.TextBox();
            this.textBoxDecimal2 = new System.Windows.Forms.TextBox();
            this.buttonStringClear = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonGreaterThan = new System.Windows.Forms.Button();
            this.buttonLessThan = new System.Windows.Forms.Button();
            this.buttonStringLength = new System.Windows.Forms.Button();
            this.buttonStringLengthBytes = new System.Windows.Forms.Button();
            this.labelStringLengthResult = new System.Windows.Forms.Label();
            this.labelStringLengthBytesResult = new System.Windows.Forms.Label();
            this.textBoxDecimalStringResult = new System.Windows.Forms.TextBox();
            this.Sort = new System.Windows.Forms.Button();
            this.Clone = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCalcModel = new System.Windows.Forms.TextBox();
            this.textBoxCalcPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddCalculator = new System.Windows.Forms.Button();
            this.textBoxCalcKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxGenericCalculators = new System.Windows.Forms.ListBox();
            this.listBoxLegacyCalculators = new System.Windows.Forms.ListBox();
            this.buttonShowLegacyCalc = new System.Windows.Forms.Button();
            this.buttonEnumerateLegacy = new System.Windows.Forms.Button();
            this.buttonRemoveLegacyCalc = new System.Windows.Forms.Button();
            this.buttonRemoveGenericCalc = new System.Windows.Forms.Button();
            this.buttonEnumerateGeneric = new System.Windows.Forms.Button();
            this.buttonShowGenericCalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реалізація класу String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Реалізаця похідного класу DecimalString";
            // 
            // textBoxStringInput
            // 
            this.textBoxStringInput.Location = new System.Drawing.Point(12, 52);
            this.textBoxStringInput.MaxLength = 129;
            this.textBoxStringInput.Name = "textBoxStringInput";
            this.textBoxStringInput.Size = new System.Drawing.Size(318, 22);
            this.textBoxStringInput.TabIndex = 2;
            // 
            // textBoxDecimal1
            // 
            this.textBoxDecimal1.Location = new System.Drawing.Point(444, 52);
            this.textBoxDecimal1.MaxLength = 100;
            this.textBoxDecimal1.Name = "textBoxDecimal1";
            this.textBoxDecimal1.Size = new System.Drawing.Size(318, 22);
            this.textBoxDecimal1.TabIndex = 3;
            // 
            // textBoxDecimal2
            // 
            this.textBoxDecimal2.Location = new System.Drawing.Point(444, 80);
            this.textBoxDecimal2.MaxLength = 100;
            this.textBoxDecimal2.Name = "textBoxDecimal2";
            this.textBoxDecimal2.Size = new System.Drawing.Size(318, 22);
            this.textBoxDecimal2.TabIndex = 4;
            // 
            // buttonStringClear
            // 
            this.buttonStringClear.Location = new System.Drawing.Point(12, 180);
            this.buttonStringClear.Name = "buttonStringClear";
            this.buttonStringClear.Size = new System.Drawing.Size(318, 28);
            this.buttonStringClear.TabIndex = 7;
            this.buttonStringClear.Text = "Очистити";
            this.buttonStringClear.UseVisualStyleBackColor = true;
            this.buttonStringClear.Click += new System.EventHandler(this.buttonStringClear_Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(444, 116);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(102, 44);
            this.buttonDifference.TabIndex = 8;
            this.buttonDifference.Text = "Різниця";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // buttonGreaterThan
            // 
            this.buttonGreaterThan.Location = new System.Drawing.Point(660, 116);
            this.buttonGreaterThan.Name = "buttonGreaterThan";
            this.buttonGreaterThan.Size = new System.Drawing.Size(102, 44);
            this.buttonGreaterThan.TabIndex = 9;
            this.buttonGreaterThan.Text = "Більше?";
            this.buttonGreaterThan.UseVisualStyleBackColor = true;
            this.buttonGreaterThan.Click += new System.EventHandler(this.buttonGreaterThan_Click);
            // 
            // buttonLessThan
            // 
            this.buttonLessThan.Location = new System.Drawing.Point(552, 116);
            this.buttonLessThan.Name = "buttonLessThan";
            this.buttonLessThan.Size = new System.Drawing.Size(102, 44);
            this.buttonLessThan.TabIndex = 10;
            this.buttonLessThan.Text = "Менше?";
            this.buttonLessThan.UseVisualStyleBackColor = true;
            this.buttonLessThan.Click += new System.EventHandler(this.buttonLessThan_Click);
            // 
            // buttonStringLength
            // 
            this.buttonStringLength.Location = new System.Drawing.Point(12, 80);
            this.buttonStringLength.Name = "buttonStringLength";
            this.buttonStringLength.Size = new System.Drawing.Size(102, 44);
            this.buttonStringLength.TabIndex = 11;
            this.buttonStringLength.Text = "Довжина";
            this.buttonStringLength.UseVisualStyleBackColor = true;
            this.buttonStringLength.Click += new System.EventHandler(this.buttonStringLength_Click);
            // 
            // buttonStringLengthBytes
            // 
            this.buttonStringLengthBytes.Location = new System.Drawing.Point(12, 130);
            this.buttonStringLengthBytes.Name = "buttonStringLengthBytes";
            this.buttonStringLengthBytes.Size = new System.Drawing.Size(102, 44);
            this.buttonStringLengthBytes.TabIndex = 12;
            this.buttonStringLengthBytes.Text = "Довжина в байтах";
            this.buttonStringLengthBytes.UseVisualStyleBackColor = true;
            this.buttonStringLengthBytes.Click += new System.EventHandler(this.buttonStringLengthBytes_Click);
            // 
            // labelStringLengthResult
            // 
            this.labelStringLengthResult.AutoSize = true;
            this.labelStringLengthResult.Location = new System.Drawing.Point(120, 94);
            this.labelStringLengthResult.Name = "labelStringLengthResult";
            this.labelStringLengthResult.Size = new System.Drawing.Size(14, 16);
            this.labelStringLengthResult.TabIndex = 13;
            this.labelStringLengthResult.Text = "0";
            // 
            // labelStringLengthBytesResult
            // 
            this.labelStringLengthBytesResult.AutoSize = true;
            this.labelStringLengthBytesResult.Location = new System.Drawing.Point(120, 144);
            this.labelStringLengthBytesResult.Name = "labelStringLengthBytesResult";
            this.labelStringLengthBytesResult.Size = new System.Drawing.Size(14, 16);
            this.labelStringLengthBytesResult.TabIndex = 14;
            this.labelStringLengthBytesResult.Text = "0";
            // 
            // textBoxDecimalStringResult
            // 
            this.textBoxDecimalStringResult.Location = new System.Drawing.Point(444, 180);
            this.textBoxDecimalStringResult.Name = "textBoxDecimalStringResult";
            this.textBoxDecimalStringResult.ReadOnly = true;
            this.textBoxDecimalStringResult.Size = new System.Drawing.Size(318, 22);
            this.textBoxDecimalStringResult.TabIndex = 15;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(833, 51);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(98, 53);
            this.Sort.TabIndex = 16;
            this.Sort.Text = "Сортувати";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Clone
            // 
            this.Clone.Location = new System.Drawing.Point(833, 163);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(98, 53);
            this.Clone.TabIndex = 17;
            this.Clone.Text = "Клонувати";
            this.Clone.UseVisualStyleBackColor = true;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(948, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 164);
            this.listBox1.TabIndex = 18;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(833, 108);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(98, 53);
            this.Create.TabIndex = 19;
            this.Create.Text = "Додати";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(858, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Реалізація інтерфесу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Модель калькулятора";
            // 
            // textBoxCalcModel
            // 
            this.textBoxCalcModel.Location = new System.Drawing.Point(35, 291);
            this.textBoxCalcModel.Name = "textBoxCalcModel";
            this.textBoxCalcModel.Size = new System.Drawing.Size(115, 22);
            this.textBoxCalcModel.TabIndex = 22;
            // 
            // textBoxCalcPrice
            // 
            this.textBoxCalcPrice.Location = new System.Drawing.Point(252, 291);
            this.textBoxCalcPrice.Name = "textBoxCalcPrice";
            this.textBoxCalcPrice.Size = new System.Drawing.Size(115, 22);
            this.textBoxCalcPrice.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ціна калькулятора";
            // 
            // buttonAddCalculator
            // 
            this.buttonAddCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCalculator.Location = new System.Drawing.Point(252, 340);
            this.buttonAddCalculator.Name = "buttonAddCalculator";
            this.buttonAddCalculator.Size = new System.Drawing.Size(115, 49);
            this.buttonAddCalculator.TabIndex = 25;
            this.buttonAddCalculator.Text = "Додати калькулятор";
            this.buttonAddCalculator.UseVisualStyleBackColor = true;
            this.buttonAddCalculator.Click += new System.EventHandler(this.buttonAddCalculator_Click);
            // 
            // textBoxCalcKey
            // 
            this.textBoxCalcKey.Location = new System.Drawing.Point(35, 354);
            this.textBoxCalcKey.Name = "textBoxCalcKey";
            this.textBoxCalcKey.Size = new System.Drawing.Size(115, 22);
            this.textBoxCalcKey.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(64, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ключ";
            // 
            // listBoxGenericCalculators
            // 
            this.listBoxGenericCalculators.FormattingEnabled = true;
            this.listBoxGenericCalculators.ItemHeight = 16;
            this.listBoxGenericCalculators.Location = new System.Drawing.Point(863, 307);
            this.listBoxGenericCalculators.Name = "listBoxGenericCalculators";
            this.listBoxGenericCalculators.Size = new System.Drawing.Size(226, 164);
            this.listBoxGenericCalculators.TabIndex = 30;
            // 
            // listBoxLegacyCalculators
            // 
            this.listBoxLegacyCalculators.FormattingEnabled = true;
            this.listBoxLegacyCalculators.ItemHeight = 16;
            this.listBoxLegacyCalculators.Location = new System.Drawing.Point(504, 307);
            this.listBoxLegacyCalculators.Name = "listBoxLegacyCalculators";
            this.listBoxLegacyCalculators.Size = new System.Drawing.Size(226, 164);
            this.listBoxLegacyCalculators.TabIndex = 31;
            // 
            // buttonShowLegacyCalc
            // 
            this.buttonShowLegacyCalc.Location = new System.Drawing.Point(398, 307);
            this.buttonShowLegacyCalc.Name = "buttonShowLegacyCalc";
            this.buttonShowLegacyCalc.Size = new System.Drawing.Size(100, 44);
            this.buttonShowLegacyCalc.TabIndex = 32;
            this.buttonShowLegacyCalc.Text = "Показати";
            this.buttonShowLegacyCalc.UseVisualStyleBackColor = true;
            this.buttonShowLegacyCalc.Click += new System.EventHandler(this.buttonShowLegacyCalc_Click);
            // 
            // buttonEnumerateLegacy
            // 
            this.buttonEnumerateLegacy.Location = new System.Drawing.Point(398, 367);
            this.buttonEnumerateLegacy.Name = "buttonEnumerateLegacy";
            this.buttonEnumerateLegacy.Size = new System.Drawing.Size(100, 44);
            this.buttonEnumerateLegacy.TabIndex = 33;
            this.buttonEnumerateLegacy.Text = "Перебрати";
            this.buttonEnumerateLegacy.UseVisualStyleBackColor = true;
            this.buttonEnumerateLegacy.Click += new System.EventHandler(this.buttonEnumerateLegacy_Click);
            // 
            // buttonRemoveLegacyCalc
            // 
            this.buttonRemoveLegacyCalc.Location = new System.Drawing.Point(398, 427);
            this.buttonRemoveLegacyCalc.Name = "buttonRemoveLegacyCalc";
            this.buttonRemoveLegacyCalc.Size = new System.Drawing.Size(100, 44);
            this.buttonRemoveLegacyCalc.TabIndex = 34;
            this.buttonRemoveLegacyCalc.Text = "Видалити";
            this.buttonRemoveLegacyCalc.UseVisualStyleBackColor = true;
            this.buttonRemoveLegacyCalc.Click += new System.EventHandler(this.buttonRemoveLegacyCalc_Click);
            // 
            // buttonRemoveGenericCalc
            // 
            this.buttonRemoveGenericCalc.Location = new System.Drawing.Point(757, 427);
            this.buttonRemoveGenericCalc.Name = "buttonRemoveGenericCalc";
            this.buttonRemoveGenericCalc.Size = new System.Drawing.Size(103, 44);
            this.buttonRemoveGenericCalc.TabIndex = 37;
            this.buttonRemoveGenericCalc.Text = "Видалити";
            this.buttonRemoveGenericCalc.UseVisualStyleBackColor = true;
            this.buttonRemoveGenericCalc.Click += new System.EventHandler(this.buttonRemoveGenericCalc_Click);
            // 
            // buttonEnumerateGeneric
            // 
            this.buttonEnumerateGeneric.Location = new System.Drawing.Point(757, 367);
            this.buttonEnumerateGeneric.Name = "buttonEnumerateGeneric";
            this.buttonEnumerateGeneric.Size = new System.Drawing.Size(100, 44);
            this.buttonEnumerateGeneric.TabIndex = 36;
            this.buttonEnumerateGeneric.Text = "Перебрати ";
            this.buttonEnumerateGeneric.UseVisualStyleBackColor = true;
            this.buttonEnumerateGeneric.Click += new System.EventHandler(this.buttonEnumerateGeneric_Click);
            // 
            // buttonShowGenericCalc
            // 
            this.buttonShowGenericCalc.Location = new System.Drawing.Point(757, 307);
            this.buttonShowGenericCalc.Name = "buttonShowGenericCalc";
            this.buttonShowGenericCalc.Size = new System.Drawing.Size(100, 44);
            this.buttonShowGenericCalc.TabIndex = 35;
            this.buttonShowGenericCalc.Text = "Показати";
            this.buttonShowGenericCalc.UseVisualStyleBackColor = true;
            this.buttonShowGenericCalc.Click += new System.EventHandler(this.buttonShowGenericCalc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(548, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "SortedList";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(923, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "SortedList<>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 483);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRemoveGenericCalc);
            this.Controls.Add(this.buttonEnumerateGeneric);
            this.Controls.Add(this.buttonShowGenericCalc);
            this.Controls.Add(this.buttonRemoveLegacyCalc);
            this.Controls.Add(this.buttonEnumerateLegacy);
            this.Controls.Add(this.buttonShowLegacyCalc);
            this.Controls.Add(this.listBoxLegacyCalculators);
            this.Controls.Add(this.listBoxGenericCalculators);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCalcKey);
            this.Controls.Add(this.buttonAddCalculator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCalcPrice);
            this.Controls.Add(this.textBoxCalcModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Clone);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.textBoxDecimalStringResult);
            this.Controls.Add(this.labelStringLengthBytesResult);
            this.Controls.Add(this.labelStringLengthResult);
            this.Controls.Add(this.buttonStringLengthBytes);
            this.Controls.Add(this.buttonStringLength);
            this.Controls.Add(this.buttonLessThan);
            this.Controls.Add(this.buttonGreaterThan);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonStringClear);
            this.Controls.Add(this.textBoxDecimal2);
            this.Controls.Add(this.textBoxDecimal1);
            this.Controls.Add(this.textBoxStringInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1216, 530);
            this.MinimumSize = new System.Drawing.Size(1216, 530);
            this.Name = "Form1";
            this.Text = "Стрічки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStringInput;
        private System.Windows.Forms.TextBox textBoxDecimal1;
        private System.Windows.Forms.TextBox textBoxDecimal2;
        private System.Windows.Forms.Button buttonStringClear;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonGreaterThan;
        private System.Windows.Forms.Button buttonLessThan;
        private System.Windows.Forms.Button buttonStringLength;
        private System.Windows.Forms.Button buttonStringLengthBytes;
        private System.Windows.Forms.Label labelStringLengthResult;
        private System.Windows.Forms.Label labelStringLengthBytesResult;
        private System.Windows.Forms.TextBox textBoxDecimalStringResult;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCalcModel;
        private System.Windows.Forms.TextBox textBoxCalcPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddCalculator;
        private System.Windows.Forms.TextBox textBoxCalcKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxGenericCalculators;
        private System.Windows.Forms.ListBox listBoxLegacyCalculators;
        private System.Windows.Forms.Button buttonShowLegacyCalc;
        private System.Windows.Forms.Button buttonEnumerateLegacy;
        private System.Windows.Forms.Button buttonRemoveLegacyCalc;
        private System.Windows.Forms.Button buttonRemoveGenericCalc;
        private System.Windows.Forms.Button buttonEnumerateGeneric;
        private System.Windows.Forms.Button buttonShowGenericCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

