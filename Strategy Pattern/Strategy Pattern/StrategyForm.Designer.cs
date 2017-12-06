namespace Strategy_Pattern
{
    partial class StrategyForm
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
            this.numBox1 = new System.Windows.Forms.TextBox();
            this.numBox2 = new System.Windows.Forms.TextBox();
            this.numBox3 = new System.Windows.Forms.TextBox();
            this.numBox4 = new System.Windows.Forms.TextBox();
            this.numBox5 = new System.Windows.Forms.TextBox();
            this.numBox6 = new System.Windows.Forms.TextBox();
            this.numBox7 = new System.Windows.Forms.TextBox();
            this.numBox8 = new System.Windows.Forms.TextBox();
            this.numBox9 = new System.Windows.Forms.TextBox();
            this.numBox10 = new System.Windows.Forms.TextBox();
            this.InsertionSort = new System.Windows.Forms.Button();
            this.RInsertionSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numBox1
            // 
            this.numBox1.Location = new System.Drawing.Point(13, 13);
            this.numBox1.Name = "numBox1";
            this.numBox1.Size = new System.Drawing.Size(45, 26);
            this.numBox1.TabIndex = 1;
            // 
            // numBox2
            // 
            this.numBox2.Location = new System.Drawing.Point(64, 12);
            this.numBox2.Name = "numBox2";
            this.numBox2.Size = new System.Drawing.Size(45, 26);
            this.numBox2.TabIndex = 2;
            // 
            // numBox3
            // 
            this.numBox3.Location = new System.Drawing.Point(115, 12);
            this.numBox3.Name = "numBox3";
            this.numBox3.Size = new System.Drawing.Size(45, 26);
            this.numBox3.TabIndex = 3;
            // 
            // numBox4
            // 
            this.numBox4.Location = new System.Drawing.Point(166, 12);
            this.numBox4.Name = "numBox4";
            this.numBox4.Size = new System.Drawing.Size(45, 26);
            this.numBox4.TabIndex = 4;
            // 
            // numBox5
            // 
            this.numBox5.Location = new System.Drawing.Point(217, 12);
            this.numBox5.Name = "numBox5";
            this.numBox5.Size = new System.Drawing.Size(45, 26);
            this.numBox5.TabIndex = 5;
            // 
            // numBox6
            // 
            this.numBox6.Location = new System.Drawing.Point(268, 12);
            this.numBox6.Name = "numBox6";
            this.numBox6.Size = new System.Drawing.Size(45, 26);
            this.numBox6.TabIndex = 6;
            // 
            // numBox7
            // 
            this.numBox7.Location = new System.Drawing.Point(319, 12);
            this.numBox7.Name = "numBox7";
            this.numBox7.Size = new System.Drawing.Size(45, 26);
            this.numBox7.TabIndex = 7;
            // 
            // numBox8
            // 
            this.numBox8.Location = new System.Drawing.Point(370, 12);
            this.numBox8.Name = "numBox8";
            this.numBox8.Size = new System.Drawing.Size(45, 26);
            this.numBox8.TabIndex = 8;
            // 
            // numBox9
            // 
            this.numBox9.Location = new System.Drawing.Point(421, 12);
            this.numBox9.Name = "numBox9";
            this.numBox9.Size = new System.Drawing.Size(45, 26);
            this.numBox9.TabIndex = 9;
            // 
            // numBox10
            // 
            this.numBox10.Location = new System.Drawing.Point(472, 12);
            this.numBox10.Name = "numBox10";
            this.numBox10.Size = new System.Drawing.Size(45, 26);
            this.numBox10.TabIndex = 10;
            // 
            // InsertionSort
            // 
            this.InsertionSort.Location = new System.Drawing.Point(13, 46);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(249, 43);
            this.InsertionSort.TabIndex = 11;
            this.InsertionSort.Text = "Insertion Sort";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click);
            // 
            // RInsertionSort
            // 
            this.RInsertionSort.Location = new System.Drawing.Point(268, 46);
            this.RInsertionSort.Name = "RInsertionSort";
            this.RInsertionSort.Size = new System.Drawing.Size(249, 43);
            this.RInsertionSort.TabIndex = 12;
            this.RInsertionSort.Text = "Reverse Insertion Sort";
            this.RInsertionSort.UseVisualStyleBackColor = true;
            this.RInsertionSort.Click += new System.EventHandler(this.MergeSort_Click);
            // 
            // StrategyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 101);
            this.Controls.Add(this.RInsertionSort);
            this.Controls.Add(this.InsertionSort);
            this.Controls.Add(this.numBox10);
            this.Controls.Add(this.numBox9);
            this.Controls.Add(this.numBox8);
            this.Controls.Add(this.numBox7);
            this.Controls.Add(this.numBox6);
            this.Controls.Add(this.numBox5);
            this.Controls.Add(this.numBox4);
            this.Controls.Add(this.numBox3);
            this.Controls.Add(this.numBox2);
            this.Controls.Add(this.numBox1);
            this.Name = "StrategyForm";
            this.Text = "Strategy Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numBox1;
        private System.Windows.Forms.TextBox numBox2;
        private System.Windows.Forms.TextBox numBox3;
        private System.Windows.Forms.TextBox numBox4;
        private System.Windows.Forms.TextBox numBox5;
        private System.Windows.Forms.TextBox numBox6;
        private System.Windows.Forms.TextBox numBox7;
        private System.Windows.Forms.TextBox numBox8;
        private System.Windows.Forms.TextBox numBox9;
        private System.Windows.Forms.TextBox numBox10;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.Button RInsertionSort;
    }
}

