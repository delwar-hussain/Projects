namespace SBMS
{
    partial class Customer
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
            this.loyaltyTextBox = new System.Windows.Forms.TextBox();
            this.custmerGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.custmerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(360, 42);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(263, 31);
            this.codeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(360, 86);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(263, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(360, 130);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(263, 31);
            this.addressTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(360, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(263, 31);
            this.emailTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(360, 218);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(263, 31);
            this.contactTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loyalty Point";
            // 
            // loyaltyTextBox
            // 
            this.loyaltyTextBox.Location = new System.Drawing.Point(360, 265);
            this.loyaltyTextBox.Name = "loyaltyTextBox";
            this.loyaltyTextBox.Size = new System.Drawing.Size(263, 31);
            this.loyaltyTextBox.TabIndex = 5;
            // 
            // custmerGridView
            // 
            this.custmerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custmerGridView.Location = new System.Drawing.Point(42, 405);
            this.custmerGridView.Name = "custmerGridView";
            this.custmerGridView.RowTemplate.Height = 33;
            this.custmerGridView.Size = new System.Drawing.Size(843, 195);
            this.custmerGridView.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(499, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 43);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 632);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.custmerGridView);
            this.Controls.Add(this.loyaltyTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.custmerGridView)).EndInit();
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
        private System.Windows.Forms.TextBox loyaltyTextBox;
        private System.Windows.Forms.DataGridView custmerGridView;
        private System.Windows.Forms.Button saveButton;
    }
}