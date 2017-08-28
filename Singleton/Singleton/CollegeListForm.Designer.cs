namespace CollegeList
{
    partial class CollegeListForm
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
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemAdd = new System.Windows.Forms.Button();
            this.ItemVehicle = new System.Windows.Forms.RadioButton();
            this.ItemRemove = new System.Windows.Forms.Button();
            this.ItemDorm = new System.Windows.Forms.RadioButton();
            this.ItemClass = new System.Windows.Forms.RadioButton();
            this.CollegeListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(50, 50);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(150, 26);
            this.ItemName.TabIndex = 1;
            // 
            // ItemAdd
            // 
            this.ItemAdd.Location = new System.Drawing.Point(250, 74);
            this.ItemAdd.Name = "ItemAdd";
            this.ItemAdd.Size = new System.Drawing.Size(100, 30);
            this.ItemAdd.TabIndex = 5;
            this.ItemAdd.Text = "Add";
            this.ItemAdd.UseVisualStyleBackColor = true;
            this.ItemAdd.Click += new System.EventHandler(this.ItemAdd_Click);
            // 
            // ItemVehicle
            // 
            this.ItemVehicle.AutoSize = true;
            this.ItemVehicle.Location = new System.Drawing.Point(50, 101);
            this.ItemVehicle.Name = "ItemVehicle";
            this.ItemVehicle.Size = new System.Drawing.Size(86, 24);
            this.ItemVehicle.TabIndex = 2;
            this.ItemVehicle.TabStop = true;
            this.ItemVehicle.Text = "Vehicle";
            this.ItemVehicle.UseVisualStyleBackColor = true;
            // 
            // ItemRemove
            // 
            this.ItemRemove.Location = new System.Drawing.Point(250, 129);
            this.ItemRemove.Name = "ItemRemove";
            this.ItemRemove.Size = new System.Drawing.Size(100, 30);
            this.ItemRemove.TabIndex = 6;
            this.ItemRemove.Text = "Remove";
            this.ItemRemove.UseVisualStyleBackColor = true;
            this.ItemRemove.Click += new System.EventHandler(this.ItemRemove_Click);
            // 
            // ItemDorm
            // 
            this.ItemDorm.AutoSize = true;
            this.ItemDorm.Location = new System.Drawing.Point(50, 130);
            this.ItemDorm.Name = "ItemDorm";
            this.ItemDorm.Size = new System.Drawing.Size(109, 24);
            this.ItemDorm.TabIndex = 3;
            this.ItemDorm.TabStop = true;
            this.ItemDorm.Text = "Dorm Item";
            this.ItemDorm.UseVisualStyleBackColor = true;
            // 
            // ItemClass
            // 
            this.ItemClass.AutoSize = true;
            this.ItemClass.Location = new System.Drawing.Point(50, 159);
            this.ItemClass.Name = "ItemClass";
            this.ItemClass.Size = new System.Drawing.Size(109, 24);
            this.ItemClass.TabIndex = 4;
            this.ItemClass.TabStop = true;
            this.ItemClass.Text = "Class Item";
            this.ItemClass.UseVisualStyleBackColor = true;
            // 
            // CollegeListView
            // 
            this.CollegeListView.HideSelection = false;
            this.CollegeListView.Location = new System.Drawing.Point(400, 50);
            this.CollegeListView.Name = "CollegeListView";
            this.CollegeListView.Size = new System.Drawing.Size(150, 133);
            this.CollegeListView.TabIndex = 7;
            this.CollegeListView.UseCompatibleStateImageBehavior = false;
            this.CollegeListView.View = System.Windows.Forms.View.List;
            // 
            // CollegeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 233);
            this.Controls.Add(this.ItemClass);
            this.Controls.Add(this.ItemDorm);
            this.Controls.Add(this.ItemVehicle);
            this.Controls.Add(this.CollegeListView);
            this.Controls.Add(this.ItemRemove);
            this.Controls.Add(this.ItemAdd);
            this.Controls.Add(this.ItemName);
            this.Name = "CollegeListForm";
            this.Text = "CollegeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Button ItemAdd;
        private System.Windows.Forms.RadioButton ItemVehicle;
        private System.Windows.Forms.Button ItemRemove;
        private System.Windows.Forms.RadioButton ItemDorm;
        private System.Windows.Forms.RadioButton ItemClass;
        private System.Windows.Forms.ListView CollegeListView;
    }
}

