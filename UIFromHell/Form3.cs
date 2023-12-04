using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.Timers;

namespace UIFromHell
{
    // Author: Christine Espeleta
    // Purpose: Forgot Password form. The type test changes using a thread when a key is pressed in the text box.
    // Restrictions: N/A

    public partial class ForgotPasswordForm : Form
    {
        Thread thread;
        string[] typeTests = {"The quick brown fox jumps over a lazy dog", "The five boxing wizards jump quickly", "We promptly judged antique ivory buckles for the next prize"};
        int nRandom;

        public ForgotPasswordForm()
        {
            InitializeComponent();
            // make a thread
            ThreadStart threadStart = new ThreadStart(ChangeTypeLabel);
            this.typeTextBox.KeyPress += new KeyPressEventHandler(TypeTextBox__KeyPress);
            this.savePasswordButton.Click += new EventHandler(SavePasswordButton__Click);
            thread = new Thread(threadStart);
            thread.Start();
        }

        // text box key press event handler
        // generate a random number
        private void TypeTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {

            Random rand;
            rand = new Random();
            nRandom = rand.Next(0, typeTests.Length);
        }

        // change type label method, used by thread
        // use random number to change type label
        // using thread
        public void ChangeTypeLabel()
        {
            while (true)
            {
                this.typingLabel.Text = typeTests[nRandom];
            }
        }

        // save password button click event handler
        private void SavePasswordButton__Click(object sender, EventArgs e)
        {
            // check to see if text box matches type label
            if (this.typeTextBox.Text == this.typingLabel.Text)
            {
                MessageBox.Show("Your password is saved.");
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            } else
            {
                MessageBox.Show("Please try again.");
            }
        }

    }
}
