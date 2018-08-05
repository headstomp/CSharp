namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInstLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.emailInsLabel = new System.Windows.Forms.Label();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.phoneInslabel = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 25;
            this.peopleFoundListBox.Location = new System.Drawing.Point(12, 122);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(490, 304);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(134, 26);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(175, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 32);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 63);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(32, 495);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameInsLabel.TabIndex = 5;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(153, 489);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(175, 31);
            this.firstNameInsText.TabIndex = 4;
            // 
            // lastNameInstLabel
            // 
            this.lastNameInstLabel.AutoSize = true;
            this.lastNameInstLabel.Location = new System.Drawing.Point(32, 532);
            this.lastNameInstLabel.Name = "lastNameInstLabel";
            this.lastNameInstLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameInstLabel.TabIndex = 7;
            this.lastNameInstLabel.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(153, 526);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(175, 31);
            this.lastNameInsText.TabIndex = 6;
            // 
            // emailInsLabel
            // 
            this.emailInsLabel.AutoSize = true;
            this.emailInsLabel.Location = new System.Drawing.Point(32, 569);
            this.emailInsLabel.Name = "emailInsLabel";
            this.emailInsLabel.Size = new System.Drawing.Size(65, 25);
            this.emailInsLabel.TabIndex = 9;
            this.emailInsLabel.Text = "Email";
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(153, 563);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(175, 31);
            this.emailInsText.TabIndex = 8;
            // 
            // phoneInslabel
            // 
            this.phoneInslabel.AutoSize = true;
            this.phoneInslabel.Location = new System.Drawing.Point(32, 606);
            this.phoneInslabel.Name = "phoneInslabel";
            this.phoneInslabel.Size = new System.Drawing.Size(74, 25);
            this.phoneInslabel.TabIndex = 11;
            this.phoneInslabel.Text = "Phone";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(153, 600);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(175, 31);
            this.phoneInsText.TabIndex = 10;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(206, 637);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(122, 36);
            this.insertButton.TabIndex = 12;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 738);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.phoneInslabel);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.emailInsLabel);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.lastNameInstLabel);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInstLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label emailInsLabel;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Label phoneInslabel;
        private System.Windows.Forms.TextBox phoneInsText;
        private System.Windows.Forms.Button insertButton;
    }
}

