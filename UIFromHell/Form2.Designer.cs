namespace UIFromHell
{
    partial class SignUpForm
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
            this.components = new System.ComponentModel.Container();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signUpGroupBox = new System.Windows.Forms.GroupBox();
            this.newsletterCheckbox = new System.Windows.Forms.CheckBox();
            this.emailCheckbox = new System.Windows.Forms.CheckBox();
            this.messagingCheckbox = new System.Windows.Forms.CheckBox();
            this.personalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.checkForALabel = new System.Windows.Forms.Label();
            this.checkForELabel = new System.Windows.Forms.Label();
            this.checkForILabel = new System.Windows.Forms.Label();
            this.checkForULabel = new System.Windows.Forms.Label();
            this.checkForOLabel = new System.Windows.Forms.Label();
            this.passwordLengthCheckLabel = new System.Windows.Forms.Label();
            this.passwordSpecialCharacterCheckLabel = new System.Windows.Forms.Label();
            this.personalDataYesRB = new System.Windows.Forms.RadioButton();
            this.personalDataNoRB = new System.Windows.Forms.RadioButton();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.signUpFormTimer = new System.Windows.Forms.Timer(this.components);
            this.signUpFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.timerLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.personalDataRBCheckerLabel = new System.Windows.Forms.Label();
            this.signUpGroupBox.SuspendLayout();
            this.personalDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Red;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Lime;
            this.usernameLabel.Location = new System.Drawing.Point(74, 79);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 24);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(177, 84);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(276, 20);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.Text = "placeholdertextplaceholdertextplaceholdertextplaceholdertext";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Red;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordLabel.Location = new System.Drawing.Point(74, 209);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(177, 214);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(276, 20);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.Text = "placeholdertextplaceholdertextplaceholdertextplaceholdertext";
            // 
            // signUpGroupBox
            // 
            this.signUpGroupBox.BackColor = System.Drawing.Color.White;
            this.signUpGroupBox.Controls.Add(this.messagingCheckbox);
            this.signUpGroupBox.Controls.Add(this.emailCheckbox);
            this.signUpGroupBox.Controls.Add(this.newsletterCheckbox);
            this.signUpGroupBox.Location = new System.Drawing.Point(538, 84);
            this.signUpGroupBox.Name = "signUpGroupBox";
            this.signUpGroupBox.Size = new System.Drawing.Size(200, 117);
            this.signUpGroupBox.TabIndex = 11;
            this.signUpGroupBox.TabStop = false;
            this.signUpGroupBox.Text = "Sign Up";
            // 
            // newsletterCheckbox
            // 
            this.newsletterCheckbox.AutoSize = true;
            this.newsletterCheckbox.ForeColor = System.Drawing.Color.Red;
            this.newsletterCheckbox.Location = new System.Drawing.Point(17, 30);
            this.newsletterCheckbox.Name = "newsletterCheckbox";
            this.newsletterCheckbox.Size = new System.Drawing.Size(146, 17);
            this.newsletterCheckbox.TabIndex = 0;
            this.newsletterCheckbox.Text = "Sign up for our newsletter";
            this.newsletterCheckbox.UseVisualStyleBackColor = true;
            // 
            // emailCheckbox
            // 
            this.emailCheckbox.AutoSize = true;
            this.emailCheckbox.ForeColor = System.Drawing.Color.Red;
            this.emailCheckbox.Location = new System.Drawing.Point(17, 53);
            this.emailCheckbox.Name = "emailCheckbox";
            this.emailCheckbox.Size = new System.Drawing.Size(145, 17);
            this.emailCheckbox.TabIndex = 1;
            this.emailCheckbox.Text = "Sign up for weekly emails";
            this.emailCheckbox.UseVisualStyleBackColor = true;
            // 
            // messagingCheckbox
            // 
            this.messagingCheckbox.AutoSize = true;
            this.messagingCheckbox.ForeColor = System.Drawing.Color.Red;
            this.messagingCheckbox.Location = new System.Drawing.Point(17, 76);
            this.messagingCheckbox.Name = "messagingCheckbox";
            this.messagingCheckbox.Size = new System.Drawing.Size(156, 17);
            this.messagingCheckbox.TabIndex = 2;
            this.messagingCheckbox.Text = "Sign up for SMS messaging";
            this.messagingCheckbox.UseVisualStyleBackColor = true;
            // 
            // personalDataGroupBox
            // 
            this.personalDataGroupBox.BackColor = System.Drawing.Color.White;
            this.personalDataGroupBox.Controls.Add(this.personalDataNoRB);
            this.personalDataGroupBox.Controls.Add(this.personalDataYesRB);
            this.personalDataGroupBox.Location = new System.Drawing.Point(78, 272);
            this.personalDataGroupBox.Name = "personalDataGroupBox";
            this.personalDataGroupBox.Size = new System.Drawing.Size(176, 74);
            this.personalDataGroupBox.TabIndex = 12;
            this.personalDataGroupBox.TabStop = false;
            this.personalDataGroupBox.Text = "Can we use your personal data?";
            // 
            // checkForALabel
            // 
            this.checkForALabel.AutoSize = true;
            this.checkForALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForALabel.ForeColor = System.Drawing.Color.Lime;
            this.checkForALabel.Location = new System.Drawing.Point(75, 117);
            this.checkForALabel.Name = "checkForALabel";
            this.checkForALabel.Size = new System.Drawing.Size(207, 16);
            this.checkForALabel.TabIndex = 0;
            this.checkForALabel.Text = "Your username cannot have an A.";
            this.checkForALabel.Visible = false;
            // 
            // checkForELabel
            // 
            this.checkForELabel.AutoSize = true;
            this.checkForELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForELabel.ForeColor = System.Drawing.Color.Lime;
            this.checkForELabel.Location = new System.Drawing.Point(75, 145);
            this.checkForELabel.Name = "checkForELabel";
            this.checkForELabel.Size = new System.Drawing.Size(207, 16);
            this.checkForELabel.TabIndex = 13;
            this.checkForELabel.Text = "Your username cannot have an E.";
            this.checkForELabel.Visible = false;
            // 
            // checkForILabel
            // 
            this.checkForILabel.AutoSize = true;
            this.checkForILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForILabel.ForeColor = System.Drawing.Color.Lime;
            this.checkForILabel.Location = new System.Drawing.Point(75, 173);
            this.checkForILabel.Name = "checkForILabel";
            this.checkForILabel.Size = new System.Drawing.Size(201, 16);
            this.checkForILabel.TabIndex = 14;
            this.checkForILabel.Text = "Your username cannot have an I.";
            this.checkForILabel.Visible = false;
            // 
            // checkForULabel
            // 
            this.checkForULabel.AutoSize = true;
            this.checkForULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForULabel.ForeColor = System.Drawing.Color.Lime;
            this.checkForULabel.Location = new System.Drawing.Point(288, 144);
            this.checkForULabel.Name = "checkForULabel";
            this.checkForULabel.Size = new System.Drawing.Size(201, 16);
            this.checkForULabel.TabIndex = 16;
            this.checkForULabel.Text = "Your username cannot have a U.";
            this.checkForULabel.Visible = false;
            // 
            // checkForOLabel
            // 
            this.checkForOLabel.AutoSize = true;
            this.checkForOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkForOLabel.ForeColor = System.Drawing.Color.Lime;
            this.checkForOLabel.Location = new System.Drawing.Point(288, 116);
            this.checkForOLabel.Name = "checkForOLabel";
            this.checkForOLabel.Size = new System.Drawing.Size(208, 16);
            this.checkForOLabel.TabIndex = 15;
            this.checkForOLabel.Text = "Your username cannot have an O.";
            this.checkForOLabel.Visible = false;
            // 
            // passwordLengthCheckLabel
            // 
            this.passwordLengthCheckLabel.AutoSize = true;
            this.passwordLengthCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthCheckLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordLengthCheckLabel.Location = new System.Drawing.Point(75, 245);
            this.passwordLengthCheckLabel.Name = "passwordLengthCheckLabel";
            this.passwordLengthCheckLabel.Size = new System.Drawing.Size(285, 16);
            this.passwordLengthCheckLabel.TabIndex = 17;
            this.passwordLengthCheckLabel.Text = "Your password must be 10 characters in length.";
            this.passwordLengthCheckLabel.Visible = false;
            // 
            // passwordSpecialCharacterCheckLabel
            // 
            this.passwordSpecialCharacterCheckLabel.AutoSize = true;
            this.passwordSpecialCharacterCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSpecialCharacterCheckLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordSpecialCharacterCheckLabel.Location = new System.Drawing.Point(395, 245);
            this.passwordSpecialCharacterCheckLabel.Name = "passwordSpecialCharacterCheckLabel";
            this.passwordSpecialCharacterCheckLabel.Size = new System.Drawing.Size(0, 16);
            this.passwordSpecialCharacterCheckLabel.TabIndex = 18;
            // 
            // personalDataYesRB
            // 
            this.personalDataYesRB.AutoSize = true;
            this.personalDataYesRB.ForeColor = System.Drawing.Color.Red;
            this.personalDataYesRB.Location = new System.Drawing.Point(24, 33);
            this.personalDataYesRB.Name = "personalDataYesRB";
            this.personalDataYesRB.Size = new System.Drawing.Size(43, 17);
            this.personalDataYesRB.TabIndex = 19;
            this.personalDataYesRB.TabStop = true;
            this.personalDataYesRB.Text = "Yes";
            this.personalDataYesRB.UseVisualStyleBackColor = true;
            // 
            // personalDataNoRB
            // 
            this.personalDataNoRB.AutoSize = true;
            this.personalDataNoRB.ForeColor = System.Drawing.Color.Red;
            this.personalDataNoRB.Location = new System.Drawing.Point(88, 33);
            this.personalDataNoRB.Name = "personalDataNoRB";
            this.personalDataNoRB.Size = new System.Drawing.Size(39, 17);
            this.personalDataNoRB.TabIndex = 21;
            this.personalDataNoRB.TabStop = true;
            this.personalDataNoRB.Text = "No";
            this.personalDataNoRB.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.ForeColor = System.Drawing.Color.Black;
            this.createAccountButton.Location = new System.Drawing.Point(282, 276);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createAccountButton.Size = new System.Drawing.Size(420, 74);
            this.createAccountButton.TabIndex = 19;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            // 
            // signUpFormProgressBar
            // 
            this.signUpFormProgressBar.Location = new System.Drawing.Point(6, 423);
            this.signUpFormProgressBar.Maximum = 600;
            this.signUpFormProgressBar.Name = "signUpFormProgressBar";
            this.signUpFormProgressBar.Size = new System.Drawing.Size(788, 23);
            this.signUpFormProgressBar.TabIndex = 20;
            this.signUpFormProgressBar.Value = 600;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Lime;
            this.timerLabel.Location = new System.Drawing.Point(73, 386);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(674, 25);
            this.timerLabel.TabIndex = 10;
            this.timerLabel.Text = "To prevent idling, please fill your information in less than 60 seconds.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // personalDataRBCheckerLabel
            // 
            this.personalDataRBCheckerLabel.AutoSize = true;
            this.personalDataRBCheckerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalDataRBCheckerLabel.ForeColor = System.Drawing.Color.Lime;
            this.personalDataRBCheckerLabel.Location = new System.Drawing.Point(99, 349);
            this.personalDataRBCheckerLabel.Name = "personalDataRBCheckerLabel";
            this.personalDataRBCheckerLabel.Size = new System.Drawing.Size(0, 16);
            this.personalDataRBCheckerLabel.TabIndex = 22;
            this.personalDataRBCheckerLabel.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personalDataRBCheckerLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.signUpFormProgressBar);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.passwordSpecialCharacterCheckLabel);
            this.Controls.Add(this.passwordLengthCheckLabel);
            this.Controls.Add(this.checkForULabel);
            this.Controls.Add(this.checkForOLabel);
            this.Controls.Add(this.checkForILabel);
            this.Controls.Add(this.checkForELabel);
            this.Controls.Add(this.checkForALabel);
            this.Controls.Add(this.personalDataGroupBox);
            this.Controls.Add(this.signUpGroupBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.signUpGroupBox.ResumeLayout(false);
            this.signUpGroupBox.PerformLayout();
            this.personalDataGroupBox.ResumeLayout(false);
            this.personalDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox signUpGroupBox;
        private System.Windows.Forms.CheckBox messagingCheckbox;
        private System.Windows.Forms.CheckBox emailCheckbox;
        private System.Windows.Forms.CheckBox newsletterCheckbox;
        private System.Windows.Forms.GroupBox personalDataGroupBox;
        private System.Windows.Forms.Label checkForALabel;
        private System.Windows.Forms.Label checkForELabel;
        private System.Windows.Forms.Label checkForILabel;
        private System.Windows.Forms.Label checkForULabel;
        private System.Windows.Forms.Label checkForOLabel;
        private System.Windows.Forms.Label passwordLengthCheckLabel;
        private System.Windows.Forms.Label passwordSpecialCharacterCheckLabel;
        private System.Windows.Forms.RadioButton personalDataNoRB;
        private System.Windows.Forms.RadioButton personalDataYesRB;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Timer signUpFormTimer;
        private System.Windows.Forms.ProgressBar signUpFormProgressBar;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label personalDataRBCheckerLabel;
    }
}