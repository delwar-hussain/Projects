namespace SBMS
{
    partial class Category
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
            this.categoryCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // categoryCodeTextBox
            // 
            this.categoryCodeTextBox.Location = new System.Drawing.Point(268, 42);
            this.categoryCodeTextBox.Name = "categoryCodeTextBox";
            this.categoryCodeTextBox.Size = new System.Drawing.Size(202, 31);
            this.categoryCodeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(268, 95);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(202, 31);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(348, 148);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 41);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // categoryGridView
            // 
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(38, 247);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowTemplate.Height = 33;
            this.categoryGridView.Size = new System.Drawing.Size(599, 150);
            this.categoryGridView.TabIndex = 3;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryCodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Category";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView categoryGridView;
    }
}