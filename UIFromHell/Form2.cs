using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    // Author: Christine Espeleta
    // Purpose: Sign Up form. There is a timer and various absurd criteria for username and password inputs.
    // Restrictions: N/A

    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.createAccountButton.Enabled = true;
            this.createAccountButton.Click += new EventHandler(this.CreateAccountButton__Click);
            this.signUpFormTimer.Enabled = true;
            this.signUpFormTimer.Start();
            this.signUpFormTimer.Tick += new EventHandler(this.Timer__Tick);
        }

        // timer tick event handler
        // change progress bar
        private void Timer__Tick(object sender, EventArgs e)
        {
            // if progress bar didn't run out
            if (this.signUpFormProgressBar.Value > 0)
            {
                // subtract from progress bar
                this.signUpFormProgressBar.Value--;
            }
            else
            {
                // otherwise stop timer, display Message Box, and close form if Message Box is closed
                this.signUpFormTimer.Stop();
                MessageBox.Show("Better luck next time!");
                this.Close();
            }
        }

        // create account button click event handler
        // check different text boxes, display labels depending on input
        private void CreateAccountButton__Click(object sender, EventArgs e)
        {
            // make errors and labels not enabled and not visible
            this.checkForALabel.Enabled = false;
            this.checkForALabel.Visible = false;

            this.checkForELabel.Enabled = false;
            this.checkForELabel.Visible = false;

            this.checkForILabel.Enabled = false;
            this.checkForILabel.Visible = false;

            this.checkForOLabel.Enabled = false;
            this.checkForOLabel.Visible = false;

            this.checkForULabel.Enabled = false;
            this.checkForULabel.Visible = false;

            this.passwordLengthCheckLabel.Enabled = false;
            this.passwordLengthCheckLabel.Visible = false;

            // display error messages depending on input

            // if username has an a
            if (this.usernameTextBox.Text.Contains("a") || this.usernameTextBox.Text.Contains("A"))
            {
                this.checkForALabel.Enabled = true;
                this.checkForALabel.Visible = true;
            }
            // if username has an e
            if (this.usernameTextBox.Text.Contains("e") || this.usernameTextBox.Text.Contains("E"))
            {
                this.checkForELabel.Enabled = true;
                this.checkForELabel.Visible = true;
            }
            // if username has an i
            if (this.usernameTextBox.Text.Contains("i") || this.usernameTextBox.Text.Contains("I"))
            {
                this.checkForILabel.Enabled = true;
                this.checkForILabel.Visible = true;
            }
            // if username has an o
            if (this.usernameTextBox.Text.Contains("o") || this.usernameTextBox.Text.Contains("O"))
            {
                this.checkForOLabel.Enabled = true;
                this.checkForOLabel.Visible = true;
            }
            // if username has a u
            if (this.usernameTextBox.Text.Contains("u") || this.usernameTextBox.Text.Contains("U"))
            {
                this.checkForULabel.Enabled = true;
                this.checkForULabel.Visible = true;
            }
            // if password length is not 10
            if (this.passwordTextBox.Text.Length != 10)
            {
                this.passwordLengthCheckLabel.Enabled = true;
                this.passwordLengthCheckLabel.Visible = true;
            }
            // if person doesn't select a radio button or selects no
            if (this.personalDataNoRB.Checked || !this.personalDataYesRB.Checked)
            {
                this.errorProvider1.SetError(this.personalDataGroupBox, "Please select yes.");
            }
            else
            {
                this.errorProvider1.SetError(this.personalDataGroupBox, "");
            }
            // if not all checkboxes are checked
            if (!this.newsletterCheckbox.Checked || !this.emailCheckbox.Checked || !this.messagingCheckbox.Checked)
            {
                this.errorProvider1.SetError(this.signUpGroupBox, "Please check all checkboxes.");
            }
            else
            {
                this.errorProvider1.SetError(this.signUpGroupBox, "");
            }

            // check all conditions
            if (!this.checkForALabel.Visible && !this.checkForELabel.Visible && !this.checkForILabel.Visible && !this.checkForOLabel.Visible && !this.checkForULabel.Visible && !this.passwordLengthCheckLabel.Visible && this.personalDataYesRB.Checked && this.newsletterCheckbox.Checked && this.emailCheckbox.Checked && this.messagingCheckbox.Checked)
            {
                // open main form
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        } 
    }
}
