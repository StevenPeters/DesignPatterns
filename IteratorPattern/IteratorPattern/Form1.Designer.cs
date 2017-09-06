namespace IteratorPattern
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
            this.AddGuestTextbox = new System.Windows.Forms.TextBox();
            this.AddGuestLabel = new System.Windows.Forms.Label();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.GuestNameLabel = new System.Windows.Forms.Label();
            this.IterateButton = new System.Windows.Forms.Button();
            this.StartOverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddGuestTextbox
            // 
            this.AddGuestTextbox.Location = new System.Drawing.Point(16, 32);
            this.AddGuestTextbox.Name = "AddGuestTextbox";
            this.AddGuestTextbox.Size = new System.Drawing.Size(100, 26);
            this.AddGuestTextbox.TabIndex = 1;
            this.AddGuestTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddGuestTextbox_KeyDown);
            // 
            // AddGuestLabel
            // 
            this.AddGuestLabel.AutoSize = true;
            this.AddGuestLabel.Location = new System.Drawing.Point(12, 9);
            this.AddGuestLabel.Name = "AddGuestLabel";
            this.AddGuestLabel.Size = new System.Drawing.Size(224, 20);
            this.AddGuestLabel.TabIndex = 0;
            this.AddGuestLabel.Text = "Add Guests To The Guest List";
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestButton.Location = new System.Drawing.Point(136, 32);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(100, 26);
            this.AddGuestButton.TabIndex = 2;
            this.AddGuestButton.Text = "Add";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.DoneButton.Location = new System.Drawing.Point(16, 64);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(220, 26);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // GuestNameLabel
            // 
            this.GuestNameLabel.AutoSize = true;
            this.GuestNameLabel.Location = new System.Drawing.Point(285, 9);
            this.GuestNameLabel.Name = "GuestNameLabel";
            this.GuestNameLabel.Size = new System.Drawing.Size(95, 20);
            this.GuestNameLabel.TabIndex = 0;
            this.GuestNameLabel.Text = "GusetName";
            // 
            // IterateButton
            // 
            this.IterateButton.Enabled = false;
            this.IterateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.IterateButton.Location = new System.Drawing.Point(289, 32);
            this.IterateButton.Name = "IterateButton";
            this.IterateButton.Size = new System.Drawing.Size(100, 26);
            this.IterateButton.TabIndex = 4;
            this.IterateButton.Text = "Iterate";
            this.IterateButton.UseVisualStyleBackColor = true;
            this.IterateButton.Click += new System.EventHandler(this.IterateButton_Click);
            // 
            // StartOverButton
            // 
            this.StartOverButton.Enabled = false;
            this.StartOverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.StartOverButton.Location = new System.Drawing.Point(289, 64);
            this.StartOverButton.Name = "StartOverButton";
            this.StartOverButton.Size = new System.Drawing.Size(100, 26);
            this.StartOverButton.TabIndex = 5;
            this.StartOverButton.Text = "Start Over";
            this.StartOverButton.UseVisualStyleBackColor = true;
            this.StartOverButton.Click += new System.EventHandler(this.StartOverButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 107);
            this.Controls.Add(this.StartOverButton);
            this.Controls.Add(this.IterateButton);
            this.Controls.Add(this.GuestNameLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.AddGuestLabel);
            this.Controls.Add(this.AddGuestTextbox);
            this.Name = "Form1";
            this.Text = "Iterator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddGuestTextbox;
        private System.Windows.Forms.Label AddGuestLabel;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label GuestNameLabel;
        private System.Windows.Forms.Button IterateButton;
        private System.Windows.Forms.Button StartOverButton;
    }
}

