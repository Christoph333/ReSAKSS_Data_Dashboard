namespace ResakssAddIn
{
    partial class Form_BD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BD));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxGeopMap = new System.Windows.Forms.CheckBox();
            this.rbtnColumnSeries = new System.Windows.Forms.RadioButton();
            this.rbtnConstantChange = new System.Windows.Forms.RadioButton();
            this.rbtnLineSeries = new System.Windows.Forms.RadioButton();
            this.cblPays = new System.Windows.Forms.CheckedListBox();
            this.btnSaveChart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbxPays3 = new System.Windows.Forms.ComboBox();
            this.cbxPays2 = new System.Windows.Forms.ComboBox();
            this.btnEvolutionSerie = new System.Windows.Forms.Button();
            this.cbxPays1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxLabels = new System.Windows.Forms.CheckBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.listPaysSelect = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Valeur = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer1.Panel2.Controls.Add(this.cbxLabels);
            this.splitContainer1.Panel2.Controls.Add(this.txtAnnee);
            this.splitContainer1.Panel2.Controls.Add(this.listPaysSelect);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.Valeur);
            this.splitContainer1.Panel2.Controls.Add(this.lblValeur);
            this.splitContainer1.Panel2.Controls.Add(this.lblAnnee);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Gold;
            this.splitContainer1.Size = new System.Drawing.Size(1370, 745);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.SkyBlue;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.cblPays);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer2.Panel2.Controls.Add(this.btnSaveChart);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.btnEffacer);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(286, 745);
            this.splitContainer2.SplitterDistance = 133;
            this.splitContainer2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(-1, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Countries And Areas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxGeopMap);
            this.groupBox1.Controls.Add(this.rbtnColumnSeries);
            this.groupBox1.Controls.Add(this.rbtnConstantChange);
            this.groupBox1.Controls.Add(this.rbtnLineSeries);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Graphs";
            // 
            // cbxGeopMap
            // 
            this.cbxGeopMap.BackgroundImage = global::ResakssAddIn.Properties.Resources.bouton__1_;
            this.cbxGeopMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGeopMap.ForeColor = System.Drawing.Color.Maroon;
            this.cbxGeopMap.Location = new System.Drawing.Point(3, 177);
            this.cbxGeopMap.Name = "cbxGeopMap";
            this.cbxGeopMap.Size = new System.Drawing.Size(118, 50);
            this.cbxGeopMap.TabIndex = 5;
            this.cbxGeopMap.Text = "GeoMap";
            this.cbxGeopMap.UseVisualStyleBackColor = true;
            this.cbxGeopMap.CheckedChanged += new System.EventHandler(this.CbxGeopMap_CheckedChanged);
            // 
            // rbtnColumnSeries
            // 
            this.rbtnColumnSeries.BackgroundImage = global::ResakssAddIn.Properties.Resources.bouton__1_;
            this.rbtnColumnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnColumnSeries.ForeColor = System.Drawing.Color.Maroon;
            this.rbtnColumnSeries.Location = new System.Drawing.Point(2, 71);
            this.rbtnColumnSeries.Name = "rbtnColumnSeries";
            this.rbtnColumnSeries.Size = new System.Drawing.Size(120, 52);
            this.rbtnColumnSeries.TabIndex = 4;
            this.rbtnColumnSeries.Text = "Columne Series";
            this.rbtnColumnSeries.UseVisualStyleBackColor = true;
            this.rbtnColumnSeries.CheckedChanged += new System.EventHandler(this.RbtnColumnSeries_CheckedChanged);
            // 
            // rbtnConstantChange
            // 
            this.rbtnConstantChange.BackgroundImage = global::ResakssAddIn.Properties.Resources.bouton__1_;
            this.rbtnConstantChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnConstantChange.ForeColor = System.Drawing.Color.Maroon;
            this.rbtnConstantChange.Location = new System.Drawing.Point(2, 125);
            this.rbtnConstantChange.Name = "rbtnConstantChange";
            this.rbtnConstantChange.Size = new System.Drawing.Size(119, 50);
            this.rbtnConstantChange.TabIndex = 3;
            this.rbtnConstantChange.Text = "Evolution Chart";
            this.rbtnConstantChange.UseVisualStyleBackColor = true;
            this.rbtnConstantChange.CheckedChanged += new System.EventHandler(this.RbtnConstantChange_CheckedChanged);
            // 
            // rbtnLineSeries
            // 
            this.rbtnLineSeries.BackgroundImage = global::ResakssAddIn.Properties.Resources.bouton__1_;
            this.rbtnLineSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLineSeries.ForeColor = System.Drawing.Color.Maroon;
            this.rbtnLineSeries.Location = new System.Drawing.Point(3, 19);
            this.rbtnLineSeries.Name = "rbtnLineSeries";
            this.rbtnLineSeries.Size = new System.Drawing.Size(120, 50);
            this.rbtnLineSeries.TabIndex = 0;
            this.rbtnLineSeries.Text = "Line Series";
            this.rbtnLineSeries.UseVisualStyleBackColor = true;
            this.rbtnLineSeries.CheckedChanged += new System.EventHandler(this.RbtnLineSeries_CheckedChanged);
            // 
            // cblPays
            // 
            this.cblPays.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cblPays.Enabled = false;
            this.cblPays.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblPays.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cblPays.FormattingEnabled = true;
            this.cblPays.HorizontalScrollbar = true;
            this.cblPays.Location = new System.Drawing.Point(3, 264);
            this.cblPays.Name = "cblPays";
            this.cblPays.Size = new System.Drawing.Size(127, 356);
            this.cblPays.TabIndex = 2;
            this.cblPays.ThreeDCheckBoxes = true;
            this.cblPays.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CblPays_ItemCheck);
            // 
            // btnSaveChart
            // 
            this.btnSaveChart.AutoSize = true;
            this.btnSaveChart.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveChart.FlatAppearance.BorderSize = 0;
            this.btnSaveChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChart.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveChart.Image = global::ResakssAddIn.Properties.Resources.save_chart;
            this.btnSaveChart.Location = new System.Drawing.Point(15, 414);
            this.btnSaveChart.Name = "btnSaveChart";
            this.btnSaveChart.Size = new System.Drawing.Size(118, 57);
            this.btnSaveChart.TabIndex = 18;
            this.btnSaveChart.Text = "Save As Image";
            this.btnSaveChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveChart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSaveChart.UseVisualStyleBackColor = false;
            this.btnSaveChart.Click += new System.EventHandler(this.BtnSaveChart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 6.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(-7, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GeoMap Option";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Gold;
            this.trackBar1.Location = new System.Drawing.Point(10, 54);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(140, 24);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Map Year";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.Transparent;
            this.btnEffacer.Enabled = false;
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Image = global::ResakssAddIn.Properties.Resources.bouton_initialize_charts__6_;
            this.btnEffacer.Location = new System.Drawing.Point(5, 566);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(138, 58);
            this.btnEffacer.TabIndex = 6;
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.BtnEffacer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.cbxPays3);
            this.groupBox2.Controls.Add(this.cbxPays2);
            this.groupBox2.Controls.Add(this.btnEvolutionSerie);
            this.groupBox2.Controls.Add(this.cbxPays1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(-7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose less than 3 countries";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Image = global::ResakssAddIn.Properties.Resources.bouton_stop_chart__1_;
            this.btnStop.Location = new System.Drawing.Point(19, 174);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(123, 45);
            this.btnStop.TabIndex = 8;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // cbxPays3
            // 
            this.cbxPays3.AccessibleDescription = "C 3";
            this.cbxPays3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxPays3.Enabled = false;
            this.cbxPays3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPays3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPays3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxPays3.FormattingEnabled = true;
            this.cbxPays3.Location = new System.Drawing.Point(22, 64);
            this.cbxPays3.Name = "cbxPays3";
            this.cbxPays3.Size = new System.Drawing.Size(117, 21);
            this.cbxPays3.Sorted = true;
            this.cbxPays3.TabIndex = 6;
            this.cbxPays3.Click += new System.EventHandler(this.CbxPays3_Click);
            // 
            // cbxPays2
            // 
            this.cbxPays2.AccessibleDescription = "C 2";
            this.cbxPays2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxPays2.Enabled = false;
            this.cbxPays2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPays2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPays2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxPays2.FormattingEnabled = true;
            this.cbxPays2.Location = new System.Drawing.Point(22, 43);
            this.cbxPays2.Name = "cbxPays2";
            this.cbxPays2.Size = new System.Drawing.Size(117, 21);
            this.cbxPays2.Sorted = true;
            this.cbxPays2.TabIndex = 5;
            this.cbxPays2.Click += new System.EventHandler(this.CbxPays2_Click);
            // 
            // btnEvolutionSerie
            // 
            this.btnEvolutionSerie.BackColor = System.Drawing.Color.Transparent;
            this.btnEvolutionSerie.Enabled = false;
            this.btnEvolutionSerie.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.btnEvolutionSerie.FlatAppearance.BorderSize = 0;
            this.btnEvolutionSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvolutionSerie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvolutionSerie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEvolutionSerie.Image = global::ResakssAddIn.Properties.Resources.bouton_start_chart__1_;
            this.btnEvolutionSerie.Location = new System.Drawing.Point(21, 120);
            this.btnEvolutionSerie.Name = "btnEvolutionSerie";
            this.btnEvolutionSerie.Size = new System.Drawing.Size(119, 47);
            this.btnEvolutionSerie.TabIndex = 7;
            this.btnEvolutionSerie.UseVisualStyleBackColor = false;
            this.btnEvolutionSerie.Click += new System.EventHandler(this.BtnEvolutionSerie_Click);
            // 
            // cbxPays1
            // 
            this.cbxPays1.AccessibleDescription = "C 1";
            this.cbxPays1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxPays1.Enabled = false;
            this.cbxPays1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPays1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPays1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbxPays1.FormattingEnabled = true;
            this.cbxPays1.Location = new System.Drawing.Point(22, 22);
            this.cbxPays1.Name = "cbxPays1";
            this.cbxPays1.Size = new System.Drawing.Size(117, 21);
            this.cbxPays1.Sorted = true;
            this.cbxPays1.TabIndex = 4;
            this.cbxPays1.SelectedIndexChanged += new System.EventHandler(this.CbxPays1_SelectedIndexChanged);
            this.cbxPays1.Click += new System.EventHandler(this.CbxPays1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::ResakssAddIn.Properties.Resources.bouton_view_data__1_;
            this.button1.Location = new System.Drawing.Point(8, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbxLabels
            // 
            this.cbxLabels.Checked = true;
            this.cbxLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLabels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLabels.ForeColor = System.Drawing.Color.White;
            this.cbxLabels.Location = new System.Drawing.Point(4, 619);
            this.cbxLabels.Name = "cbxLabels";
            this.cbxLabels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxLabels.Size = new System.Drawing.Size(118, 20);
            this.cbxLabels.TabIndex = 12;
            this.cbxLabels.Text = "Show Labels";
            this.cbxLabels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxLabels.UseVisualStyleBackColor = true;
            // 
            // txtAnnee
            // 
            this.txtAnnee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtAnnee.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnee.ForeColor = System.Drawing.Color.Gold;
            this.txtAnnee.Location = new System.Drawing.Point(806, 117);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.ReadOnly = true;
            this.txtAnnee.Size = new System.Drawing.Size(189, 39);
            this.txtAnnee.TabIndex = 10;
            this.txtAnnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnnee.Visible = false;
            // 
            // listPaysSelect
            // 
            this.listPaysSelect.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listPaysSelect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listPaysSelect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPaysSelect.ForeColor = System.Drawing.Color.Gold;
            this.listPaysSelect.Location = new System.Drawing.Point(822, 80);
            this.listPaysSelect.Name = "listPaysSelect";
            this.listPaysSelect.Size = new System.Drawing.Size(159, 120);
            this.listPaysSelect.TabIndex = 14;
            this.listPaysSelect.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(-2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 617);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 524);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 524);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(2, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 10;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.trackBar2);
            this.panel4.Location = new System.Drawing.Point(-1, 545);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 70);
            this.panel4.TabIndex = 0;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Orange;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(0, 35);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(732, 45);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(756, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 330);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(872, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Year: ";
            this.label1.Visible = false;
            // 
            // Valeur
            // 
            this.Valeur.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Valeur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Valeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Valeur.ForeColor = System.Drawing.Color.Gold;
            this.Valeur.Location = new System.Drawing.Point(872, 145);
            this.Valeur.Name = "Valeur";
            this.Valeur.Size = new System.Drawing.Size(51, 18);
            this.Valeur.TabIndex = 10;
            this.Valeur.Text = " Valors: ";
            this.Valeur.Visible = false;
            // 
            // lblValeur
            // 
            this.lblValeur.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblValeur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValeur.ForeColor = System.Drawing.Color.Gold;
            this.lblValeur.Location = new System.Drawing.Point(804, 170);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(196, 32);
            this.lblValeur.TabIndex = 8;
            this.lblValeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValeur.Visible = false;
            // 
            // lblAnnee
            // 
            this.lblAnnee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAnnee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnnee.ForeColor = System.Drawing.Color.Gold;
            this.lblAnnee.Location = new System.Drawing.Point(830, 77);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(140, 34);
            this.lblAnnee.TabIndex = 7;
            this.lblAnnee.Text = " ";
            this.lblAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnnee.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ResakssAddIn.Properties.Resources.circle_icon_png_276665;
            this.pictureBox1.Location = new System.Drawing.Point(750, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartesianChart1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 616);
            this.panel1.TabIndex = 19;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.White;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(744, 614);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // Form_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 745);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_BD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_BD_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckedListBox cblPays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnColumnSeries;
        private System.Windows.Forms.RadioButton rbtnConstantChange;
        private System.Windows.Forms.RadioButton rbtnLineSeries;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Valeur;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxGeopMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEvolutionSerie;
        private System.Windows.Forms.ComboBox cbxPays3;
        private System.Windows.Forms.ComboBox cbxPays2;
        private System.Windows.Forms.ComboBox cbxPays1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbxLabels;
        protected System.Windows.Forms.TextBox textBox2;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtAnnee;
        protected System.Windows.Forms.ListView listPaysSelect;
        protected System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Button btnSaveChart;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}