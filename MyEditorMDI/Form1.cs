using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

using System.Threading;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1(MyEditorParent myEditorParent)
        {
            InitializeComponent();

            this.MdiParent = myEditorParent;

            //this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            
            myEditorParent.openToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);

            //this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);

            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem_Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem_Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem_Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem_Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem_Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem_Click);

            this.testToolStripButton.Click += new EventHandler(TestToolStripButton_Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_ItemClicked);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox_SelectionChanged);

            this.countdownLabel.Visible = false;

            this.timer.Tick += new EventHandler(Timer_Tick);

            this.Text = "MyEditor";

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyEditorParent myEditorParent = (MyEditorParent)this.MdiParent;

            myEditorParent.openToolStripMenuItem.Click -= new EventHandler(OpenToolStripMenuItem_Click);
            myEditorParent.saveToolStripMenuItem.Click -= new EventHandler(SaveToolStripMenuItem_Click);

            myEditorParent.copyToolStripMenuItem.Click -= new EventHandler(CopyToolStripMenuItem_Click);
            myEditorParent.cutToolStripMenuItem.Click -= new EventHandler(CutToolStripMenuItem_Click);
            myEditorParent.pasteToolStripMenuItem.Click -= new EventHandler(PasteToolStripMenuItem_Click);

            myEditorParent.closeAllToolStripMenuItem.Click -= new EventHandler(CloseAllToolStripMenuItem_Click);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void TestToolStripButton_Click(object sender, EventArgs e)
        {
            this.timer.Interval = 500;

            this.toolStripProgressBar1.Value = 60;

            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = true;
            this.richTextBox.Visible = false;

            for (int i = 3; i > 0; --i)
            {
                this.countdownLabel.Text = i.ToString();
                this.Refresh();
                Thread.Sleep(1000);
            }

            this.countdownLabel.Visible = false;
            this.richTextBox.Visible = true;

            this.timer.Start();
            richTextBox.Clear();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;
            if (this.toolStripProgressBar1.Value == 0)
            {
                this.timer.Stop();

                string performance = "Congratulations! You typed " + Math.Round(this.richTextBox.TextLength / 30.0, 2) + " letters per second!";

                MessageBox.Show(performance);
            }
        }

        private void ItalicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }




        private void MSSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);

            richTextBox.SelectionFont = newFont;
        }

        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox.SelectionFont != null )
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            saveFileDialog.FileName = openFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Paste();
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if (e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox.SelectionFont = newFont;
        }
    }
}
