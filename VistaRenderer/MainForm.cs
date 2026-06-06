using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VistaRenderer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tStrip.Renderer = new Renderers.WindowsVistaRenderer();
            mnuStrip.Renderer = new Renderers.WindowsVistaRenderer();
        }

        private void enlargeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMenuStrip_Click(object sender, EventArgs e)
        {
            mnuStrip.Visible = true;
            btnShowMenuStrip.Enabled = false;
        }
    }
}