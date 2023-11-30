using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

// Author: Christine Espeleta
// Purpose: Create a number guessing game.
// This is the first form where the user has to input a low and high range.
// Restrictions: N/A

namespace PE17NumberGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // start button and text box event handlers
            this.startButton.Click += new EventHandler(this.StartButton__Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.highTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
        }
        bool bConv = true;

        // key press event handler for text boxes
        // check to see if it's a digit, don't process if it's not (but allow backspaces)
        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            bConv = Char.IsDigit(e.KeyChar);
            if (bConv == false && e.KeyChar != (char)Keys.Back) 
            {
                    e.Handled = true;
            }
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            
            try
            {
                lowNumber = Int32.Parse(lowTextBox.Text);
                highNumber = Int32.Parse(highTextBox.Text);
            }
            catch
            {
 
            }
            // if not a valid range
            if ((lowNumber >= highNumber) || (highNumber <= lowNumber))
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

    }
}
