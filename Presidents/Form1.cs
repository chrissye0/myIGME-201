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
// Purpose: Presidents Form
// Restrictions: For an error provider to disappear, the user would have to hit a non-digit key after entering the correct number.

namespace Presidents
{
    public partial class Presidents : Form
    {
        public Presidents()
        {
            InitializeComponent();

            // event handlers for all president radio buttons
            this.benjaminHarrisonRadioButton.CheckedChanged += new EventHandler(this.BenjaminHarrison__CheckedChanged);
            this.franklinDRooseveltRadioButton.CheckedChanged += new EventHandler(this.FranklinDRooseveltRadioButton__CheckedChanged);
            this.williamJClintonRadioButton.CheckedChanged += new EventHandler(this.WilliamJClintonRadioButton__CheckedChanged);
            this.jamesBuchananRadioButton.CheckedChanged += new EventHandler(this.JamesBuchananRadioButton__CheckedChanged);
            this.franklinPierceRadioButton.CheckedChanged += new EventHandler(this.FranklinPierceRadioButton__CheckedChanged);
            this.georgeWBushRadioButton.CheckedChanged += new EventHandler(this.GeorgeWBushRadioButton__CheckedChanged);
            this.barackObamaRadioButton.CheckedChanged += new EventHandler(this.BarackObamaRadioButton__CheckedChanged);
            this.johnFKennedyRadioButton.CheckedChanged += new EventHandler(this.JohnFKennedyRadioButton__CheckedChanged);
            this.williamMcKinleyRadioButton.CheckedChanged += new EventHandler(this.WilliamMcKinleyRadioButton__CheckedChanged);
            this.ronaldReaganRadioButton.CheckedChanged += new EventHandler(this.RonaldReaganRadioButton__CheckedChanged);
            this.dwightDEisenhowerRadioButton.CheckedChanged += new EventHandler(this.DwightDEisenhowerRadioButton__CheckedChanged);
            this.martinVanBurenRadioButton.CheckedChanged += new EventHandler(this.MartinVanBurenRadioButton__CheckedChanged);
            this.georgeWashingtonRadioButton.CheckedChanged += new EventHandler(this.GeorgeWashingtonRadioButton__CheckedChanged);
            this.johnAdamsRadioButton.CheckedChanged += new EventHandler(this.JohnAdamsRadioButton__CheckedChanged);
            this.theodoreRooseveltRadioButton.CheckedChanged += new EventHandler(this.TheodoreRooseveltRadioButton__CheckedChanged);
            this.thomasJeffersonRadioButton.CheckedChanged += new EventHandler(this.ThomasJeffersonRadioButton__CheckedChanged);

            // event handlers for filter radio buttons
            this.allRadioButton.CheckedChanged += new EventHandler(this.AllRadioButton__CheckedChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(this.DemocratRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(this.RepublicanRadioButton__CheckedChanged);
            this.democraticRepublicanRadioButton.CheckedChanged += new EventHandler(this.DemocraticRepublicanRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(this.FederalistRadioButton__CheckedChanged);

            // hover over image
            this.presidentPictureBox.MouseHover += new EventHandler(this.PresidentPictureBox__MouseHover);
            // no longer hover over image
            this.presidentPictureBox.MouseLeave += new EventHandler(this.PresidentPictureBox__MouseLeave);

            // key press event handlers
            this.benjaminHarrisonTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.franklinDRooseveltTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.williamJClintonTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.jamesBuchananTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.franklinPierceTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.georgeWBushTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.barackObamaTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.johnFKennedyTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.williamMcKinleyTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.ronaldReaganTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.dwightDEisenhowerTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.martinVanBurenTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.georgeWashingtonTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.johnAdamsTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.theodoreRooseveltTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);
            this.thomasJeffersonTextBox.KeyPress += new KeyPressEventHandler(this.TextBox__KeyPress);

            // enable progress bar
            this.progressBar1.Enabled = true;
            // timer tick event handler
            this.timer1.Tick += new EventHandler(this.Timer__Tick);
            // don't enable exit button
            this.exitButton.Enabled = false;
            this.exitButton.Click += new EventHandler(this.ExitButton__Click);
        }

        // exit button event handler
        // close program
        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // timer tick event handler
        private void Timer__Tick(object sender, EventArgs e)
        {
            // if progress bar didn't run out, take away from it's value
            if (this.progressBar1.Value > 0)
            {
                this.progressBar1.Value--;
            }
            // otherwise stop timer
            else
            {
                this.timer1.Stop();
            }
        }

        // text box key press event handler
        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            // enable and start timer
            this.timer1.Enabled = true;
            this.timer1.Start();

            // only let digits and backspace be entered into text box
            bool bConv = Char.IsDigit(e.KeyChar);
            if (bConv == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // error provider for different text boxes
            if (this.benjaminHarrisonTextBox.Text != "0")
            {
                if (this.benjaminHarrisonTextBox.Text != "23")
                {
                    errorProvider1.SetError(this.benjaminHarrisonTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.benjaminHarrisonTextBox, "");
                }
            }
            if (this.franklinDRooseveltTextBox.Text != "0")
            {
                if (this.franklinDRooseveltTextBox.Text != "32")
                {
                    errorProvider1.SetError(this.franklinDRooseveltTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.franklinDRooseveltTextBox, "");
                }
            }
            if(this.williamJClintonTextBox.Text != "0")
            {
                if (this.williamJClintonTextBox.Text != "42")
                {
                    errorProvider1.SetError(this.williamJClintonTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.williamJClintonTextBox, "");
                }
            }
            if (this.jamesBuchananTextBox.Text != "0")
            {
                if (this.jamesBuchananTextBox.Text != "15")
                {
                    errorProvider1.SetError(this.jamesBuchananTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.jamesBuchananTextBox, "");
                }
            }
            if (this.franklinPierceTextBox.Text != "0")
            {
                if (this.franklinPierceTextBox.Text != "14")
                {
                    errorProvider1.SetError(this.franklinPierceTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.franklinPierceTextBox, "");
                }
            }
            if (this.georgeWBushTextBox.Text != "0")
            {
                if (this.georgeWBushTextBox.Text != "43")
                {
                    errorProvider1.SetError(this.georgeWBushTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.georgeWBushTextBox, "");
                }
            }
            if (this.barackObamaTextBox.Text != "0")
            {
                if (this.barackObamaTextBox.Text != "44")
                {
                    errorProvider1.SetError(this.barackObamaTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.barackObamaTextBox, "");
                }
            }
            if (this.johnFKennedyTextBox.Text != "0")
            {
                if (this.johnFKennedyTextBox.Text != "35")
                {
                    errorProvider1.SetError(this.johnFKennedyTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.johnFKennedyTextBox, "");
                }
            }
            if (this.williamMcKinleyTextBox.Text != "0")
            {
                if (this.williamMcKinleyTextBox.Text != "25")
                {
                    errorProvider1.SetError(this.williamMcKinleyTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.williamMcKinleyTextBox, "");
                }
            }
            if (this.ronaldReaganTextBox.Text != "0")
            {
                if (this.ronaldReaganTextBox.Text != "40")
                {
                    errorProvider1.SetError(this.ronaldReaganTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.ronaldReaganTextBox, "");
                }
            }
            if (this.dwightDEisenhowerTextBox.Text != "0")
            {
                if (this.dwightDEisenhowerTextBox.Text != "34")
                {
                    errorProvider1.SetError(this.dwightDEisenhowerTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.dwightDEisenhowerTextBox, "");
                }
            }
            if (this.martinVanBurenTextBox.Text != "0")
            {
                if (this.martinVanBurenTextBox.Text != "8")
                {
                    errorProvider1.SetError(this.martinVanBurenTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.martinVanBurenTextBox, "");
                }
            }
            if (this.georgeWashingtonTextBox.Text != "0")
            {
                if (this.georgeWashingtonTextBox.Text != "1")
                {
                    errorProvider1.SetError(this.georgeWashingtonTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.georgeWashingtonTextBox, "");
                }
            }
            if (this.johnAdamsTextBox.Text != "0")
            {
                if (this.johnAdamsTextBox.Text != "2")
                {
                    errorProvider1.SetError(this.johnAdamsTextBox, "That is the wrong number.");
                } else
                {
                    errorProvider1.SetError(this.johnAdamsTextBox, "");
                }
            }
            if (this.theodoreRooseveltTextBox.Text != "0")
            {
                if (this.theodoreRooseveltTextBox.Text != "26")
                {
                    errorProvider1.SetError(this.theodoreRooseveltTextBox, "That is the wrong number.");
                }
                else
                {
                    errorProvider1.SetError(this.theodoreRooseveltTextBox, "");
                }
            }
            if (this.thomasJeffersonTextBox.Text != "0")
            {
                if (this.thomasJeffersonTextBox.Text != "3")
                {
                    errorProvider1.SetError(this.thomasJeffersonTextBox, "That is the wrong number.");
                }
                else
                {
                    errorProvider1.SetError(this.thomasJeffersonTextBox, "");
                }
            }

            // if everything is correct
            if ((this.benjaminHarrisonTextBox.Text == "23") &&
(this.franklinDRooseveltTextBox.Text == "32") &&
(this.williamJClintonTextBox.Text == "42") &&
(this.jamesBuchananTextBox.Text == "15") &&
(this.franklinPierceTextBox.Text == "14") &&
(this.georgeWBushTextBox.Text == "43") &&
(this.barackObamaTextBox.Text == "44") &&
(this.johnFKennedyTextBox.Text == "35") &&
(this.williamMcKinleyTextBox.Text == "25") &&
(this.ronaldReaganTextBox.Text == "40") &&
(this.dwightDEisenhowerTextBox.Text == "34") &&
(this.martinVanBurenTextBox.Text == "8") &&
(this.georgeWashingtonTextBox.Text == "1") &&
(this.johnAdamsTextBox.Text == "2") &&
(this.theodoreRooseveltTextBox.Text == "26") &&
(this.thomasJeffersonTextBox.Text == "3"))
            {
                // play fireworks and stop timer
                // also enable exit button
                webBrowserGroupBox.Text = "https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif";
                webBrowser1.Navigate(new Uri("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif"));
                this.timer1.Stop();
                this.exitButton.Enabled = true;
            }
        }

        // mouse hover event handler
        private void PresidentPictureBox__MouseHover(object sender, EventArgs e)
        {
            // scale up picture box size
            this.presidentPictureBox.Width *= 2;
            this.presidentPictureBox.Height *= 2;
        }

        // mouse leave event handler
        private void PresidentPictureBox__MouseLeave(object sender, EventArgs e)
        {
            // return picture box to original size
            this.presidentPictureBox.Size = new Size(155, 236);
        }

        // click on all radio button in filter group box
        // enable and display all radio buttons
        private void AllRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.benjaminHarrisonRadioButton.Enabled = true;
            this.benjaminHarrisonRadioButton.Visible = true;
            // default
            this.benjaminHarrisonRadioButton.Checked = true;

            this.franklinDRooseveltRadioButton.Enabled = true;
            this.franklinDRooseveltRadioButton.Visible = true;

            this.williamJClintonRadioButton.Enabled = true;
            this.williamJClintonRadioButton.Visible = true;

            this.jamesBuchananRadioButton.Enabled = true;
            this.jamesBuchananRadioButton.Visible = true;

            this.franklinPierceRadioButton.Enabled = true;
            this.franklinPierceRadioButton.Visible = true;

            this.georgeWBushRadioButton.Enabled = true;
            this.georgeWBushRadioButton.Visible = true;

            this.barackObamaRadioButton.Enabled = true;
            this.barackObamaRadioButton.Visible = true;

            this.johnFKennedyRadioButton.Enabled = true;
            this.johnFKennedyRadioButton.Visible = true;

            this.williamMcKinleyRadioButton.Enabled = true;
            this.williamMcKinleyRadioButton.Visible = true;

            this.ronaldReaganRadioButton.Enabled = true;
            this.ronaldReaganRadioButton.Visible = true;

            this.dwightDEisenhowerRadioButton.Enabled = true;
            this.dwightDEisenhowerRadioButton.Visible = true;

            this.martinVanBurenRadioButton.Enabled = true;
            this.martinVanBurenRadioButton.Visible = true;

            this.georgeWashingtonRadioButton.Enabled = true;
            this.georgeWashingtonRadioButton.Visible = true;

            this.johnAdamsRadioButton.Enabled = true;
            this.johnAdamsRadioButton.Visible = true;

            this.theodoreRooseveltRadioButton.Enabled = true;
            this.theodoreRooseveltRadioButton.Visible = true;

            this.thomasJeffersonRadioButton.Enabled = true;
            this.thomasJeffersonRadioButton.Visible = true;
        }

        // click on democrat radio button in filter group box
        // enable and display only democrat president radio buttons
        private void DemocratRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.benjaminHarrisonRadioButton.Enabled = false;
            this.benjaminHarrisonRadioButton.Visible = false;

            this.franklinDRooseveltRadioButton.Enabled = true;
            this.franklinDRooseveltRadioButton.Visible = true;
            // default
            this.franklinDRooseveltRadioButton.Checked = true;

            this.williamJClintonRadioButton.Enabled = true;
            this.williamJClintonRadioButton.Visible = true;

            this.jamesBuchananRadioButton.Enabled = true;
            this.jamesBuchananRadioButton.Visible = true;

            this.franklinPierceRadioButton.Enabled = true;
            this.franklinPierceRadioButton.Visible = true;

            this.georgeWBushRadioButton.Enabled = false;
            this.georgeWBushRadioButton.Visible = false;

            this.barackObamaRadioButton.Enabled = true;
            this.barackObamaRadioButton.Visible = true;

            this.johnFKennedyRadioButton.Enabled = true;
            this.johnFKennedyRadioButton.Visible = true;

            this.williamMcKinleyRadioButton.Enabled = false;
            this.williamMcKinleyRadioButton.Visible = false;

            this.ronaldReaganRadioButton.Enabled = false;
            this.ronaldReaganRadioButton.Visible = false;

            this.dwightDEisenhowerRadioButton.Enabled = false;
            this.dwightDEisenhowerRadioButton.Visible = false;

            this.martinVanBurenRadioButton.Enabled = true;
            this.martinVanBurenRadioButton.Visible = true;

            this.georgeWashingtonRadioButton.Enabled = false;
            this.georgeWashingtonRadioButton.Visible = false;

            this.johnAdamsRadioButton.Enabled = false;
            this.johnAdamsRadioButton.Visible = false;

            this.theodoreRooseveltRadioButton.Enabled = false;
            this.theodoreRooseveltRadioButton.Visible = false;

            this.thomasJeffersonRadioButton.Enabled = false;
            this.thomasJeffersonRadioButton.Visible = false;
        }

        // click on republican radio button in filter group box
        // enable and display only republican president radio buttons
        private void RepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.benjaminHarrisonRadioButton.Enabled = true;
            this.benjaminHarrisonRadioButton.Visible = true;
            // default
            this.benjaminHarrisonRadioButton.Checked = true;

            this.franklinDRooseveltRadioButton.Enabled = false;
            this.franklinDRooseveltRadioButton.Visible = false;

            this.williamJClintonRadioButton.Enabled = false;
            this.williamJClintonRadioButton.Visible = false;

            this.jamesBuchananRadioButton.Enabled = false;
            this.jamesBuchananRadioButton.Visible = false;

            this.franklinPierceRadioButton.Enabled = false;
            this.franklinPierceRadioButton.Visible = false;

            this.georgeWBushRadioButton.Enabled = true;
            this.georgeWBushRadioButton.Visible = true;

            this.barackObamaRadioButton.Enabled = false;
            this.barackObamaRadioButton.Visible = false;

            this.johnFKennedyRadioButton.Enabled = false;
            this.johnFKennedyRadioButton.Visible = false;

            this.williamMcKinleyRadioButton.Enabled = true;
            this.williamMcKinleyRadioButton.Visible = true;

            this.ronaldReaganRadioButton.Enabled = true;
            this.ronaldReaganRadioButton.Visible = true;

            this.dwightDEisenhowerRadioButton.Enabled = true;
            this.dwightDEisenhowerRadioButton.Visible = true;

            this.martinVanBurenRadioButton.Enabled = false;
            this.martinVanBurenRadioButton.Visible = false;

            this.georgeWashingtonRadioButton.Enabled = false;
            this.georgeWashingtonRadioButton.Visible = false;

            this.johnAdamsRadioButton.Enabled = false;
            this.johnAdamsRadioButton.Visible = false;

            this.theodoreRooseveltRadioButton.Enabled = true;
            this.theodoreRooseveltRadioButton.Visible = true;

            this.thomasJeffersonRadioButton.Enabled = false;
            this.thomasJeffersonRadioButton.Visible = false;
        }

        // click on democratic republican radio button in filter group box
        // enable and display only democratic republican president radio buttons
        private void DemocraticRepublicanRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.benjaminHarrisonRadioButton.Enabled = false;
            this.benjaminHarrisonRadioButton.Visible = false;

            this.franklinDRooseveltRadioButton.Enabled = false;
            this.franklinDRooseveltRadioButton.Visible = false;

            this.williamJClintonRadioButton.Enabled = false;
            this.williamJClintonRadioButton.Visible = false;

            this.jamesBuchananRadioButton.Enabled = false;
            this.jamesBuchananRadioButton.Visible = false;

            this.franklinPierceRadioButton.Enabled = false;
            this.franklinPierceRadioButton.Visible = false;

            this.georgeWBushRadioButton.Enabled = false;
            this.georgeWBushRadioButton.Visible = false;

            this.barackObamaRadioButton.Enabled = false;
            this.barackObamaRadioButton.Visible = false;

            this.johnFKennedyRadioButton.Enabled = false;
            this.johnFKennedyRadioButton.Visible = false;

            this.williamMcKinleyRadioButton.Enabled = false;
            this.williamMcKinleyRadioButton.Visible = false;

            this.ronaldReaganRadioButton.Enabled = false;
            this.ronaldReaganRadioButton.Visible = false;

            this.dwightDEisenhowerRadioButton.Enabled = false;
            this.dwightDEisenhowerRadioButton.Visible = false;

            this.martinVanBurenRadioButton.Enabled = false;
            this.martinVanBurenRadioButton.Visible = false;

            this.georgeWashingtonRadioButton.Enabled = false;
            this.georgeWashingtonRadioButton.Visible = false;

            this.johnAdamsRadioButton.Enabled = false;
            this.johnAdamsRadioButton.Visible = false;

            this.theodoreRooseveltRadioButton.Enabled = false;
            this.theodoreRooseveltRadioButton.Visible = false;

            this.thomasJeffersonRadioButton.Enabled = true;
            this.thomasJeffersonRadioButton.Visible = true;
            // default
            this.thomasJeffersonRadioButton.Checked = true;
        }

        // click on federalist radio button in filter group box
        // enable and display only federalist president radio buttons
        private void FederalistRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            this.benjaminHarrisonRadioButton.Enabled = false;
            this.benjaminHarrisonRadioButton.Visible = false;

            this.franklinDRooseveltRadioButton.Enabled = false;
            this.franklinDRooseveltRadioButton.Visible = false;

            this.williamJClintonRadioButton.Enabled = false;
            this.williamJClintonRadioButton.Visible = false;

            this.jamesBuchananRadioButton.Enabled = false;
            this.jamesBuchananRadioButton.Visible = false;

            this.franklinPierceRadioButton.Enabled = false;
            this.franklinPierceRadioButton.Visible = false;

            this.georgeWBushRadioButton.Enabled = false;
            this.georgeWBushRadioButton.Visible = false;

            this.barackObamaRadioButton.Enabled = false;
            this.barackObamaRadioButton.Visible = false;

            this.johnFKennedyRadioButton.Enabled = false;
            this.johnFKennedyRadioButton.Visible = false;

            this.williamMcKinleyRadioButton.Enabled = false;
            this.williamMcKinleyRadioButton.Visible = false;

            this.ronaldReaganRadioButton.Enabled = false;
            this.ronaldReaganRadioButton.Visible = false;

            this.dwightDEisenhowerRadioButton.Enabled = false;
            this.dwightDEisenhowerRadioButton.Visible = false;

            this.martinVanBurenRadioButton.Enabled = false;
            this.martinVanBurenRadioButton.Visible = false;

            this.georgeWashingtonRadioButton.Enabled = true;
            this.georgeWashingtonRadioButton.Visible = true;
            // default
            this.georgeWashingtonRadioButton.Checked = true;

            this.johnAdamsRadioButton.Enabled = true;
            this.johnAdamsRadioButton.Visible = true;

            this.theodoreRooseveltRadioButton.Enabled = false;
            this.theodoreRooseveltRadioButton.Visible = false;

            this.thomasJeffersonRadioButton.Enabled = false;
            this.thomasJeffersonRadioButton.Visible = false;
        }

        // Radio button event handlers for all presidents
        // change web browser group box text
        // navigate web browser to new wikipedia url
        // change picture box location (using url)

        private void BenjaminHarrison__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg";
        }

        private void FranklinDRooseveltRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
        }

        private void WilliamJClintonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Bill_Clinton"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
        }

        private void JamesBuchananRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/James_Buchanan"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
        }

        private void FranklinPierceRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Franklin_Pierce"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
        }

        private void GeorgeWBushRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/George_W._Bush"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
        }

        private void BarackObamaRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Barack_Obama"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
        }

        private void JohnFKennedyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/John_F._Kennedy"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
        }

        private void WilliamMcKinleyRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/William_McKinley"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
        }

        private void RonaldReaganRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Ronald_Reagan"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
        }

        private void DwightDEisenhowerRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
        }

        private void MartinVanBurenRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_Van_Buren";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Martin_Van_Buren"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
        }

        private void GeorgeWashingtonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/George_Washington"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
        }

        private void JohnAdamsRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/John_Adams"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
        }

        private void TheodoreRooseveltRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
        }

        private void ThomasJeffersonRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            webBrowser1.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Thomas_Jefferson"));
            presidentPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
        }
    }
}