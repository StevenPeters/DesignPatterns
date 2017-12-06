namespace AdapterPattern
{
    partial class AdapterForm
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
            this.FBox1 = new System.Windows.Forms.TextBox();
            this.FBox2 = new System.Windows.Forms.TextBox();
            this.FBox3 = new System.Windows.Forms.TextBox();
            this.FBox4 = new System.Windows.Forms.TextBox();
            this.FBox5 = new System.Windows.Forms.TextBox();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.CBox1 = new System.Windows.Forms.TextBox();
            this.CBox2 = new System.Windows.Forms.TextBox();
            this.CBox3 = new System.Windows.Forms.TextBox();
            this.CBox4 = new System.Windows.Forms.TextBox();
            this.CBox5 = new System.Windows.Forms.TextBox();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.FConvertButton = new System.Windows.Forms.Button();
            this.CConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FBox1
            // 
            this.FBox1.Location = new System.Drawing.Point(12, 36);
            this.FBox1.Name = "FBox1";
            this.FBox1.Size = new System.Drawing.Size(86, 26);
            this.FBox1.TabIndex = 1;
            // 
            // FBox2
            // 
            this.FBox2.Location = new System.Drawing.Point(11, 68);
            this.FBox2.Name = "FBox2";
            this.FBox2.Size = new System.Drawing.Size(86, 26);
            this.FBox2.TabIndex = 2;
            // 
            // FBox3
            // 
            this.FBox3.Location = new System.Drawing.Point(11, 100);
            this.FBox3.Name = "FBox3";
            this.FBox3.Size = new System.Drawing.Size(86, 26);
            this.FBox3.TabIndex = 3;
            // 
            // FBox4
            // 
            this.FBox4.Location = new System.Drawing.Point(12, 132);
            this.FBox4.Name = "FBox4";
            this.FBox4.Size = new System.Drawing.Size(86, 26);
            this.FBox4.TabIndex = 4;
            // 
            // FBox5
            // 
            this.FBox5.Location = new System.Drawing.Point(12, 164);
            this.FBox5.Name = "FBox5";
            this.FBox5.Size = new System.Drawing.Size(86, 26);
            this.FBox5.TabIndex = 5;
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Location = new System.Drawing.Point(12, 13);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(86, 20);
            this.FahrenheitLabel.TabIndex = 0;
            this.FahrenheitLabel.Text = "Fahrenheit";
            // 
            // CBox1
            // 
            this.CBox1.Location = new System.Drawing.Point(104, 36);
            this.CBox1.Name = "CBox1";
            this.CBox1.Size = new System.Drawing.Size(86, 26);
            this.CBox1.TabIndex = 7;
            // 
            // CBox2
            // 
            this.CBox2.Location = new System.Drawing.Point(103, 68);
            this.CBox2.Name = "CBox2";
            this.CBox2.Size = new System.Drawing.Size(86, 26);
            this.CBox2.TabIndex = 8;
            // 
            // CBox3
            // 
            this.CBox3.Location = new System.Drawing.Point(103, 100);
            this.CBox3.Name = "CBox3";
            this.CBox3.Size = new System.Drawing.Size(86, 26);
            this.CBox3.TabIndex = 9;
            // 
            // CBox4
            // 
            this.CBox4.Location = new System.Drawing.Point(104, 132);
            this.CBox4.Name = "CBox4";
            this.CBox4.Size = new System.Drawing.Size(86, 26);
            this.CBox4.TabIndex = 10;
            // 
            // CBox5
            // 
            this.CBox5.Location = new System.Drawing.Point(104, 164);
            this.CBox5.Name = "CBox5";
            this.CBox5.Size = new System.Drawing.Size(86, 26);
            this.CBox5.TabIndex = 11;
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Location = new System.Drawing.Point(115, 13);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(60, 20);
            this.CelsiusLabel.TabIndex = 0;
            this.CelsiusLabel.Text = "Celsius";
            // 
            // FConvertButton
            // 
            this.FConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FConvertButton.Location = new System.Drawing.Point(12, 196);
            this.FConvertButton.Name = "FConvertButton";
            this.FConvertButton.Size = new System.Drawing.Size(86, 37);
            this.FConvertButton.TabIndex = 6;
            this.FConvertButton.Text = "Convert";
            this.FConvertButton.UseVisualStyleBackColor = true;
            this.FConvertButton.Click += new System.EventHandler(this.FConvertButton_Click);
            // 
            // CConvertButton
            // 
            this.CConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CConvertButton.Location = new System.Drawing.Point(104, 196);
            this.CConvertButton.Name = "CConvertButton";
            this.CConvertButton.Size = new System.Drawing.Size(86, 37);
            this.CConvertButton.TabIndex = 12;
            this.CConvertButton.Text = "Convert";
            this.CConvertButton.UseVisualStyleBackColor = true;
            this.CConvertButton.Click += new System.EventHandler(this.CConvertButton_Click);
            // 
            // AdapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 245);
            this.Controls.Add(this.CConvertButton);
            this.Controls.Add(this.FConvertButton);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.CBox5);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.CBox4);
            this.Controls.Add(this.FBox5);
            this.Controls.Add(this.CBox3);
            this.Controls.Add(this.FBox4);
            this.Controls.Add(this.CBox2);
            this.Controls.Add(this.FBox3);
            this.Controls.Add(this.CBox1);
            this.Controls.Add(this.FBox2);
            this.Controls.Add(this.FBox1);
            this.Name = "AdapterForm";
            this.Text = "AdapterPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FBox1;
        private System.Windows.Forms.TextBox FBox2;
        private System.Windows.Forms.TextBox FBox3;
        private System.Windows.Forms.TextBox FBox4;
        private System.Windows.Forms.TextBox FBox5;
        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.TextBox CBox1;
        private System.Windows.Forms.TextBox CBox2;
        private System.Windows.Forms.TextBox CBox3;
        private System.Windows.Forms.TextBox CBox4;
        private System.Windows.Forms.TextBox CBox5;
        private System.Windows.Forms.Label CelsiusLabel;
        private System.Windows.Forms.Button FConvertButton;
        private System.Windows.Forms.Button CConvertButton;
    }
}

