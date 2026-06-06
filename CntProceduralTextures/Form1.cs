using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Reflection;
using System.Globalization;
using System.IO;
using System.Threading;


namespace CntProceduralTextures
{
    public partial class Form1 : Form
    {

        private bool checkON = true;
        private bool analize_text = true;

        float[,] heightMap;

        private Dictionary<string,string> Examples;

        public Form1()
        {
            InitializeComponent();
        }

        private void renoise() {
            //
            float fx = 1f / 128f;
            float fy = 1f / 128f;

            //setup noise
            noiseGen NG = new noiseGen(0);
            //NG.Landscape(0.4f);
            NG.Cartoon(0.02f);
            //grayscale bitmap
            Bitmap b1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);


            for (int i = 0; i < pictureBox1.Width; i++)
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    float v = NG.getV(i, j, fx, fy, 0.5f, 7, 0.7f);
                    heightMap[i, j] = v;

                    float bw = v * 255f;
                    b1.SetPixel(i, j, Color.FromArgb((int)bw, (int)bw, (int)bw));
                }
            pictureBox1.Image = b1;
            reColor(pictureBox2, colGradCtr1);
            reColor(pictureBox3, colGradCtr2);

        }


        private void reColor(PictureBox pct, ColGradCtr col){
            Bitmap b2 = new Bitmap(pct.Width, pct.Height);
            for (int i = 0; i < pct.Width; i++)
                for (int j = 0; j < pct.Height; j++)
                {
                    b2.SetPixel(i, j, col.getColor(heightMap[i, j]));                    
                }
            pct.Image = b2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            heightMap = new float[pictureBox1.Width, pictureBox1.Height];

            renoise();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            renoise();
        }

        private void colGradCtr1_ColorChanged(object sender, EventArgs e)
        {
            reColor(pictureBox2, colGradCtr1);
        }

        private void colGradCtr1_ColorChanging(object sender, EventArgs e)
        {
            reColor(pictureBox2, colGradCtr1);
        }

        private void colGradCtr2_ColorChanged(object sender, EventArgs e)
        {
            reColor(pictureBox3, colGradCtr2);
        }

        private void colGradCtr2_ColorChanging(object sender, EventArgs e)
        {
            reColor(pictureBox3, colGradCtr2);
        }

        private void colGradCtr2_Load(object sender, EventArgs e)
        {
            colGradCtr2.reset(Color.White, Color.FromArgb(156,165,192));
            colGradCtr2.addColor(Color.FromArgb(25, 25, 255), 0.70f);
            colGradCtr2.addColor(Color.White, 0.75f);
            colGradCtr2.addColor(Color.FromArgb(128,128, 255), 0.85f);
           
        }

        private void colGradCtr1_Load_1(object sender, EventArgs e)
        {
            colGradCtr1.reset(Color.Blue, Color.White);
            colGradCtr1.addColor(Color.FromArgb(0, 128, 128), 0.06f);
            colGradCtr1.addColor(Color.FromArgb(0, 0, 159), 0.60f);
            colGradCtr1.addColor(Color.FromArgb(6, 20, 203), 0.70f);
            colGradCtr1.addColor(Color.FromArgb(146, 96, 53), 0.75f);
            colGradCtr1.addColor(Color.FromArgb(0, 100, 0), 0.80f);
            colGradCtr1.addColor(Color.FromArgb(64, 0, 0), 0.90f);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdiPlusExample frm = new gdiPlusExample();
            frm.ShowDialog();
        }
    }
}

