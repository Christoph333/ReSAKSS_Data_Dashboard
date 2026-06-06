using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//using System.Data.SQLite;
using System.IO;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using DataTable = System.Data.DataTable;

using Timer = System.Windows.Forms.Timer;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing.Imaging;
using System.Reflection;
using Microsoft.Data.Sqlite;
using System.Deployment.Application;

namespace ResakssAddIn
{
    public partial class Form_BD : Form
    {
    
        private string ReturnValue1 { get; set; }
        private Random random = new Random();
        private LiveCharts.SeriesCollection SeriesCollection { get; set; }
        private static IList<string> paysIncluList = new List<string>();
        private static IList<string> anneeList = new List<string>();
        private string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"ResakssDB.db");
       // private string fileNameMap = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"World.xml");
        private string fileNameMap = Path.Combine((ApplicationDeployment.CurrentDeployment.DataDirectory + @"\World.xml"));



        public string QueryAll { get; set; }
        public string tableName { get; set; }
//        private SQLiteDataAdapter da = new SQLiteDataAdapter();
        private DataTable dg = new DataTable();
        private DataTable dtpays = new DataTable("paysTable");
        private DataTable dtAnnee = new DataTable("anneeTable");
        private System.Data.DataSet dataset;
        private System.Data.DataSet datasetAnnee;

        public Form_BD()
        {
            InitializeComponent();

            DataAccess.InitializeDatabase();

            //QueryAll = "select * from VA_Agriculture;";
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.Zoom = ZoomingOptions.X;
            //lets configure the chart to plot cities
            //  LoadData();
            ToolTip1.SetToolTip(this.btnEffacer, "Panel d'Options.");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogueForm frm = new DialogueForm();
            frm.QueryAll2 = QueryAll;
            frm.tableName2 = tableName;
            frm.ShowDialog();

        }

        private LineSeries lNewSeries { get; set; }
        private LineSeries lNewSeries2 { get; set; }
        private LineSeries lNewSeries3 { get; set; }
        private System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

        private ColumnSeries cNewSeries { get; set; }
        private string SerieName;
        private List<string> ListPaysChx = new List<string>();
        private ChartValues<MeasureModel> ChartValues { get; set; }
        private ChartValues<MeasureModel> ChartValues2 { get; set; }
        private ChartValues<MeasureModel> ChartValues3 { get; set; }
        private int firstdisplay;
        private Timer Timer { get; set; }
        private Random R { get; set; }
        private ChartValues<double> pays = new ChartValues<double>();
        private ChartValues<double> pays2 = new ChartValues<double>();
        private ChartValues<double> pays3 = new ChartValues<double>();

        private ChartValues<double> Annee = new ChartValues<double>();
        private int count;
        private Dictionary<string, double> values = new Dictionary<string, double>();
        Dictionary<string, double> valuesPays = new Dictionary<string, double>();

        // Create a GeoMap control
        private LiveCharts.WinForms.GeoMap geoMap1 = new LiveCharts.WinForms.GeoMap();
        private LiveCharts.WinForms.GeoMap geoMap2 = new LiveCharts.WinForms.GeoMap();


        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {

            var now = System.DateTime.Now;

            if (cbxPays1.SelectedIndex > -1)
            {
                ChartValues.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = pays[count]

                });
            }
            if (cbxPays2.SelectedIndex > -1)
            {
                ChartValues2.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = pays2[count]

                });
            }
            if (cbxPays3.SelectedIndex > -1)
            {
                ChartValues3.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = pays3[count]

                });
            }
 
            SetAxisLimits(now);
            lblAnnee.Text = Annee[count].ToString();
            if (cbxPays1.SelectedIndex > -1 & cbxPays2.SelectedIndex > -1 & cbxPays3.SelectedIndex > -1)
            {
                lblValeur.Text = pays[count].ToString() + " | " + pays2[count].ToString() + " | " + pays3[count].ToString();
            }
            if (cbxPays1.SelectedIndex > -1 & cbxPays2.SelectedIndex > -1 & cbxPays3.SelectedIndex == -1)
            {
                lblValeur.Text = pays[count].ToString() + " | " + pays2[count].ToString();
            }
            if (cbxPays1.SelectedIndex > -1 & cbxPays2.SelectedIndex == -1 & cbxPays3.SelectedIndex > -1)
            {
                lblValeur.Text = pays[count].ToString() +  " | " + pays3[count].ToString();
            }
            if (cbxPays1.SelectedIndex == -1 & cbxPays2.SelectedIndex > -1 & cbxPays3.SelectedIndex > -1)
            {
                lblValeur.Text = pays2[count].ToString() + " | " + pays3[count].ToString();
            }
            if (cbxPays1.SelectedIndex > -1 & cbxPays2.SelectedIndex == -1 & cbxPays3.SelectedIndex == -1)
            {
                lblValeur.Text = pays[count].ToString() ;
            }
            if (cbxPays1.SelectedIndex == -1 & cbxPays2.SelectedIndex > -1 & cbxPays3.SelectedIndex == -1)
            {
                lblValeur.Text = pays2[count].ToString();
            }
            if (cbxPays1.SelectedIndex == -1 & cbxPays2.SelectedIndex == -1 & cbxPays3.SelectedIndex > -1)
            {
                lblValeur.Text = pays3[count].ToString();
            }

            count = count + 1;
            //lets only use the last 100 values
            if (ChartValues.Count > 100) ChartValues.RemoveAt(0);
            if (ChartValues2.Count > 100) ChartValues2.RemoveAt(0);
            if (ChartValues3.Count > 100) ChartValues3.RemoveAt(0);

            if (count == pays.Count | count == pays2.Count | count == pays3.Count)
            {
                count = 0; //initialiser à la premiere valeur
                           // Timer.Stop();
                ChartValues.Clear();
                ChartValues2.Clear();
                ChartValues3.Clear();
            }
        }
  
        private void CblPays_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listPaysSelect.Visible = true;
            if (firstdisplay == 1)
            {
                cartesianChart1.Series.RemoveAt(0);
                firstdisplay = 0;
                btnEffacer.Enabled = true;
            }
            if (count != 0)
            {
                Timer.Stop();
                cartesianChart1.Series.Clear();
                cartesianChart1.AxisX.Clear();
                //Axe de la chart
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Year",
                    Labels = anneeList
                });
                count = 0;

              //**************************************************
                listPaysSelect.Visible = false;
                Valeur.Visible = false;
                lblValeur.Visible = false;
                lblAnnee.Visible = false;
                label1.Visible = false;
            }

            #region
            /*************************POUR FAIRE LINE SERIES*************************/
            if (rbtnLineSeries.Checked)
            {



                if ((e.CurrentValue == CheckState.Unchecked))
                {


                    string QuerryNew = cblPays.Items[e.Index].ToString();

                    ListPaysChx.Add(QuerryNew);
                    listPaysSelect.Items.Add(QuerryNew);

                    // Ajouter le pays à la carte               
                    //************************************************************************************
                    valuesPays.Add(cblPays.Items[e.Index].ToString(), random.Next(1000));
                    var lang = new Dictionary<string, string>();
                    lang["MX"] = "México"; // change the language if necessary

                    //geoMap2 = new LiveCharts.WinForms.GeoMap();
                    geoMap2.HeatMap = valuesPays;
                    geoMap2.LanguagePack = lang;
                    geoMap2.Source = fileNameMap;
                    this.panel3.Controls.Remove(geoMap2);

                    this.panel3.Controls.Add(geoMap2);
                    geoMap2.Dock = DockStyle.Fill;

                   // geoMap2.LandClick += GeoMap1_LandClick;

                    geoMap2.Size = new System.Drawing.Size(109, 109);
                    //*******************************************************************************************

                    ChartValues<double> pays = new ChartValues<double>();

                    for (int l = 0; l <= dg.Rows.Count - 1; l++)
                    {
                        if (!DBNull.Value.Equals(dg.Rows[l][QuerryNew]))
                        {
                            pays.Add(Convert.ToDouble(dg.Rows[l][QuerryNew].ToString()));

                        }
                        else
                        {
                            pays.Add(double.NaN);

                        }
                    }

                    SerieName = QuerryNew;
                    if (cbxLabels.Checked) // Avec labels
                    {
                        lNewSeries = new LineSeries
                        {
                            Title = SerieName,
                            DataLabels = true,
                            Values = pays

                        };
                    }
                    else //Sans Labels
                    {
                        lNewSeries = new LineSeries
                        {
                            Title = SerieName,
                           // DataLabels = true,
                            Values = pays

                        };
                    }
                    cartesianChart1.Series.Add(
                                 lNewSeries

                                 );

                    pays = null;

                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    // Determine if there are any items checked.  
                    if (cblPays.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items and print results.  
                        string s = "";

                        s = cblPays.Items[e.Index].ToString();
                        for (int i = 0; i <= ListPaysChx.Count - 1; i++)
                        {
                            if (s == ListPaysChx[i].ToString())
                            {
                                cartesianChart1.Series.RemoveAt(i);
                                ListPaysChx.Remove(s);
                                listPaysSelect.Items.RemoveAt(i);
                                // Supprimé le pays à la carte               
                                //************************************************************************************
                                valuesPays.Remove(cblPays.Items[e.Index].ToString());
                                var lang = new Dictionary<string, string>();
                                lang["MX"] = "México"; // change the language if necessary
                                
                                geoMap2.HeatMap = valuesPays;
                                geoMap2.LanguagePack = lang;
                                geoMap2.Source = fileNameMap;
                                this.panel3.Controls.Remove(geoMap2);

                                this.panel3.Controls.Add(geoMap2);
                                geoMap2.Dock = DockStyle.Fill;

                               // geoMap2.LandClick += GeoMap1_LandClick;

                                geoMap2.Size = new System.Drawing.Size(109, 109);
                                //*******************************************************************************************


                                break; //Areter la recherche 
                            }
                        }
                        //break;

                        SerieName = null;

                    }



                }
            }
            #endregion
            /*************************POUR FAIRE COLUMN SERIES*************************/
            #region
            if (rbtnColumnSeries.Checked)
            {


                if ((e.CurrentValue == CheckState.Unchecked))
                {
                 

                    string QuerryNew = cblPays.Items[e.Index].ToString();
                    ListPaysChx.Add(QuerryNew);
                    listPaysSelect.Items.Add(QuerryNew);

                    // Ajouter le pays à la carte               
                    //************************************************************************************
                    valuesPays.Add(cblPays.Items[e.Index].ToString(), random.Next(1000));
                    var lang = new Dictionary<string, string>();
                    lang["MX"] = "México"; // change the language if necessary

                   
                    //geoMap2 = new LiveCharts.WinForms.GeoMap();
                    geoMap2.HeatMap = valuesPays;
                    geoMap2.LanguagePack = lang;
                    geoMap2.Source = fileNameMap;
                    this.panel3.Controls.Remove(geoMap2);

                    this.panel3.Controls.Add(geoMap2);
                    geoMap2.Dock = DockStyle.Fill;

                   // geoMap2.LandClick += GeoMap1_LandClick;

                    geoMap2.Size = new System.Drawing.Size(109, 109);

                    //************************************************************

                    ChartValues<double> pays = new ChartValues<double>();

                    for (int l = 0; l <= dg.Rows.Count - 1; l++)
                    {
                        if (!DBNull.Value.Equals(dg.Rows[l][QuerryNew]))
                        {
                            pays.Add(Convert.ToDouble(dg.Rows[l][QuerryNew]));


                        }
                        else
                        {
                            pays.Add(0);

                        }
                    }

                    SerieName = QuerryNew;
                    if (cbxLabels.Checked) // Avec labels
                    {
                        cNewSeries = new ColumnSeries
                        {
                            Title = SerieName,
                            DataLabels = true,
                            Values = pays

                        };
                    } else // Sans label
                    {
                        cNewSeries = new ColumnSeries
                        {
                            Title = SerieName,
                           // DataLabels = true, 
                            Values = pays

                        };
                    }
                    cartesianChart1.Series.Add(
                                 cNewSeries

                                 );

                    pays = null;

                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    // Determine if there are any items checked.  
                    if (cblPays.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items and print results.  
                        string s = "";

                        s = cblPays.Items[e.Index].ToString();
                        for (int i = 0; i <= ListPaysChx.Count - 1; i++)
                        {
                            if (s == ListPaysChx[i].ToString())
                            {
                                cartesianChart1.Series.RemoveAt(i);
                                ListPaysChx.Remove(s);
                                listPaysSelect.Items.RemoveAt(i);
                                // Supprimé le pays à la carte               
                                //************************************************************************************
                                valuesPays.Remove(cblPays.Items[e.Index].ToString());
                                var lang = new Dictionary<string, string>();
                                lang["MX"] = "México"; // change the language if necessary

                                geoMap2.HeatMap = valuesPays;
                                geoMap2.LanguagePack = lang;
                                geoMap2.Source = fileNameMap;
                                this.panel3.Controls.Remove(geoMap2);

                                this.panel3.Controls.Add(geoMap2);
                                geoMap2.Dock = DockStyle.Fill;

                                // geoMap2.LandClick += GeoMap1_LandClick;

                                geoMap2.Size = new System.Drawing.Size(109, 109);
                                //*******************************************************************************************


                                break; //Areter la recherche 
                            }
                        }
                        //break;

                        SerieName = null;

                    }



                }
            }
            #endregion

        }

        private void BtnEffacer_Click(object sender, EventArgs e)
        {
           // listPaysSelect = null;
           // ListPaysChx = null;

            panel3.Visible = false;
            for (int i = 0; i < cblPays.Items.Count-1; i++)

            {

                cblPays.SetItemChecked(i, false);

            }

            if (count != 0)
            {
                Timer.Stop();
                count = 0;
            }
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            //Axe de la chart
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Year",
                Labels = anneeList
            });
            panel3.Visible = true;
            //geoMap2 = new LiveCharts.WinForms.GeoMap();

            geoMap2.HeatMap = valuesPays;
           // geoMap2.LanguagePack = lang;
            geoMap2.Source = fileNameMap;
            this.panel3.Controls.Remove(geoMap2);

            this.panel3.Controls.Add(geoMap2);
            geoMap2.Dock = DockStyle.Fill;

           // geoMap2.LandClick += GeoMap1_LandClick;

            geoMap2.Size = new System.Drawing.Size(109, 109);

        }

        private void CartesianChart1_DataClick(object sender, ChartPoint chartPoint)
        {
            System.Windows.MessageBox.Show("You clicked (" + chartPoint.X + "," + chartPoint.Y + ")");

        }

        private void RbtnPays_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void RbtnConstantChange_CheckedChanged(object sender, EventArgs e)
        {
            listPaysSelect.Visible = false;
            cblPays.Visible = false;
            panel2.Visible = false;
            Valeur.Visible = true;
            lblValeur.Visible = true;
            lblAnnee.Visible = true;
            label1.Visible = true;
            //***************************************************
            cbxGeopMap.CheckState =0;


            cblPays.Enabled = false;
            cbxPays1.Enabled = true;
            cbxPays2.Enabled = true;
            cbxPays3.Enabled = true;
            btnStop.Enabled = true;
            btnEvolutionSerie.Enabled = true;
        }

        private void BtnEvolutionSerie_Click(object sender, EventArgs e)
        {
            count = 0; // initialiser
            btnEffacer.Enabled = true;
            listPaysSelect.Visible = false;
            cblPays.Visible = false;
            panel2.Visible = false;
            Valeur.Visible = true;
            lblValeur.Visible = true;
            lblAnnee.Visible = true;
            label1.Visible = true;

            pays = new ChartValues<double>();
            pays2 = new ChartValues<double>();
            pays3 = new ChartValues<double>();

            /*********************************************************************/
            if (cbxPays1.SelectedIndex > -1)
            {
                for (int l = 0; l <= dg.Rows.Count - 1; l++)
                {
                    if (!DBNull.Value.Equals(dg.Rows[l][cbxPays1.Text]))
                    {
                        pays.Add(Convert.ToDouble(dg.Rows[l][cbxPays1.Text]));


                    }
                    else
                    {
                        pays.Add(0);

                    }
                }
            }

            /********************************************************************/
            if (cbxPays2.SelectedIndex > -1)
            {
                for (int l = 0; l <= dg.Rows.Count - 1; l++)
                {
                    if (!DBNull.Value.Equals(dg.Rows[l][cbxPays2.Text]))
                    {
                        pays2.Add(Convert.ToDouble(dg.Rows[l][cbxPays2.Text]));


                    }
                    else
                    {
                        pays2.Add(0);

                    }
                }
            }


            /********************************************************************/
            if (cbxPays3.SelectedIndex > -1)
            {
                for (int l = 0; l <= dg.Rows.Count - 1; l++)
                {
                    if (!DBNull.Value.Equals(dg.Rows[l][cbxPays3.Text]))
                    {
                        pays3.Add(Convert.ToDouble(dg.Rows[l][cbxPays3.Text]));


                    }
                    else
                    {
                        pays3.Add(0);

                    }
                }
            }
        

            /********************************************************************/
          

            for (int l = 0; l <= dg.Rows.Count - 1; l++)
            {
                if (!DBNull.Value.Equals(dg.Rows[l]["Annee"]))
                {
                    Annee.Add(Convert.ToDouble(dg.Rows[l]["Annee"]));

                }
                else
                {
                    Annee.Add(0);

                }
            }



            #region
            if (rbtnConstantChange.Checked)
            {
                var mapper = Mappers.Xy<MeasureModel>()
               .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
               .Y(model => model.Value);           //use the value property as Y

                //lets save the mapper globally.
                Charting.For<MeasureModel>(mapper);

                //the ChartValues property will store our values array
                ChartValues = new ChartValues<MeasureModel>();
                ChartValues2 = new ChartValues<MeasureModel>();
                ChartValues3 = new ChartValues<MeasureModel>();

                SerieName = dg.Columns[0].ColumnName;
                if (cbxPays1.SelectedIndex > -1)
                {
                    lNewSeries = new LineSeries
                    {
                        Values = ChartValues,
                        PointGeometrySize = 9,
                        //StrokeThickness = 4
                        DataLabels = true,
                        Title = cbxPays1.Text

                    };
                }
                if (cbxPays2.SelectedIndex > -1)
                {
                    lNewSeries2 = new LineSeries
                    {
                        Values = ChartValues2,
                        PointGeometrySize = 9,
                        //StrokeThickness = 4
                        //  DataLabels = true,
                        Title = cbxPays2.Text
                    };
                }

                if (cbxPays3.SelectedIndex > -1)
                {
                    lNewSeries3 = new LineSeries
                    {
                        Values = ChartValues3,
                        PointGeometrySize = 9,
                        //StrokeThickness = 4
                        // DataLabels = true,
                        Title = cbxPays3.Text
                    };
                }



                if ((cbxPays1.SelectedIndex > -1) & (cbxPays2.SelectedIndex > -1) & (cbxPays3.SelectedIndex > -1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries,
                    lNewSeries2,
                    lNewSeries3
                };
                }
                else if ((cbxPays1.SelectedIndex > -1) & (cbxPays2.SelectedIndex > -1) & (cbxPays3.SelectedIndex == -1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries,
                    lNewSeries2
                    
                };
                }
                else if ((cbxPays1.SelectedIndex > -1) & (cbxPays2.SelectedIndex == -1) & (cbxPays3.SelectedIndex > -1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries,
                    lNewSeries3
                };
                }
                else if ((cbxPays1.SelectedIndex == -1) & (cbxPays2.SelectedIndex > -1) & (cbxPays3.SelectedIndex > -1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries2,
                    lNewSeries3
                };
                }
                if ((cbxPays1.SelectedIndex > -1) & (cbxPays2.SelectedIndex == -1) & (cbxPays3.SelectedIndex ==-1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries
                    
                };
                }
                if ((cbxPays1.SelectedIndex == -1) & (cbxPays2.SelectedIndex > -1) & (cbxPays3.SelectedIndex ==-1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    
                    lNewSeries2
                    
                };
                }
                if ((cbxPays1.SelectedIndex == -1) & (cbxPays2.SelectedIndex ==-1) & (cbxPays3.SelectedIndex > -1))
                {
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                {
                    lNewSeries3
                };
                }
                SetAxisLimits(System.DateTime.Now);

                //The next code simulates data changes every 500 ms
                Timer = new Timer
                {
                    Interval = 1000
                };
                Timer.Tick += TimerOnTick;
                // R = new Random();
                Timer.Start();
            }
            else
            {
                listPaysSelect.Visible = true;
                cblPays.Visible = true;
                //panel1.Visible = false;
                //Timer.Stop();
                // cartesianChart1.Series.Clear();

            }

            #endregion
        }

        private void RbtnLineSeries_CheckedChanged(object sender, EventArgs e)
        {
            cblPays.Visible = true;
            listPaysSelect.Visible = true;
            panel2.Visible = false;
            Valeur.Visible = false;
            lblValeur.Visible = false;
            lblAnnee.Visible = false;
            label1.Visible = false;
            //**********************************************
            cbxGeopMap.CheckState = 0;
            cblPays.Enabled = true;
            cbxPays1.Enabled = false;
            cbxPays2.Enabled = false;
            cbxPays3.Enabled = false;
            btnStop.Enabled = false;
            btnEvolutionSerie.Enabled = false;
        }

        private void RbtnColumnSeries_CheckedChanged(object sender, EventArgs e)
        {
            cblPays.Visible = true;
            listPaysSelect.Visible = true;
            panel2.Visible = false;
            Valeur.Visible = false;
            lblValeur.Visible = false;
            lblAnnee.Visible = false;
            label1.Visible = false;
            //***************************************************************
            cbxGeopMap.CheckState = 0;

            cblPays.Enabled = true;
            cbxPays1.Enabled = false;
            cbxPays2.Enabled = false;
            cbxPays3.Enabled = false;
            btnStop.Enabled = false;
            btnEvolutionSerie.Enabled = false;
        }

        private void Form_BD_Load(object sender, EventArgs e)
        {
            /*Creation de la liste des pays*/

            #region

            paysIncluList = new List<string>();
            paysIncluList.Add("Angola");
            paysIncluList.Add("Burundi");
            paysIncluList.Add("Benin");
            paysIncluList.Add("Burkina Faso");
            paysIncluList.Add("Botswana");
            paysIncluList.Add("Cameroon");
            paysIncluList.Add("Congo Republic");
            paysIncluList.Add("Djibouti");
            paysIncluList.Add("Algeria");
            paysIncluList.Add("Egypt");
            paysIncluList.Add("Eritrea");
            paysIncluList.Add("Gabon");
            paysIncluList.Add("Ghana");
            paysIncluList.Add("Guinea");
            paysIncluList.Add("Gambia");
            paysIncluList.Add("Guinea-Bissau");
            paysIncluList.Add("Equatorial Guinea");
            paysIncluList.Add("Liberia");
            paysIncluList.Add("Libya");
            paysIncluList.Add("Lesotho");
            paysIncluList.Add("Morocco");
            paysIncluList.Add("Madagascar");
            paysIncluList.Add("Mauritania");
            paysIncluList.Add("Malawi");
            paysIncluList.Add("Namibia");
            paysIncluList.Add("Nigeria");
            paysIncluList.Add("Rwanda");
            paysIncluList.Add("Western Sahara");
            paysIncluList.Add("Senegal");
            paysIncluList.Add("Sierra Leone");
            paysIncluList.Add("Swaziland");
            paysIncluList.Add("Togo");
            paysIncluList.Add("Tunisia");
            paysIncluList.Add("Uganda");
            paysIncluList.Add("South Africa");
            paysIncluList.Add("Zambia");
            paysIncluList.Add("Zimbabwe");
            paysIncluList.Add("Côte d'Ivoire");
            paysIncluList.Add("Congo Democratic");
            paysIncluList.Add("Central African Republic");
            paysIncluList.Add("South-Sudan");
            paysIncluList.Add("Ethiopia");
            paysIncluList.Add("Somalia");
            paysIncluList.Add("Kenya");
            paysIncluList.Add("Tanzania");
            paysIncluList.Add("Mozambique");
            paysIncluList.Add("Chad");
            paysIncluList.Add("Niger");
            paysIncluList.Add("Sudan");
            paysIncluList.Add("Mali");
            paysIncluList.Add("Cape Verde");
            paysIncluList.Add("São Tomé and Príncipe");
            paysIncluList.Add("Comoros");
            paysIncluList.Add("Reunion");
            paysIncluList.Add("Mauritius");

            #endregion

            /*CONNECTION REQUETE ET CREATION DES DATATABLE*/

            #region
            using (SqliteConnection db =
                new SqliteConnection("Filename="+ fileName))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    (QueryAll, db);

                // SqliteDataReader query = selectCommand.ExecuteReader();
                using (SqliteDataReader query = selectCommand.ExecuteReader())
                {
                    DataTable dgSchema = query.GetSchemaTable();
                     dg = new DataTable();
                    if (dgSchema != null)
                        if (dgSchema.Rows.Count > 0)
                            for (int i = 0; i < dgSchema.Rows.Count; i++)
                            {
                                DataColumn Col = new DataColumn(dgSchema.Rows[i]["ColumnName"].ToString(), (Type)dgSchema.Rows[i]["DataType"]);
                                Col.AllowDBNull = true;
                                Col.Unique = false;
                                Col.AutoIncrement = false;
                                dg.Columns.Add(Col);
                            }

                    while (query.Read())
                    {
                        //Read data and fill it to our datatable
                        DataRow Row = dg.NewRow();
                        for (int i = 0; i < dg.Columns.Count; i++)
                        {
                            Row[i] = query[i];
                        }
                        dg.Rows.Add(Row);
                    }           
                }
            

                db.Close();
            }

            /*******Tracbar valeur*******/

            dtpays.Columns.Add(new DataColumn("id", typeof(string)));
            dtpays.Columns.Add(new DataColumn("valeur", typeof(double)));

            /*******Tracbar Annee*******/

            dtAnnee.Columns.Add(new DataColumn("id", typeof(string)));
            dtAnnee.Columns.Add(new DataColumn("valeur", typeof(double)));

            DataRow dr = dtpays.NewRow();

            /*************************************/

            for (int l = 0; l <= dg.Rows.Count - 1; l++)
            {
                if (!DBNull.Value.Equals(dg.Rows[l][0]))
                {
                    dtAnnee.Rows.Add(dg.Rows[l][0].ToString(), Convert.ToDouble(dg.Rows[l][0]));
                }
                else
                {
                    dtAnnee.Rows.Add(9999, 9999);
                }
            }

            /*****Pour Annee******/
            DataView dv = dtpays.DefaultView;
            DataTable sortedDT = dv.ToTable();
            dv = dtAnnee.DefaultView;
            dv.Sort = "valeur asc";
            sortedDT = dv.ToTable();

            datasetAnnee = new DataSet();
            datasetAnnee.Tables.Add(sortedDT);
            #endregion

            /*CHARGER LES DATASET DE GEOMAP*/
            #region
            for (int l = 0; l <= dg.Columns.Count - 1; l++)
            {

                if (!DBNull.Value.Equals(dg.Rows[dg.Rows.Count-1][l]) & (dg.Columns[l].ColumnName!="Annee"))
                {
                    // pays.Add(Convert.ToDouble(dg.Rows[l][0]));
                    values.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[dg.Rows.Count-1][l]));
                    dtpays.Rows.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[dg.Rows.Count-1][l]));

                }
                else
                {
                    values.Add(dg.Columns[l].ColumnName, 0);
                    dtpays.Rows.Add(dg.Columns[l].ColumnName, 0);
                }


            }

            DataView dv2 = dtpays.DefaultView;
            dv2.Sort = "valeur asc";
            DataTable sortedDT2 = dv2.ToTable();

            dataset = new DataSet();
            dataset.Tables.Add(sortedDT2);

            // Ajouter les pays à la carte               
            //************************************************************************************

            var lang = new Dictionary<string, string>();
            lang["Togo"] = "Français"; // langue

            geoMap1.HeatMap = values;
            geoMap1.LanguagePack = lang;
            geoMap1.Source = fileNameMap;
           
            // this.panel3.Controls.Remove(geoMap2);

            this.panel2.Controls.Add(geoMap1);

            // geoMap1.Dock = DockStyle.Fill;

            geoMap1.LandClick += GeoMap1_LandClick;
            geoMap1.LandInfo += GeoMap1_LandInfo;
            geoMap1.Size = new System.Drawing.Size(735, 525);
            //*******************************************************************************************

            // Dock the PictureBox to the form and set its background to white.
            pictureBox2.Dock = DockStyle.Fill;
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.panel4.Controls.Add(pictureBox2);

            // Chargé la trackBar
            fnGetDataBindings();

            #endregion

            #region
            // Remplir dynamiquemment le checkboslist
            for (int l = 0; l <= dg.Columns.Count - 1; l++)
            {
                if (dg.Columns[l].ColumnName != "Annee")
                {
                    cblPays.Items.Add(dg.Columns[l].ColumnName.ToString());
                    cbxPays1.Items.Add(dg.Columns[l].ColumnName.ToString());
                    cbxPays2.Items.Add(dg.Columns[l].ColumnName.ToString());
                    cbxPays3.Items.Add(dg.Columns[l].ColumnName.ToString());
                }
            }

            #endregion

            //con.Close();
            for (int r = 0; r < dg.Rows.Count; r++)
            {
                anneeList.Add(dg.Rows[r][0].ToString());
            }
            //Axe de la chart
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Year",
                Labels = anneeList
            });

            //Courbe par defaut
            ChartValues<double> pays = new ChartValues<double>();

            for (int l = 0; l <= dg.Rows.Count - 1; l++)
            {
                if (!DBNull.Value.Equals(dg.Rows[l]["Africa wide"]))
                {
                    pays.Add(Convert.ToDouble(dg.Rows[l]["Africa wide"]));


                }
                else
                {
                    pays.Add(0);

                }
            }

            SerieName = "Africa wide";
          
                lNewSeries = new LineSeries
                {
                    Title = SerieName,
                    DataLabels = true,
                    Values = pays

                };
            
            cartesianChart1.Series.Add(
                         lNewSeries

                         );
            firstdisplay = 1;
            pays = null;


            //****************************************************************

            // Ajouter le pays à la carte               
            //************************************************************************************
            
            lang["MX"] = "Togo"; // change the language if necessary

            geoMap2.HeatMap = valuesPays;
            geoMap2.LanguagePack = lang;
            geoMap2.Source = fileNameMap;
            this.panel3.Controls.Remove(geoMap2);

            this.panel3.Controls.Add(geoMap2);
            geoMap2.Dock = DockStyle.Fill;

           geoMap2.LandClick += GeoMap1_LandClick;

            geoMap2.Size = new System.Drawing.Size(109, 109);

        }
        private void GeoMap1_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            // Display the ID of the clicked element in the map
            // e.g "FR", "DE"
            //Console.WriteLine(arg2.Id);
           
            if (values.TryGetValue(arg2.Id,out double t))
            {
                System.Windows.Forms.MessageBox.Show(arg2.Id + " : \r" + values[arg2.Id]);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(arg2.Id + " : \r" + "No Data");
            }
        }
        private void GeoMap1_LandInfo(object arg1, LiveCharts.Maps.MapData arg2)
        {
            // Display the ID of the clicked element in the map
            // e.g "FR", "DE"
            Console.WriteLine(arg2.Id);
            // System.Windows.Forms.MessageBox.Show(arg2.Id);
            ToolTip1.SetToolTip(this.geoMap1, arg2.Id);

        }

                                /*MAP DEFAULT*/

        private void BtnMapView_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            txtAnnee.Visible = true;
            count = 0; // initialiser

            // int totalColumn = dg.Columns.Count;
            // int totalRow = dg.Rows.Count;

            for (int l = 0; l <= dg.Columns.Count - 1; l++)
            {
                for (int p = 0; p <= paysIncluList.Count - 1; p++)
                {
                    if (paysIncluList[p].ToString() == dg.Columns[l].ColumnName.ToString())
                    {
                        if (!DBNull.Value.Equals(dg.Rows[22][l]))
                        {
                            // pays.Add(Convert.ToDouble(dg.Rows[l][0]));
                            values.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[22][l]));
                            dtpays.Rows.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[22][l]));

                        }
                        else
                        {
                            values.Add(dg.Columns[l].ColumnName, 0);
                            dtpays.Rows.Add(dg.Columns[l].ColumnName, 0);
                        }
                    }
                }
            }



            DataView dv = dtpays.DefaultView;
            dv.Sort = "valeur asc";
            DataTable sortedDT = dv.ToTable();

            dataset = new DataSet();
            dataset.Tables.Add(sortedDT);




            // Ajouter les pays à la carte               
            //************************************************************************************

            var lang = new Dictionary<string, string>();
            lang["Togo"] = "Français"; // langue

            geoMap1.HeatMap = values;
            geoMap1.LanguagePack = lang;
            geoMap1.Source = fileNameMap;

            // this.panel3.Controls.Remove(geoMap2);

            this.panel2.Controls.Add(geoMap1);

            // geoMap1.Dock = DockStyle.Fill;

            geoMap1.LandClick += GeoMap1_LandClick;
            geoMap1.LandInfo += GeoMap1_LandInfo;
            geoMap1.Size = new System.Drawing.Size(735, 525);
            //*******************************************************************************************

            // Dock the PictureBox to the form and set its background to white.
            pictureBox2.Dock = DockStyle.Fill;
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.panel4.Controls.Add(pictureBox2);

            // Chargé la trackBar
            fnGetDataBindings();


        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        // Fill the rectangle with a gradient

        private void ShadeRect(Graphics gr, float xmin, float xmax)
        {

            //Create Map Legend

            using (LinearGradientBrush br = new LinearGradientBrush(
                new PointF(xmin, 0), new PointF(xmax, 0),
                System.Drawing.Color.Red, System.Drawing.Color.Green))
            {
                br.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;

                System.Drawing.Drawing2D.ColorBlend color_blend = new System.Drawing.Drawing2D.ColorBlend();
                //color_blend.Colors = new System.Drawing.Color[] { System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Yellow };

                /*
                DataTable tble = geoMap1.LegendValue;

                Color[] myColors = new System.Drawing.Color[tble.Rows.Count];
                float[] myPositions = new float[tble.Rows.Count];

                System.Windows.MessageBox.Show(tble.Rows.Count.ToString());
                for (int l = 0; l < tble.Rows.Count; l++)
                {
                    //color_blend.Colors.Append(System.Drawing.ColorTranslator.FromHtml(tble.Rows[l][0].ToString()));
                    // color_blend.Colors.Append(System.Drawing.ColorTranslator.FromHtml("#FFFFFF"));
                    //System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    myColors[l]= System.Drawing.ColorTranslator.FromHtml(tble.Rows[l][0].ToString());
                    myPositions[l]=(float) l/(tble.Rows.Count-1);

                }
                */

                Color[] myColors = {Color.Red,
                           Color.Pink,
                           Color.Yellow,
                           Color.Blue,
                           Color.Green};
                float[] myPositions = { 0.0f, .25f, .50f, .75f, 1.0f };

                color_blend.Colors = myColors;
                color_blend.Positions = myPositions;
               // color_blend.Positions = new float[] { 0, 0.5f, 1 };

                br.InterpolationColors = color_blend;
                gr.FillRectangle(br, ClientRectangle);
                
            }
        }
        private float GradientStart = 0;
        private float Delta = 5f;

    
        private PictureBox pictureBox2 = new PictureBox();
        // Cache font instead of recreating font objects each time we paint.
        private System.Drawing.Font fnt = new System.Drawing.Font("Arial", 10);

        private void Button2_Click(object sender, EventArgs e)
        {
            // Dock the PictureBox to the form and set its background to white.
            pictureBox2.Dock = DockStyle.None;
            pictureBox2.Location= new System.Drawing.Point(53, 563);
            this.pictureBox2.Size = new System.Drawing.Size(400, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.BackColor = Color.White;
            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            // Add the PictureBox control to the Form.
            this.panel2.Controls.Add(pictureBox2);
        }
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Shade the background.
            int wid = pictureBox2.ClientSize.Width;
            ShadeRect(e.Graphics, GradientStart, GradientStart + wid);
            // Increase the start position.
            GradientStart += Delta;
            if (GradientStart >= wid) GradientStart = 0;

            // VALEUR MIN.
            using (System.Drawing.Font font = new System.Drawing.Font("Times New Roman",
                12, System.Drawing.FontStyle.Bold))
            {
                using (StringFormat string_format = new StringFormat())
                {
                    string_format.Alignment = StringAlignment.Center;
                    string_format.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(dataset.Tables[0].Rows[0][1].ToString(),
                        font, System.Drawing.Brushes.White,
                        4,
                        8,
                        string_format);
                }
            }

            // VALEUR MAX.
            using (System.Drawing.Font font = new System.Drawing.Font("Times New Roman",
                12, System.Drawing.FontStyle.Bold))
            {
                using (StringFormat string_format = new StringFormat())
                {
                    string_format.Alignment = StringAlignment.Center;
                    string_format.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(dataset.Tables[0].Rows[dataset.Tables[0].Rows.Count-1][1].ToString(),
                        font, System.Drawing.Brushes.White,
                        692,
                        8,                        
                        string_format);
                }
            }
        }


        //Scroll event occurs when either a mouse or keyboard action moves the slider
        private void trackBar2_Scroll(object sender, System.EventArgs e)
        {
            int recordNr;

            //	Pass the table "paysTable" to the BindingContext as the bound control
            // and pass the current position of the slider on the track bar to "recordNr"
            recordNr = this.BindingContext[dataset, "paysTable"].Position = this.trackBar2.Value;
            ++recordNr; //increment by 1 because we don´t want recordNr beginning by 0
                        //display the position in Label
            this.label3.Text = "Record :    " + recordNr.ToString();
            //check if any records in the table
            if ((this.BindingContext[dataset, "paysTable"].Position) < (this.BindingContext[dataset, "paysTable"].Count - 1))
            {
                this.BindingContext[dataset, "paysTable"].Position += 1; //go to next row
            }
            else
            {
                //inform the user about the end of the records	
                csShowMessageBox.fnShowMessageBoxWithParameters("You´ve reached the end of the records",
                                 "LAST RECORD: " + recordNr.ToString(),
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information, 0, 0);
            }
            //check if we are at the first row in the table and if yes inform the user
            if (this.BindingContext[dataset, "paysTable"].Position == 1)
                csShowMessageBox.fnShowMessageBoxWithParameters("You´ve reached the beginning of the records",
                "FIRST RECORD: " + recordNr.ToString(),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information, 0, 0);
        }

 
        private void fnGetDataBindings()
        {
            this.label3.Text = "Record :     " + ((this.BindingContext[dataset, "paysTable"].Position + 1).ToString());
            this.textBox1.DataBindings.Add("Text", dataset, "paysTable.id");
            this.textBox2.DataBindings.Add("Text", dataset, "paysTable.valeur");
           
            //to TackBar.Maximum poperties
            this.trackBar2.Maximum = this.BindingContext[dataset, "paysTable"].Count - 1;
           
            /*********************/
            this.txtAnnee.DataBindings.Add("Text", datasetAnnee, "anneeTable.id");
            this.trackBar1.Maximum = this.BindingContext[datasetAnnee, "anneeTable"].Count - 1;

        }
        private void fnGetDataBindings2()
        {
            this.label3.Text = null;
            this.textBox1.DataBindings.Clear();
            this.textBox2.DataBindings.Clear();

            //to TackBar.Maximum poperties
           // this.trackBar2.Maximum = this.BindingContext[dataset, "paysTable"].Count - 1;

            /*********************/
            this.txtAnnee.DataBindings.Clear();
           // this.trackBar1.Maximum = this.BindingContext[datasetAnnee, "anneeTable"].Count - 1;

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            GradientStart = 0;
            Delta = 5f;
            int recordNr;
            recordNr = this.BindingContext[datasetAnnee, "anneeTable"].Position = this.trackBar1.Value;
            ++recordNr;
           // recordNr = this.BindingContext[datasetAnnee, "anneeTable"].Position = this.trackBar1.Value;

            #region

            dtpays = new DataTable("paysTable");
            /*******Tracbar valeur*******/

            dtpays.Columns.Add(new DataColumn("id", typeof(string)));
            dtpays.Columns.Add(new DataColumn("valeur", typeof(double)));

            values = new Dictionary<string, double>();

            // int totalColumn = dg.Columns.Count;
            // int totalRow = dg.Rows.Count;

            for (int l = 0; l <= dg.Columns.Count - 1; l++)
            {
                for (int p = 0; p <= paysIncluList.Count - 1; p++)
                {
                    if (paysIncluList[p].ToString() == dg.Columns[l].ColumnName.ToString())
                    {
                        if (!DBNull.Value.Equals(dg.Rows[recordNr-1][l]))
                        {
                            // pays.Add(Convert.ToDouble(dg.Rows[l][0]));
                            values.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[recordNr-1][l]));
                            dtpays.Rows.Add(dg.Columns[l].ColumnName, Convert.ToDouble(dg.Rows[recordNr-1][l]));

                        }
                        else
                        {
                            values.Add(dg.Columns[l].ColumnName, 0);
                            dtpays.Rows.Add(dg.Columns[l].ColumnName, 0);
                        }
                    }
                }
            }

            /*************************************/


            DataView dv = dtpays.DefaultView;
            dv.Sort = "valeur asc";
            DataTable sortedDT = dv.ToTable();

            dataset = new DataSet();
            dataset.Tables.Add(sortedDT);

         //   fnGetDataBindings();
            // Ajouter les pays à la carte               
            //************************************************************************************

            var lang = new Dictionary<string, string>();
            lang["Togo"] = "Français"; // langue
            this.panel2.Controls.Remove(geoMap1);
            geoMap1 = new LiveCharts.WinForms.GeoMap();
            geoMap1.HeatMap = values;
            geoMap1.LanguagePack = lang;
            geoMap1.Source = fileNameMap;

            this.panel2.Controls.Add(geoMap1);

            // geoMap1.Dock = DockStyle.Fill;

            geoMap1.LandClick += GeoMap1_LandClick;
            geoMap1.LandInfo += GeoMap1_LandInfo;
            geoMap1.Size = new System.Drawing.Size(735, 525);
            //*******************************************************************************************
            //pictureBox2 = null;
            this.panel4.Controls.Remove(pictureBox2);
            this.pictureBox2 = new PictureBox();
            this.pictureBox2.BackColor = Color.Transparent;
            this.pictureBox2.Dock = DockStyle.Fill;
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.BackColor = Color.White;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.panel4.Controls.Add(pictureBox2);

            /*Trackbar*/

            fnGetDataBindings2();
            fnGetDataBindings();

            #endregion


            #region
            if ((this.BindingContext[datasetAnnee, "anneeTable"].Position) < (this.BindingContext[datasetAnnee, "anneeTable"].Count - 1))
            {
                this.BindingContext[datasetAnnee, "anneeTable"].Position += 1; //go to next row
            }
            else
            {
                csShowMessageBox.fnShowMessageBoxWithParameters("You´ve reached the end of the records",
                                 "LAST RECORD: " + recordNr.ToString(),
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information, 0, 0);
            }

            //check if we are at the first row in the table and if yes inform the user
            if (this.BindingContext[datasetAnnee, "anneeTable"].Position == 1)
                csShowMessageBox.fnShowMessageBoxWithParameters("You´ve reached the beginning of the records",
                "FIRST RECORD: " + recordNr.ToString(),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information, 0, 0);
            #endregion
        }


        private void CbxGeopMap_CheckedChanged(object sender, EventArgs e)
        {
            listPaysSelect.Visible = false;
            //**************************************************
            listPaysSelect.Visible = false;
            Valeur.Visible = false;
            lblValeur.Visible = false;
            lblAnnee.Visible = false;
            label1.Visible = false;
            //*************************************************

            if (cbxGeopMap.Checked)
            {
                panel2.Visible = true;
                txtAnnee.Visible = true;
            }
            else
            {
                panel2.Visible = false;
                txtAnnee.Visible = false;
                geoMap1 = null;
            }
        }

        private void SplitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                Timer.Stop();
            }
        }

        private void CbxPays1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CbxPays1_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                Timer.Stop();
            }
        }

        private void CbxPays2_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                Timer.Stop();
            }
        }

        private void CbxPays3_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                Timer.Stop();
            }
            
        }

        private void BtnSaveChart_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                int width = panel2.Size.Width;
                int height = panel2.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                panel2.DrawToBitmap(bm, new Rectangle(0, 0, width, height));


                //*****************************************
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
                sf.ShowDialog();
                var path = sf.FileName;

                //****************************************
                bm.Save(@path, ImageFormat.Bmp);
            }
            else
            {
                int width = panel1.Size.Width;
                int height = panel1.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));


                //*****************************************
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
                sf.ShowDialog();
                var path = sf.FileName;

                //****************************************
                bm.Save(@path, ImageFormat.Bmp);
            }
        }
    }

}

