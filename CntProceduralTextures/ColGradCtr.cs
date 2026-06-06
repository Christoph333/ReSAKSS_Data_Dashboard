using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CntProceduralTextures
{
    public partial class ColGradCtr : UserControl
    {

         //gradient management class
         Wgrad<Color> realColGrad = new Wgrad<Color>(Color.White, Color.Black);
         Wgrad<Color> tmpColGrad = new Wgrad<Color>(Color.White, Color.Black);
         gradObj<Color> hdl = null;
        
         private Bitmap offScreenBmp; //double buffer bitmap

#region control event management
         public event EventHandler ColorChanging;
         public event EventHandler ColorChanged;
         protected virtual void OnColorChanging(EventArgs e)
         {
             EventHandler handler = this.ColorChanging;
             if (handler != null)
             {
                 handler(this, e);
             }
         }
         protected virtual void OnColorChanged(EventArgs e)
         {
             EventHandler handler = this.ColorChanged;
             if (handler != null)
             {
                 handler(this, e);
             }
         }
#endregion


         public ColGradCtr()
        {
            InitializeComponent();
            offScreenBmp = new Bitmap(this.Width, this.Height);
        }


        //gets gdi+ ColorBlend object
        public ColorBlend getColorBlend() {
            ColorBlend cb = new ColorBlend();
            gradObj<Color>[] cc = tmpColGrad.getArray();
            cb.Positions = new float[cc.Length];
            cb.Colors = new Color[cc.Length];

            for (int i = 0; i < cc.Length; i++)
            {
                cb.Positions[i] = cc[i].w;
                cb.Colors[i] = cc[i].ele;
            }
            return cb;        
        }

        //Given p = 0..1 , return corresponding color
        public Color getColor(float p) {
            if (tmpColGrad!=null)
                return getColor(p, tmpColGrad);
            else
                return getColor(p, realColGrad);
        }

        private Color getColor(float p, Wgrad<Color> CGrad){
            gradObj<Color>[] COLORS = CGrad.getEle(p);
            Color C1 = COLORS[0].ele;
            float W1 = COLORS[0].w;
            Color C2 = COLORS[1].ele;
            float W2 = COLORS[1].w;
            int r;
            int g;
            int b;
            if (W1 == W2)
            {
                r = C1.R;
                g = C1.G;
                b = C1.B;
            }
            else
            {
                p = (p - W1) / (W2 - W1);
                r = (int)((float)C1.R * (1f - p) + (float)C2.R * p);
                g = (int)((float)C1.G * (1f - p) + (float)C2.G * p);
                b = (int)((float)C1.B * (1f - p) + (float)C2.B * p);
            }

            Color clr;
            clr = Color.FromArgb(r, g, b);
            return clr;
        
        }

        //this is the control re-paint method 
        private void redraw() {
            
            tmpColGrad = realColGrad.Clone();
            if (hdl != null)
            {
                tmpColGrad.addEle(hdl.ele, hdl.w);
            }

            Graphics g = this.CreateGraphics();
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Do Double Buffering
            Graphics offScreenDC;
            //
            offScreenDC = Graphics.FromImage(offScreenBmp);

            offScreenDC.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            offScreenDC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            offScreenDC.Clear(this.BackColor);

            if (this.BackgroundImage != null)
                offScreenDC.DrawImage(this.BackgroundImage, 0, 0);

//USE gdi+ gradient            
            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend cb = new ColorBlend();
            gradObj<Color>[] cc =  tmpColGrad.getArray();
            cb.Positions = new float [cc.Length];
            cb.Colors = new Color [cc.Length];
            
            for (int i = 0;  i<cc.Length; i++) { 
                cb.Positions[i]=cc[i].w;
                cb.Colors[i] = cc[i].ele;
            }
            br.InterpolationColors = cb;
            
            offScreenDC.FillRectangle(br, this.ClientRectangle);


// draw handles
            gradObj<Color>[] hndlColors = tmpColGrad.getArray();
            foreach (gradObj<Color> c in hndlColors)
            {
                drawHndls(c, offScreenDC);
            }

// draw graduation lines
            for (int i=1; i < 10; i++) {
                if (i == 5)
                    drawLin((float)i / 10f,0.5f, offScreenDC);
                else
                    drawLin((float)i / 10f,0.3f, offScreenDC);
            }

            g.DrawImageUnscaled(offScreenBmp, 0, 0);

            offScreenDC.Dispose();
            g.Dispose();

        }

        private void ColGradCtr_Paint(object sender, PaintEventArgs e)
        {
            redraw();
        }

        // public method to initialize a gradient control 
        public void reset(Color c1, Color c2) {
            realColGrad = new Wgrad<Color>(c1, c2);
            redraw();
        }

        // public method to add a color in position p=0..1
        public void addColor(Color c , float p){
            realColGrad.addEle(c, p);
            redraw();
        }

        public Wgrad<Color>  getGrad() {
            return realColGrad;
        }

        private void drawHndls(gradObj<Color> c, Graphics g)
        {
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 1.0f);
            System.Drawing.Pen myPen2 = new System.Drawing.Pen(System.Drawing.Color.White, 1.0f);
            myPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Brush solidBeigeBrush = new SolidBrush(c.ele);
            g.FillRectangle(solidBeigeBrush, this.Width * c.w - 3, 0, 5, this.Height * 0.8f);
            g.DrawRectangle(myPen, this.Width * c.w - 3, 0, 5, this.Height * 0.8f);
            g.DrawRectangle(myPen2, this.Width * c.w - 3, 0, 5, this.Height * 0.8f);
            myPen.Dispose();
            solidBeigeBrush.Dispose();
        }

        private void drawLin(float p,float h, Graphics g)
        {
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black, 1.0f);
            //Brush solidBeigeBrush = new SolidBrush(c.ele);
            //g.FillRectangle(solidBeigeBrush, this.Width * c.w - 3, 0, 5, this.Height * 0.8f);
            g.DrawLine(myPen, this.Width * p, this.Height, this.Width * p, this.Height - this.Height * h);
            myPen.Dispose();
            //solidBeigeBrush.Dispose();
        }

        private void ColGradCtr_Resize(object sender, EventArgs e)
        {
            offScreenBmp = new Bitmap(this.Width, this.Height);
        }

        #region mouse events management
        private void ColGradCtr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                float p = (float)e.X / (float)this.Width;
                hdl = realColGrad.delNearest(p);
            }
        }

        private void ColGradCtr_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Width>0){
            float p = (float)e.X / (float)this.Width;

            if (p>0.5f)
                label1.Left = (e.X - label1.Width) -20;
            else
                label1.Left = e.X + 20;
            label1.Text = Math.Round( p,3).ToString();
            //label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Visible = true;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (hdl != null)
                {                
                    hdl.w = p;
                }
              
                redraw();
                OnColorChanging(e);//manage event event
               
            }
            //label1.Visible = true;
            }
        }

        private void ColGradCtr_MouseUp(object sender, MouseEventArgs e)
        {
            //LEFT BTN
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (hdl != null)
                {
                    realColGrad.addEle(hdl.ele, hdl.w);
                    hdl = null;
                    
                    redraw();
                    OnColorChanged(e);//manage event event
                }
                return;
            }
            //RIGHT BTN
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (hdl == null)
                {
                    float p = (float)e.X / (float)this.Width;
                    colorDialog1.Color = getColor( p, realColGrad);

                    DialogResult result = colorDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Set form background to the selected color.
                        
                        //realColGrad.addEle(colorDialog1.Color, p);
                        float delta = 5f / (float)this.Width;
                        realColGrad.UpdOrAddEle(colorDialog1.Color, p, delta);
                        //realColGrad.UpdOrAddEle (colorDialog1.Color, p,0.005f);
                        
                        redraw();
                        OnColorChanged(e);//manage event event
                    }
                }
                return;
            }


        }

        private void ColGradCtr_MouseLeave(object sender, EventArgs e)
        {
            bool wasNull = hdl == null;
            hdl = null;
            label1.Visible = false;
            if (!wasNull)
                OnColorChanged(e);//manage event event
            redraw();
        }
        #endregion


    }
}
