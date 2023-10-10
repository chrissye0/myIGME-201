using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class MyEditorParent : Form
    {
        public MyEditorParent()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_Click);
            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem_Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            Form1 form1 = new Form1(this);
            form1.Show();
        }

        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
