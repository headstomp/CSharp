namespace MathServiceTestApp1
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
            this.textBoxNum2 = new System.Windows.Forms.TextBox();
            this.textBoxNum1 = new System.Windows.Forms.TextBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonNewProxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNum2
            // 
            this.textBoxNum2.Location = new System.Drawing.Point(85, 34);
            this.textBoxNum2.Name = "textBoxNum2";
            this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum2.TabIndex = 0;
            // 
            // textBoxNum1
            // 
            this.textBoxNum1.Location = new System.Drawing.Point(85, 6);
            this.textBoxNum1.Name = "textBoxNum1";
            this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNum1.TabIndex = 1;
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(12, 37);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(68, 13);
            this.labelNum2.TabIndex = 2;
            this.labelNum2.Text = "Number Two";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(12, 9);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(67, 13);
            this.labelNum1.TabIndex = 3;
            this.labelNum1.Text = "Number One";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.comboBoxOperator.Location = new System.Drawing.Point(202, 6);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperator.TabIndex = 4;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(202, 30);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(121, 23);
            this.buttonCalc.TabIndex = 5;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(85, 74);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(238, 20);
            this.textBoxResult.TabIndex = 6;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(22, 99);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 7;
            // 
            // buttonNewProxy
            // 
            this.buttonNewProxy.Location = new System.Drawing.Point(88, 124);
            this.buttonNewProxy.Name = "buttonNewProxy";
            this.buttonNewProxy.Size = new System.Drawing.Size(192, 23);
            this.buttonNewProxy.TabIndex = 8;
            this.buttonNewProxy.Text = "Create New Proxy";
            this.buttonNewProxy.UseVisualStyleBackColor = true;
            this.buttonNewProxy.Click += new System.EventHandler(this.buttonNewProxy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 162);
            this.Controls.Add(this.buttonNewProxy);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.textBoxNum1);
            this.Controls.Add(this.textBoxNum2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonNewProxy;
    }
}

