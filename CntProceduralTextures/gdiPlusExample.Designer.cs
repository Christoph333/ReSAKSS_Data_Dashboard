namespace CntProceduralTextures
{
    partial class gdiPlusExample
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackGradCtr = new CntProceduralTextures.ColGradCtr();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtGradCtr = new CntProceduralTextures.ColGradCtr();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGradCtr
            // 
            this.BackGradCtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackGradCtr.Location = new System.Drawing.Point(9, 234);
            this.BackGradCtr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackGradCtr.Name = "BackGradCtr";
            this.BackGradCtr.Size = new System.Drawing.Size(615, 54);
            this.BackGradCtr.TabIndex = 0;
            this.BackGradCtr.ColorChanging += new System.EventHandler(this.BackGradCtr_ColorChanging);
            this.BackGradCtr.ColorChanged += new System.EventHandler(this.BackGradCtr_ColorChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 143);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // TxtGradCtr
            // 
            this.TxtGradCtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtGradCtr.Location = new System.Drawing.Point(9, 174);
            this.TxtGradCtr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtGradCtr.Name = "TxtGradCtr";
            this.TxtGradCtr.Size = new System.Drawing.Size(615, 40);
            this.TxtGradCtr.TabIndex = 2;
            this.TxtGradCtr.ColorChanging += new System.EventHandler(this.TxtGradCtr_ColorChanging);
            this.TxtGradCtr.ColorChanged += new System.EventHandler(this.TxtGradCtr_ColorChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text gradient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background  gradient";
            // 
            // gdiPlusExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGradCtr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackGradCtr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gdiPlusExample";
            this.Text = "gdiPlusExample";
            this.Activated += new System.EventHandler(this.gdiPlusExample_Activated);
            this.Load += new System.EventHandler(this.gdiPlusExample_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gdiPlusExample_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColGradCtr BackGradCtr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ColGradCtr TxtGradCtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}