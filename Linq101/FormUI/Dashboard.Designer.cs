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
            this.titleLabel = new System.Windows.Forms.Label();
            this.allPeopleLabel = new System.Windows.Forms.Label();
            this.filteredListLabel = new System.Windows.Forms.Label();
            this.yearsExperienceLabel = new System.Windows.Forms.Label();
            this.updatePersonButton = new System.Windows.Forms.Button();
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.yearsExperienceUpDown = new System.Windows.Forms.NumericUpDown();
            this.AllPeopleDropDown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(153, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linq Demo";
            // 
            // allPeopleLabel
            // 
            this.allPeopleLabel.AutoSize = true;
            this.allPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPeopleLabel.Location = new System.Drawing.Point(35, 72);
            this.allPeopleLabel.Name = "allPeopleLabel";
            this.allPeopleLabel.Size = new System.Drawing.Size(109, 25);
            this.allPeopleLabel.TabIndex = 1;
            this.allPeopleLabel.Text = "All People";
            // 
            // filteredListLabel
            // 
            this.filteredListLabel.AutoSize = true;
            this.filteredListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredListLabel.Location = new System.Drawing.Point(291, 72);
            this.filteredListLabel.Name = "filteredListLabel";
            this.filteredListLabel.Size = new System.Drawing.Size(124, 25);
            this.filteredListLabel.TabIndex = 2;
            this.filteredListLabel.Text = "Filtered List";
            // 
            // yearsExperienceLabel
            // 
            this.yearsExperienceLabel.AutoSize = true;
            this.yearsExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsExperienceLabel.Location = new System.Drawing.Point(35, 171);
            this.yearsExperienceLabel.Name = "yearsExperienceLabel";
            this.yearsExperienceLabel.Size = new System.Drawing.Size(183, 25);
            this.yearsExperienceLabel.TabIndex = 3;
            this.yearsExperienceLabel.Text = "Years Experience";
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePersonButton.Location = new System.Drawing.Point(90, 297);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(151, 57);
            this.updatePersonButton.TabIndex = 4;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = true;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 24;
            this.filteredPeopleList.Location = new System.Drawing.Point(296, 101);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(281, 244);
            this.filteredPeopleList.TabIndex = 5;
            // 
            // yearsExperienceUpDown
            // 
            this.yearsExperienceUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsExperienceUpDown.Location = new System.Drawing.Point(40, 200);
            this.yearsExperienceUpDown.Name = "yearsExperienceUpDown";
            this.yearsExperienceUpDown.Size = new System.Drawing.Size(58, 31);
            this.yearsExperienceUpDown.TabIndex = 6;
            // 
            // AllPeopleDropDown
            // 
            this.AllPeopleDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPeopleDropDown.FormattingEnabled = true;
            this.AllPeopleDropDown.Location = new System.Drawing.Point(40, 101);
            this.AllPeopleDropDown.Name = "AllPeopleDropDown";
            this.AllPeopleDropDown.Size = new System.Drawing.Size(201, 33);
            this.AllPeopleDropDown.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 380);
            this.Controls.Add(this.AllPeopleDropDown);
            this.Controls.Add(this.yearsExperienceUpDown);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.yearsExperienceLabel);
            this.Controls.Add(this.filteredListLabel);
            this.Controls.Add(this.allPeopleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperienceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label allPeopleLabel;
        private System.Windows.Forms.Label filteredListLabel;
        private System.Windows.Forms.Label yearsExperienceLabel;
        private System.Windows.Forms.Button updatePersonButton;
        private System.Windows.Forms.ListBox filteredPeopleList;
        private System.Windows.Forms.NumericUpDown yearsExperienceUpDown;
        private System.Windows.Forms.ComboBox AllPeopleDropDown;
    }
}