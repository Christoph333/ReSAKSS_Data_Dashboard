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

namespace ResakssAddIn
{
    public partial class Form_Principal : Form
    {


        public Form_Principal()
        {
            InitializeComponent();

        }
        private int current_tab_count;
        public string firstquery { get; set; }
        System.Collections.ArrayList tabpages = new System.Collections.ArrayList();
        System.Collections.ArrayList webpages = new System.Collections.ArrayList();

        public void Create_New_Tab(string querry)
        {
            //if (current_tab_count == 10) return;
             TabPage newpage = new TabPage(querry);
             Form_BD webpage = new Form_BD();

             webpages.Add(webpage);
             tabpages.Add(newpage);
            // newpage.Controls.Add(this.tabPage1);
             tabControl1.TabPages.Add(newpage);
             current_tab_count++;

            //Ajouter une nouvelle vue

            //Form_BD frm = new Form_BD();
            
            webpage.QueryAll = "select * from [" + querry + "];";
            webpage.tableName = querry;
            webpage.TopLevel = false;
            newpage.Controls.Add(webpage);
            webpage.FormBorderStyle = FormBorderStyle.None;
            webpage.Dock = DockStyle.Fill;

            webpage.Show();
            
            tabControl1.SelectedTab = newpage;

        }

        private void BtnNewView_Click(object sender, EventArgs e)
        {
         
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            /*
            //Ajouter une nouvelle vue

            Form_BD webpage = new Form_BD();

            webpages.Add(webpage);
            tabpages.Add(tabPage1);
            current_tab_count++;
            webpage.QueryAll = "select * from " + "[Agricultural imports (% of total merchandise imports)]" + "; ";
            webpage.tableName = "[Agricultural imports (% of total merchandise imports)]";
            webpage.TopLevel = false;
            tabPage1.Controls.Add(webpage);
            webpage.FormBorderStyle = FormBorderStyle.None;
            webpage.Dock = DockStyle.Fill;
            webpage.Show();
            */
            Create_New_Tab(firstquery);
            
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            if (current_tab_count < 2) return;
            TabPage current_tab = tabControl1.SelectedTab;
            Form_BD thiswebpage = (Form_BD)webpages[tabpages.IndexOf(current_tab)];
            thiswebpage.Dispose();
            tabpages.Remove(current_tab);
            current_tab.Dispose();
            tabControl1.TabPages.Remove(current_tab);
            current_tab_count--;
            
        }

        private void CerealImportDependencyRatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Cereal import dependency ratio (%)");
        }

        private void EmploymentRateOfLaborForce1564YearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Employment rate (% of labor force, 15-64 years)");

        }

        private void EmploymentRateOfPopulation15YearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Employment rate (% of population, 15+ years)");

        }

        private void GDPPerCapitaconstant2010USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("GDP per capita (constant 2010 USD)");

        }

        private void GINIIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("GINI index");

        }

        private void HouseholdConsumptionExpenditurePerCapitaconstant2010USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Household consumption expenditure per capita (constant 2010 USD)");

        }

        private void PovertyGapAt190ADay2011PPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Poverty gap at $1.90 a day (2011 PPP) (%)");

        }

        private void PovertyHeadcountRatioAt190ADay2011PPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Poverty Headcount Ratio at $1.90 a day (2011 PPP) (%)");

        }

        private void PrevalanceOfUndernourishmentOfPopulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Prevalance of undernourishment (% of population)");

        }

        private void PrevalenceOfStuntingHeightForAgeOfChildrenUnder5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Prevalence of stunting, height for age (% of children under 5)");

        }

        private void PrevalenceOfUnderweightWeightForAgeOfChildrenUnder5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Prevalence of underweight, weight for age (% of children under 5)");

        }

        private void PrevalenceOfWastingOfChildrenUnder5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Prevalence of wasting (% of children under 5)");

        }

        private void AgrciultureProductionIndexNumber20042006100IntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agrciulture Production Index Number (2004-2006 = 100) (Int.$)");

        }

        private void AgricultureValueAddedPerHectareOfAgriculturalLandconstant2010USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agriculture value added per hectare of agricultural land (constant 2010 USD)");

        }

        private void AgricultureValueAddedPerWorkerconstant2010USDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agriculture value added per worker (constant 2010 USD)");

        }

        private void AgricultureValueAddedconstant2010USDMillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agriculture, value added (constant 2010 USD, million)");

        }

        private void DomesticFoodPriceVolatilityindexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Domestic food price volatility (index)");

        }

        private void IntraAfricanAgriculturalTradeExportsconstant2010USMillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Intra-African agricultural trade, exports (constant 2010 US$, million)");

        }

        private void IntraAfricanAgriculturalTradeImportsconstant2010USDMillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Intra-African agricultural trade, imports (constant 2010 USD, million)");

        }

        private void YieldCassavaTonsPerHectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Yield, cassava (Tons per hectare)");

        }

        private void YieldMaizeTonsPerHectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Yield, maize (Tons per hectare)");

        }

        private void YieldMeatindigenousCattleKilogramsPerHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Yield, meat (indigenous cattle, kilograms per head)");

        }

        private void YieldMilkwholeFreshCowKilogramsPerHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Yield, milk (whole fresh cow, kilograms per head)");

        }

        private void YieldYamsTonsPerHectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Yield, yams (Tons per hectare)");

        }

        private void GovernmentAgricultureExpenditureOfAgricultureValueAddedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Government agriculture expenditure (% of agriculture value added)");

        }

        private void GovernmentAgricultureExpenditureconstant2010USBillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Government agriculture expenditure (constant 2010 US$, billion)");

        }

        private void GovernmentAgricultureExpenditureOfTotalExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Government agriculture expenditure (% of total expenditure)");

        }

        private void AgriculturalExportsOfTotalMerchandiseExportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agricultural exports (% of total merchandise exports)");

        }

        private void AgriculturalImportsOfTotalMerchandiseImportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agricultural imports (% of total merchandise imports)");

        }

        private void AgriculturalODAOfCommitementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agricultural ODA (% of commitements)");

        }

        private void AgriculturalODATotalODAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agricultural ODA (% total ODA)");

        }

        private void AgriculturalValueAddedGDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agricultural value added (% GDP)");

        }

        private void AgricultureValueAddedGowthRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Agriculture value added gowth rate (%)");

        }

        private void AnnualInflationGDPDeflatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Annual inflation, GDP deflator (%)");

        }

        private void EmergencyFoodAidTotalODAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Emergency food aid (% total ODA)");

        }

        private void GeneralGovernmentGrossDebtOfGDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("General government gross debt (% of GDP)");

        }

        private void GeneralGovernmentGrossRevenueOfGDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("General government gross revenue (% of GDP)");

        }

        private void GlobalHungerIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Global Hunger Index");

        }

        private void GrossDomesticProductconstant2010USBillionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Gross Domestic Product (constant 2010 US$, billion)");

        }

        private void RatioOfAgriculturalExportsToAgriculturalImportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Ratio of agricultural exports to agricultural imports");

        }

        private void TotalFertilizerConsumptionkilogramPerHectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_New_Tab("Total fertilizer consumption (kilogram per hectare)");

        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font f;
            Brush backBrush;
            Brush foreBrush;

            if (e.Index == this.tabControl1.SelectedIndex)
            {
                f = new Font(e.Font, FontStyle.Italic | FontStyle.Bold);
                backBrush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Blue, Color.Red, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                foreBrush = Brushes.PowderBlue;
            }
            else
            {
                f = e.Font;
                backBrush = new SolidBrush(e.BackColor);
                foreBrush = new SolidBrush(e.ForeColor);
            }

            string tabName = this.tabControl1.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(backBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(tabName, f, foreBrush, r, sf);

            sf.Dispose();
            if (e.Index == this.tabControl1.SelectedIndex)
            {
                f.Dispose();
                backBrush.Dispose();
            }
            else
            {
                backBrush.Dispose();
                foreBrush.Dispose();
            }
        }
    }
    }



