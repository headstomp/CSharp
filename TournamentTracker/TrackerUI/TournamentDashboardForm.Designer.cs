namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadTournamentDropDown = new System.Windows.Forms.TextBox();
            this.loadTournamentLabel = new System.Windows.Forms.Label();
            this.loadTouramentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(129, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(385, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Tournament Dashboard";
            this.headerLabel.UseWaitCursor = true;
            // 
            // loadTournamentDropDown
            // 
            this.loadTournamentDropDown.Location = new System.Drawing.Point(133, 130);
            this.loadTournamentDropDown.Name = "loadTournamentDropDown";
            this.loadTournamentDropDown.Size = new System.Drawing.Size(357, 35);
            this.loadTournamentDropDown.TabIndex = 12;
            this.loadTournamentDropDown.UseWaitCursor = true;
            // 
            // loadTournamentLabel
            // 
            this.loadTournamentLabel.AutoSize = true;
            this.loadTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentLabel.Location = new System.Drawing.Point(150, 90);
            this.loadTournamentLabel.Name = "loadTournamentLabel";
            this.loadTournamentLabel.Size = new System.Drawing.Size(322, 37);
            this.loadTournamentLabel.TabIndex = 11;
            this.loadTournamentLabel.Text = "Load Existing Tournament";
            this.loadTournamentLabel.UseWaitCursor = true;
            // 
            // loadTouramentButton
            // 
            this.loadTouramentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTouramentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTouramentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTouramentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTouramentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTouramentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTouramentButton.Location = new System.Drawing.Point(192, 180);
            this.loadTouramentButton.Name = "loadTouramentButton";
            this.loadTouramentButton.Size = new System.Drawing.Size(239, 47);
            this.loadTouramentButton.TabIndex = 17;
            this.loadTouramentButton.Text = "Load Tournament";
            this.loadTouramentButton.UseVisualStyleBackColor = true;
            this.loadTouramentButton.UseWaitCursor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(128, 266);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(366, 73);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.UseWaitCursor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 371);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTouramentButton);
            this.Controls.Add(this.loadTournamentDropDown);
            this.Controls.Add(this.loadTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox loadTournamentDropDown;
        private System.Windows.Forms.Label loadTournamentLabel;
        private System.Windows.Forms.Button loadTouramentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}