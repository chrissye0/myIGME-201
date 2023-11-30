using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Christine Espeleta
// Purpose: Create a number guessing game.
// This is the second form where the user guesses numbers.
// Restrictions: N/A

namespace PE17NumberGuessingGame
{
    public partial class GameForm : Form
    {
        // random number
        int nRandom;
        // number of guesses
        int nGuesses = 0;
        // check input
        bool bConv;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();
            // guess button event handler
            this.guessButton.Click += new EventHandler(this.GuessButton__Click);
            this.guessTextBox.KeyPress += new KeyPressEventHandler(this.GuessTextBox__KeyPress);
            // start timer
            this.timer.Enabled = true;
            this.timer.Start();
            this.progressBar.Enabled = true;
            // timer event handler
            this.timer.Tick += new EventHandler(this.Timer__Tick);
            // create random number from range
            Random rand;
            rand = new Random();
            nRandom = rand.Next(lowNumber, highNumber + 1);
        }

        // timer event handler
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
                this.timer.Stop();
                MessageBox.Show($"Out of time! The correct answer is {nRandom}.");
                this.Close();
            }
        }

        // key press event handler for text boxes
        // check to see if it's a digit, don't process if it's not (but allow backspaces)
        private void GuessTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            bConv = Char.IsDigit(e.KeyChar);
            if (bConv == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // guess button event handler
        private void GuessButton__Click(object sender, EventArgs e)
        {
            int guess = 0;
            // parse input
            try
            {
                guess = Int32.Parse(guessTextBox.Text);
            }
            catch
            {

            }
            // if you guess low
            if (guess < nRandom)
            {
                // change output label text
                outputLabel.Text = $"Your guess of {guess} is low!";
                // add 1 to total guesses
                nGuesses++;
            }
            // if you guess high
            if (guess > nRandom)
            {
                // change output label text
                outputLabel.Text = $"Your guess of {guess} is high!";
                // add 1 to total guesses
                nGuesses++;
            }
            // if you guess right and time isn't out
            if (guess == nRandom && this.progressBar.Value > 0)
            {
                nGuesses++;
                timer.Stop();
                // show a message box saying you're right with the number of guesses
                if (nGuesses == 1)
                {
                    MessageBox.Show($"Woohoo, you got it in {nGuesses} guess!");
                }
                else
                {
                    MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                }
                // close form after closing message box
                this.Close();
            }
        }
    }
}
