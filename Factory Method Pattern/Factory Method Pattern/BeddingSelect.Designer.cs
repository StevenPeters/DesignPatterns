namespace Factory_Method_Pattern
{
    partial class BeddingSelect
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
            this.TwinRadioButton = new System.Windows.Forms.RadioButton();
            this.BeddingListView = new System.Windows.Forms.ListView();
            this.XLTwinRadioButton = new System.Windows.Forms.RadioButton();
            this.FullRadioButton = new System.Windows.Forms.RadioButton();
            this.QueenRadioButton = new System.Windows.Forms.RadioButton();
            this.KingRadioButton = new System.Windows.Forms.RadioButton();
            this.BedSizeLabel = new System.Windows.Forms.Label();
            this.RequiredBeddingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TwinRadioButton
            // 
            this.TwinRadioButton.AutoSize = true;
            this.TwinRadioButton.Location = new System.Drawing.Point(16, 32);
            this.TwinRadioButton.Name = "TwinRadioButton";
            this.TwinRadioButton.Size = new System.Drawing.Size(66, 24);
            this.TwinRadioButton.TabIndex = 1;
            this.TwinRadioButton.TabStop = true;
            this.TwinRadioButton.Text = "Twin";
            this.TwinRadioButton.UseVisualStyleBackColor = true;
            this.TwinRadioButton.CheckedChanged += new System.EventHandler(this.TwinRadioButton_CheckedChanged);
            // 
            // BeddingListView
            // 
            this.BeddingListView.Location = new System.Drawing.Point(180, 32);
            this.BeddingListView.Name = "BeddingListView";
            this.BeddingListView.Size = new System.Drawing.Size(114, 144);
            this.BeddingListView.TabIndex = 6;
            this.BeddingListView.UseCompatibleStateImageBehavior = false;
            // 
            // XLTwinRadioButton
            // 
            this.XLTwinRadioButton.AutoSize = true;
            this.XLTwinRadioButton.Location = new System.Drawing.Point(16, 62);
            this.XLTwinRadioButton.Name = "XLTwinRadioButton";
            this.XLTwinRadioButton.Size = new System.Drawing.Size(90, 24);
            this.XLTwinRadioButton.TabIndex = 2;
            this.XLTwinRadioButton.TabStop = true;
            this.XLTwinRadioButton.Text = "XL Twin";
            this.XLTwinRadioButton.UseVisualStyleBackColor = true;
            this.XLTwinRadioButton.CheckedChanged += new System.EventHandler(this.XLTwinRadioButton_CheckedChanged);
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Location = new System.Drawing.Point(16, 92);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(59, 24);
            this.FullRadioButton.TabIndex = 3;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "Full";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            this.FullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // QueenRadioButton
            // 
            this.QueenRadioButton.AutoSize = true;
            this.QueenRadioButton.Location = new System.Drawing.Point(16, 122);
            this.QueenRadioButton.Name = "QueenRadioButton";
            this.QueenRadioButton.Size = new System.Drawing.Size(82, 24);
            this.QueenRadioButton.TabIndex = 4;
            this.QueenRadioButton.TabStop = true;
            this.QueenRadioButton.Text = "Queen";
            this.QueenRadioButton.UseVisualStyleBackColor = true;
            this.QueenRadioButton.CheckedChanged += new System.EventHandler(this.QueenRadioButton_CheckedChanged);
            // 
            // KingRadioButton
            // 
            this.KingRadioButton.AutoSize = true;
            this.KingRadioButton.Location = new System.Drawing.Point(16, 152);
            this.KingRadioButton.Name = "KingRadioButton";
            this.KingRadioButton.Size = new System.Drawing.Size(65, 24);
            this.KingRadioButton.TabIndex = 5;
            this.KingRadioButton.TabStop = true;
            this.KingRadioButton.Text = "King";
            this.KingRadioButton.UseVisualStyleBackColor = true;
            this.KingRadioButton.CheckedChanged += new System.EventHandler(this.KingRadioButton_CheckedChanged);
            // 
            // BedSizeLabel
            // 
            this.BedSizeLabel.AutoSize = true;
            this.BedSizeLabel.Location = new System.Drawing.Point(12, 9);
            this.BedSizeLabel.Name = "BedSizeLabel";
            this.BedSizeLabel.Size = new System.Drawing.Size(122, 20);
            this.BedSizeLabel.TabIndex = 3;
            this.BedSizeLabel.Text = "Select Bed Size";
            // 
            // RequiredBeddingLabel
            // 
            this.RequiredBeddingLabel.AutoSize = true;
            this.RequiredBeddingLabel.Location = new System.Drawing.Point(176, 9);
            this.RequiredBeddingLabel.Name = "RequiredBeddingLabel";
            this.RequiredBeddingLabel.Size = new System.Drawing.Size(118, 20);
            this.RequiredBeddingLabel.TabIndex = 4;
            this.RequiredBeddingLabel.Text = "Required Items";
            // 
            // BeddingSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 190);
            this.Controls.Add(this.RequiredBeddingLabel);
            this.Controls.Add(this.BedSizeLabel);
            this.Controls.Add(this.BeddingListView);
            this.Controls.Add(this.KingRadioButton);
            this.Controls.Add(this.QueenRadioButton);
            this.Controls.Add(this.FullRadioButton);
            this.Controls.Add(this.XLTwinRadioButton);
            this.Controls.Add(this.TwinRadioButton);
            this.Name = "BeddingSelect";
            this.Text = "Bedding Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton TwinRadioButton;
        private System.Windows.Forms.ListView BeddingListView;
        private System.Windows.Forms.RadioButton XLTwinRadioButton;
        private System.Windows.Forms.RadioButton FullRadioButton;
        private System.Windows.Forms.RadioButton QueenRadioButton;
        private System.Windows.Forms.RadioButton KingRadioButton;
        private System.Windows.Forms.Label BedSizeLabel;
        private System.Windows.Forms.Label RequiredBeddingLabel;
    }
}

