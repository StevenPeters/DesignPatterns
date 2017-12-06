namespace Composite_Pattern
{
    partial class CompositeForm
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
            this.CompositeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CompositeListBox
            // 
            this.CompositeListBox.FormattingEnabled = true;
            this.CompositeListBox.ItemHeight = 20;
            this.CompositeListBox.Location = new System.Drawing.Point(12, 12);
            this.CompositeListBox.Name = "CompositeListBox";
            this.CompositeListBox.Size = new System.Drawing.Size(324, 344);
            this.CompositeListBox.TabIndex = 0;
            // 
            // CompositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 367);
            this.Controls.Add(this.CompositeListBox);
            this.Name = "CompositeForm";
            this.Text = "Composite Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CompositeListBox;
    }
}

