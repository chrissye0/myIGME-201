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
    public partial class MainForm : Form
    {
        // Author: Christine Espeleta
        // Purpose: The main form of this application.
        // The theme was based on absurd and difficult to navigate website sign up/log in pages. There are a lot of "tests" for user inputs, such as checking for specific characters, input length, and so forth that make the forms annoying.
        // Restrictions: N/A

        public MainForm()
        {
            InitializeComponent();
            this.loginButton.Enabled = true;
            this.loginButton.Click += new EventHandler(this.LoginButton__Click);
            this.signUpButton.Enabled = true;
            this.signUpButton.Click += new EventHandler(this.SignUpButton__Click);
            this.forgotPasswordButton.Enabled = true;
            this.forgotPasswordButton.Click += new EventHandler(this.ForgotPasswordButton__Click);
            this.usernameTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.passwordTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.timer1.Enabled = true;
            this.timer1.Start();
            this.timer1.Tick += new EventHandler(this.Timer__Tick);
        }

        // timer tick event handler
        // change progress bar
        private void Timer__Tick(object sender, EventArgs e)
        {
            // if progress bar didn't run out
            if (this.progressBar.Value > 0)
            {
                // subtract from progress bar
                this.progressBar.Value--;
            }
            else
            {
                // otherwise stop timer, display Message Box, and close form if Message Box is closed
                this.timer1.Stop();
                MessageBox.Show("Better luck next time!");
                this.Close();
            }
        }

        // login button event handler
        // show message box saying your input is wrong
        private void LoginButton__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your credentials are incorrect!");
        }

        // sign up button click event handler
        // open sign up form window
        private void SignUpButton__Click(Object sender, EventArgs e)
        {
            this.timer1.Stop();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        // forgot password button event handler
        // open up forgot password window
        private void ForgotPasswordButton__Click(Object sender, EventArgs e)
        {
            this.timer1.Stop();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }

        // text box key press event handler
        // fill username and password text boxes with more filler
        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            this.usernameTextBox.Text += "moreplaceholdertext";
            this.passwordTextBox.Text += "moreplaceholdertext";
        }
    }
}
