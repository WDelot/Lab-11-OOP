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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(888, 219);
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
            this.MaximumSize = new System.Drawing.Size(906, 266);
            this.MinimumSize = new System.Drawing.Size(906, 266);
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
    }
}

