using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CntProceduralTextures
{
    public partial class gdiPlusExample : Form
    {

        private Bitmap offScreenBmp;
        public gdiPlusExample()
        {
            InitializeComponent();

            offScreenBmp = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        private void redraw() {

            Graphics g = this.pictureBox1.CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Do Double Buffering
            Graphics offScreenDC;
            //
            offScreenDC = Graphics.FromImage(offScreenBmp);

            offScreenDC.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            offScreenDC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            offScreenDC.Clear(this.pictureBox1.BackColor);

            if (this.pictureBox1.BackgroundImage != null)
                offScreenDC.DrawImage(this.pictureBox1.BackgroundImage, 0, 0);

            LinearGradientBrush br = new LinearGradientBrush(this.pictureBox1.ClientRectangle, Color.Black, Color.Black,LinearGradientMode.BackwardDiagonal);
            ColorBlend cb = BackGradCtr.getColorBlend();//here i get the blend from ctrl
            br.InterpolationColors = cb;

            offScreenDC.FillRectangle(br, this.pictureBox1.ClientRectangle);

            LinearGradientBrush txtbr = new LinearGradientBrush(this.pictureBox1.ClientRectangle, Color.White, Color.White, 0, false);
            ColorBlend txtcb = TxtGradCtr.getColorBlend();//here i get the blend from ctrl
            txtbr.InterpolationColors = txtcb;

            Font fnt = new Font("Verdana", 24);
            offScreenDC.DrawString("GDI+ text Example ", fnt, txtbr, 10, 10);

            g.DrawImageUnscaled(offScreenBmp, 0, 0);
           
            offScreenDC.Dispose();
            g.Dispose();

            //Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //redraw();
        }

        private void gdiPlusExample_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Refresh();
            redraw();
        }

        private void gdiPlusExample_Load(object sender, EventArgs e)
        {
            BackGradCtr.reset(Color.Green, Color.Blue);
            BackGradCtr.addColor(Color.Yellow, 0.3f);
            BackGradCtr.addColor(Color.Gray, 0.8f);

            TxtGradCtr.reset(Color.Red, Color.Black);
            this.Refresh();
            redraw();

            //redraw();
        }

        private void TxtGradCtr_ColorChanged(object sender, EventArgs e)
        {
            redraw();
        }

        private void TxtGradCtr_ColorChanging(object sender, EventArgs e)
        {
            redraw();
        }

        private void BackGradCtr_ColorChanged(object sender, EventArgs e)
        {
            redraw();
        }

        private void BackGradCtr_ColorChanging(object sender, EventArgs e)
        {
            redraw();
        }

        private void gdiPlusExample_Activated(object sender, EventArgs e)
        {
        
        }
    }
}
