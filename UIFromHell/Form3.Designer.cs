namespace UIFromHell
{
    partial class ForgotPasswordForm
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
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.typingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Location = new System.Drawing.Point(113, 281);
            this.savePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(179, 76);
            this.savePasswordButton.TabIndex = 1;
            this.savePasswordButton.Text = "Save New Password";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(73, 89);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(322, 20);
            this.newPasswordTextBox.TabIndex = 5;
            this.newPasswordTextBox.Text = "placeholdertext";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.Lime;
            this.newPasswordLabel.Location = new System.Drawing.Point(71, 65);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(221, 18);
            this.newPasswordLabel.TabIndex = 6;
            this.newPasswordLabel.Text = "Please type your new password.";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.Lime;
            this.typeLabel.Location = new System.Drawing.Point(71, 188);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(288, 18);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "To prove it\'s you, type the above sentence.";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(74, 209);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(322, 20);
            this.typeTextBox.TabIndex = 7;
            this.typeTextBox.Tag = "";
            // 
            // typingLabel
            // 
            this.typingLabel.AutoSize = true;
            this.typingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingLabel.ForeColor = System.Drawing.Color.Black;
            this.typingLabel.Location = new System.Drawing.Point(69, 140);
            this.typingLabel.Name = "typingLabel";
            this.typingLabel.Size = new System.Drawing.Size(473, 29);
            this.typingLabel.TabIndex = 9;
            this.typingLabel.Text = "The quick brown fox jumps over a lazy dog.";
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.typingLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.savePasswordButton);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savePasswordButton;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label typingLabel;
    }
}