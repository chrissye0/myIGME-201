namespace PE17NumberGuessingGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.lowRangeLabel = new System.Windows.Forms.Label();
            this.highRangeLabel = new System.Windows.Forms.Label();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(120, 120);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(60, 20);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(168, 13);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Enter a Range of Values to Guess";
            // 
            // lowRangeLabel
            // 
            this.lowRangeLabel.AutoSize = true;
            this.lowRangeLabel.Location = new System.Drawing.Point(21, 52);
            this.lowRangeLabel.Name = "lowRangeLabel";
            this.lowRangeLabel.Size = new System.Drawing.Size(70, 13);
            this.lowRangeLabel.TabIndex = 2;
            this.lowRangeLabel.Text = "Low Number:";
            // 
            // highRangeLabel
            // 
            this.highRangeLabel.AutoSize = true;
            this.highRangeLabel.Location = new System.Drawing.Point(21, 80);
            this.highRangeLabel.Name = "highRangeLabel";
            this.highRangeLabel.Size = new System.Drawing.Size(72, 13);
            this.highRangeLabel.TabIndex = 3;
            this.highRangeLabel.Text = "High Number:";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(107, 49);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowTextBox.TabIndex = 4;
            this.lowTextBox.Text = "1";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(107, 80);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 20);
            this.highTextBox.TabIndex = 5;
            this.highTextBox.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.highRangeLabel);
            this.Controls.Add(this.lowRangeLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label lowRangeLabel;
        private System.Windows.Forms.Label highRangeLabel;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
    }
}

