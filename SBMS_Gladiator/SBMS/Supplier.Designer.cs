namespace SBMS
{
    partial class Supplier
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
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.supplierGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(410, 50);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(281, 31);
            this.codeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(410, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(281, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(410, 138);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(281, 31);
            this.addressTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(410, 182);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(281, 31);
            this.emailTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(410, 226);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(281, 31);
            this.contactTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact Person";
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(410, 270);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(281, 31);
            this.contactPersonTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(567, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 49);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // supplierGridView
            // 
            this.supplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView.Location = new System.Drawing.Point(63, 423);
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.RowTemplate.Height = 33;
            this.supplierGridView.Size = new System.Drawing.Size(840, 213);
            this.supplierGridView.TabIndex = 7;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 688);
            this.Controls.Add(this.supplierGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Supplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView supplierGridView;
    }
}