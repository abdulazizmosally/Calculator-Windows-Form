namespace Calculator_Windows_Form
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
            this.Lab_Equestion = new System.Windows.Forms.Label();
            this.Value_Calculator = new System.Windows.Forms.TextBox();
            this.But_Plus = new System.Windows.Forms.Button();
            this.But_Dot = new System.Windows.Forms.Button();
            this.But_Zero = new System.Windows.Forms.Button();
            this.But_Equal = new System.Windows.Forms.Button();
            this.But_Minus = new System.Windows.Forms.Button();
            this.But_Three = new System.Windows.Forms.Button();
            this.But_Two = new System.Windows.Forms.Button();
            this.But_One = new System.Windows.Forms.Button();
            this.But_C = new System.Windows.Forms.Button();
            this.But_Multiply = new System.Windows.Forms.Button();
            this.But_Six = new System.Windows.Forms.Button();
            this.But_Five = new System.Windows.Forms.Button();
            this.But_Four = new System.Windows.Forms.Button();
            this.But_CE = new System.Windows.Forms.Button();
            this.But_Divide = new System.Windows.Forms.Button();
            this.But_Nine = new System.Windows.Forms.Button();
            this.But_Eight = new System.Windows.Forms.Button();
            this.But_Seven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab_Equestion
            // 
            this.Lab_Equestion.AutoSize = true;
            this.Lab_Equestion.Location = new System.Drawing.Point(30, 17);
            this.Lab_Equestion.Name = "Lab_Equestion";
            this.Lab_Equestion.Size = new System.Drawing.Size(0, 32);
            this.Lab_Equestion.TabIndex = 37;
            // 
            // Value_Calculator
            // 
            this.Value_Calculator.BackColor = System.Drawing.SystemColors.Menu;
            this.Value_Calculator.Enabled = false;
            this.Value_Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value_Calculator.Location = new System.Drawing.Point(21, 71);
            this.Value_Calculator.Multiline = true;
            this.Value_Calculator.Name = "Value_Calculator";
            this.Value_Calculator.Size = new System.Drawing.Size(579, 58);
            this.Value_Calculator.TabIndex = 36;
            this.Value_Calculator.Text = "0";
            this.Value_Calculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // But_Plus
            // 
            this.But_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Plus.Location = new System.Drawing.Point(379, 461);
            this.But_Plus.Name = "But_Plus";
            this.But_Plus.Size = new System.Drawing.Size(101, 90);
            this.But_Plus.TabIndex = 33;
            this.But_Plus.Text = "+";
            this.But_Plus.UseVisualStyleBackColor = true;
            this.But_Plus.Click += new System.EventHandler(this.But_Operations);
            // 
            // But_Dot
            // 
            this.But_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Dot.Location = new System.Drawing.Point(258, 461);
            this.But_Dot.Name = "But_Dot";
            this.But_Dot.Size = new System.Drawing.Size(101, 90);
            this.But_Dot.TabIndex = 34;
            this.But_Dot.Text = ".";
            this.But_Dot.UseVisualStyleBackColor = true;
            this.But_Dot.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Zero
            // 
            this.But_Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Zero.Location = new System.Drawing.Point(21, 461);
            this.But_Zero.Name = "But_Zero";
            this.But_Zero.Size = new System.Drawing.Size(217, 90);
            this.But_Zero.TabIndex = 35;
            this.But_Zero.Text = "0";
            this.But_Zero.UseVisualStyleBackColor = true;
            this.But_Zero.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Equal
            // 
            this.But_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Equal.Location = new System.Drawing.Point(499, 354);
            this.But_Equal.Name = "But_Equal";
            this.But_Equal.Size = new System.Drawing.Size(101, 197);
            this.But_Equal.TabIndex = 28;
            this.But_Equal.Text = "=";
            this.But_Equal.UseVisualStyleBackColor = true;
            this.But_Equal.Click += new System.EventHandler(this.But_Equal_Click);
            // 
            // But_Minus
            // 
            this.But_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Minus.Location = new System.Drawing.Point(379, 354);
            this.But_Minus.Name = "But_Minus";
            this.But_Minus.Size = new System.Drawing.Size(101, 90);
            this.But_Minus.TabIndex = 29;
            this.But_Minus.Text = "-";
            this.But_Minus.UseVisualStyleBackColor = true;
            this.But_Minus.Click += new System.EventHandler(this.But_Operations);
            // 
            // But_Three
            // 
            this.But_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Three.Location = new System.Drawing.Point(258, 354);
            this.But_Three.Name = "But_Three";
            this.But_Three.Size = new System.Drawing.Size(101, 90);
            this.But_Three.TabIndex = 30;
            this.But_Three.Text = "3";
            this.But_Three.UseVisualStyleBackColor = true;
            this.But_Three.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Two
            // 
            this.But_Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Two.Location = new System.Drawing.Point(138, 354);
            this.But_Two.Name = "But_Two";
            this.But_Two.Size = new System.Drawing.Size(101, 90);
            this.But_Two.TabIndex = 31;
            this.But_Two.Text = "2";
            this.But_Two.UseVisualStyleBackColor = true;
            this.But_Two.Click += new System.EventHandler(this.But_Values);
            // 
            // But_One
            // 
            this.But_One.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_One.Location = new System.Drawing.Point(21, 354);
            this.But_One.Name = "But_One";
            this.But_One.Size = new System.Drawing.Size(101, 90);
            this.But_One.TabIndex = 32;
            this.But_One.Text = "1";
            this.But_One.UseVisualStyleBackColor = true;
            this.But_One.Click += new System.EventHandler(this.But_Values);
            // 
            // But_C
            // 
            this.But_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_C.Location = new System.Drawing.Point(499, 251);
            this.But_C.Name = "But_C";
            this.But_C.Size = new System.Drawing.Size(101, 90);
            this.But_C.TabIndex = 23;
            this.But_C.Text = "C";
            this.But_C.UseVisualStyleBackColor = true;
            this.But_C.Click += new System.EventHandler(this.But_C_Click);
            // 
            // But_Multiply
            // 
            this.But_Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Multiply.Location = new System.Drawing.Point(379, 251);
            this.But_Multiply.Name = "But_Multiply";
            this.But_Multiply.Size = new System.Drawing.Size(101, 90);
            this.But_Multiply.TabIndex = 24;
            this.But_Multiply.Text = "*";
            this.But_Multiply.UseVisualStyleBackColor = true;
            this.But_Multiply.Click += new System.EventHandler(this.But_Operations);
            // 
            // But_Six
            // 
            this.But_Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Six.Location = new System.Drawing.Point(258, 251);
            this.But_Six.Name = "But_Six";
            this.But_Six.Size = new System.Drawing.Size(101, 90);
            this.But_Six.TabIndex = 25;
            this.But_Six.Text = "6";
            this.But_Six.UseVisualStyleBackColor = true;
            this.But_Six.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Five
            // 
            this.But_Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Five.Location = new System.Drawing.Point(138, 251);
            this.But_Five.Name = "But_Five";
            this.But_Five.Size = new System.Drawing.Size(101, 90);
            this.But_Five.TabIndex = 26;
            this.But_Five.Text = "5";
            this.But_Five.UseVisualStyleBackColor = true;
            this.But_Five.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Four
            // 
            this.But_Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Four.Location = new System.Drawing.Point(21, 251);
            this.But_Four.Name = "But_Four";
            this.But_Four.Size = new System.Drawing.Size(101, 90);
            this.But_Four.TabIndex = 27;
            this.But_Four.Text = "4";
            this.But_Four.UseVisualStyleBackColor = true;
            this.But_Four.Click += new System.EventHandler(this.But_Values);
            // 
            // But_CE
            // 
            this.But_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_CE.Location = new System.Drawing.Point(499, 145);
            this.But_CE.Name = "But_CE";
            this.But_CE.Size = new System.Drawing.Size(101, 90);
            this.But_CE.TabIndex = 21;
            this.But_CE.Text = "CE";
            this.But_CE.UseVisualStyleBackColor = true;
            this.But_CE.Click += new System.EventHandler(this.But_CE_Click);
            // 
            // But_Divide
            // 
            this.But_Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Divide.Location = new System.Drawing.Point(379, 145);
            this.But_Divide.Name = "But_Divide";
            this.But_Divide.Size = new System.Drawing.Size(101, 90);
            this.But_Divide.TabIndex = 20;
            this.But_Divide.Text = "/";
            this.But_Divide.UseVisualStyleBackColor = true;
            this.But_Divide.Click += new System.EventHandler(this.But_Operations);
            // 
            // But_Nine
            // 
            this.But_Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Nine.Location = new System.Drawing.Point(258, 145);
            this.But_Nine.Name = "But_Nine";
            this.But_Nine.Size = new System.Drawing.Size(101, 90);
            this.But_Nine.TabIndex = 19;
            this.But_Nine.Text = "9";
            this.But_Nine.UseVisualStyleBackColor = true;
            this.But_Nine.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Eight
            // 
            this.But_Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Eight.Location = new System.Drawing.Point(138, 145);
            this.But_Eight.Name = "But_Eight";
            this.But_Eight.Size = new System.Drawing.Size(101, 90);
            this.But_Eight.TabIndex = 22;
            this.But_Eight.Text = "8";
            this.But_Eight.UseVisualStyleBackColor = true;
            this.But_Eight.Click += new System.EventHandler(this.But_Values);
            // 
            // But_Seven
            // 
            this.But_Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Seven.Location = new System.Drawing.Point(21, 145);
            this.But_Seven.Name = "But_Seven";
            this.But_Seven.Size = new System.Drawing.Size(101, 90);
            this.But_Seven.TabIndex = 18;
            this.But_Seven.Text = "7";
            this.But_Seven.UseVisualStyleBackColor = true;
            this.But_Seven.Click += new System.EventHandler(this.But_Values);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 564);
            this.Controls.Add(this.Lab_Equestion);
            this.Controls.Add(this.Value_Calculator);
            this.Controls.Add(this.But_Plus);
            this.Controls.Add(this.But_Dot);
            this.Controls.Add(this.But_Zero);
            this.Controls.Add(this.But_Equal);
            this.Controls.Add(this.But_Minus);
            this.Controls.Add(this.But_Three);
            this.Controls.Add(this.But_Two);
            this.Controls.Add(this.But_One);
            this.Controls.Add(this.But_C);
            this.Controls.Add(this.But_Multiply);
            this.Controls.Add(this.But_Six);
            this.Controls.Add(this.But_Five);
            this.Controls.Add(this.But_Four);
            this.Controls.Add(this.But_CE);
            this.Controls.Add(this.But_Divide);
            this.Controls.Add(this.But_Nine);
            this.Controls.Add(this.But_Eight);
            this.Controls.Add(this.But_Seven);
            this.MaximumSize = new System.Drawing.Size(644, 652);
            this.MinimumSize = new System.Drawing.Size(644, 652);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Equestion;
        private System.Windows.Forms.TextBox Value_Calculator;
        private System.Windows.Forms.Button But_Plus;
        private System.Windows.Forms.Button But_Dot;
        private System.Windows.Forms.Button But_Zero;
        private System.Windows.Forms.Button But_Equal;
        private System.Windows.Forms.Button But_Minus;
        private System.Windows.Forms.Button But_Three;
        private System.Windows.Forms.Button But_Two;
        private System.Windows.Forms.Button But_One;
        private System.Windows.Forms.Button But_C;
        private System.Windows.Forms.Button But_Multiply;
        private System.Windows.Forms.Button But_Six;
        private System.Windows.Forms.Button But_Five;
        private System.Windows.Forms.Button But_Four;
        private System.Windows.Forms.Button But_CE;
        private System.Windows.Forms.Button But_Divide;
        private System.Windows.Forms.Button But_Nine;
        private System.Windows.Forms.Button But_Eight;
        private System.Windows.Forms.Button But_Seven;
    }
}

