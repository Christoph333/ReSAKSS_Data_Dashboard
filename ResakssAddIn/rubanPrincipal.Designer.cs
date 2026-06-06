namespace ResakssAddIn
{
    partial class rubanPrincipal : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public rubanPrincipal()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rubanPrincipal));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.group9 = this.Factory.CreateRibbonGroup();
            this.lblResakss = this.Factory.CreateRibbonLabel();
            this.btn_insertData = this.Factory.CreateRibbonButton();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.button12 = this.Factory.CreateRibbonButton();
            this.menu2 = this.Factory.CreateRibbonMenu();
            this.button15 = this.Factory.CreateRibbonButton();
            this.button16 = this.Factory.CreateRibbonButton();
            this.button17 = this.Factory.CreateRibbonButton();
            this.button18 = this.Factory.CreateRibbonButton();
            this.button19 = this.Factory.CreateRibbonButton();
            this.button20 = this.Factory.CreateRibbonButton();
            this.button21 = this.Factory.CreateRibbonButton();
            this.button22 = this.Factory.CreateRibbonButton();
            this.button23 = this.Factory.CreateRibbonButton();
            this.button24 = this.Factory.CreateRibbonButton();
            this.button25 = this.Factory.CreateRibbonButton();
            this.button26 = this.Factory.CreateRibbonButton();
            this.menu3 = this.Factory.CreateRibbonMenu();
            this.button29 = this.Factory.CreateRibbonButton();
            this.button30 = this.Factory.CreateRibbonButton();
            this.button31 = this.Factory.CreateRibbonButton();
            this.menu4 = this.Factory.CreateRibbonMenu();
            this.button43 = this.Factory.CreateRibbonButton();
            this.button44 = this.Factory.CreateRibbonButton();
            this.button45 = this.Factory.CreateRibbonButton();
            this.button46 = this.Factory.CreateRibbonButton();
            this.button47 = this.Factory.CreateRibbonButton();
            this.button48 = this.Factory.CreateRibbonButton();
            this.button49 = this.Factory.CreateRibbonButton();
            this.button50 = this.Factory.CreateRibbonButton();
            this.button51 = this.Factory.CreateRibbonButton();
            this.button52 = this.Factory.CreateRibbonButton();
            this.button53 = this.Factory.CreateRibbonButton();
            this.button54 = this.Factory.CreateRibbonButton();
            this.button55 = this.Factory.CreateRibbonButton();
            this.button56 = this.Factory.CreateRibbonButton();
            this.button57 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group6.SuspendLayout();
            this.group9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group6);
            this.tab1.Groups.Add(this.group9);
            this.tab1.Label = "ResakssOne";
            this.tab1.Name = "tab1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.btn_insertData);
            this.group2.Label = "G1";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Items.Add(this.menu1);
            this.group3.Label = "G2";
            this.group3.Name = "group3";
            // 
            // group4
            // 
            this.group4.Items.Add(this.menu2);
            this.group4.Label = "G3";
            this.group4.Name = "group4";
            // 
            // group5
            // 
            this.group5.Items.Add(this.menu3);
            this.group5.Label = "G4";
            this.group5.Name = "group5";
            // 
            // group6
            // 
            this.group6.Items.Add(this.menu4);
            this.group6.Label = "G5";
            this.group6.Name = "group6";
            // 
            // group9
            // 
            this.group9.Items.Add(this.lblResakss);
            this.group9.Label = " ";
            this.group9.Name = "group9";
            // 
            // lblResakss
            // 
            this.lblResakss.Label = "ReSAKSS DashBoard";
            this.lblResakss.Name = "lblResakss";
            // 
            // btn_insertData
            // 
            this.btn_insertData.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_insertData.Image = ((System.Drawing.Image)(resources.GetObject("btn_insertData.Image")));
            this.btn_insertData.Label = "Dashboard";
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.ShowImage = true;
            this.btn_insertData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_insertData_Click);
            // 
            // menu1
            // 
            this.menu1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Image = global::ResakssAddIn.Properties.Resources.growth;
            this.menu1.Items.Add(this.button1);
            this.menu1.Items.Add(this.button2);
            this.menu1.Items.Add(this.button3);
            this.menu1.Items.Add(this.button4);
            this.menu1.Items.Add(this.button5);
            this.menu1.Items.Add(this.button6);
            this.menu1.Items.Add(this.button7);
            this.menu1.Items.Add(this.button8);
            this.menu1.Items.Add(this.button9);
            this.menu1.Items.Add(this.button10);
            this.menu1.Items.Add(this.button11);
            this.menu1.Items.Add(this.button12);
            this.menu1.Label = "Level-1: Economic Growth and Inclusive Development";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // button1
            // 
            this.button1.Image = global::ResakssAddIn.Properties.Resources._1number_1_3831;
            this.button1.Label = "Cereal import dependency ratio (%)";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CerealImportDependencyRatioToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Image = global::ResakssAddIn.Properties.Resources._2number_2_3079;
            this.button2.Label = "Employment rate (% of labor force, 15-64 years)";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EmploymentRateOfLaborForce1564YearsToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Image = global::ResakssAddIn.Properties.Resources._3number_3_3077;
            this.button3.Label = "Employment rate (% of population, 15+ years)";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EmploymentRateOfPopulation15YearsToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Image = global::ResakssAddIn.Properties.Resources._4number_4_3829;
            this.button4.Label = "GDP per capita (constant 2010 USD)";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GDPPerCapitaconstant2010USDToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Image = global::ResakssAddIn.Properties.Resources._5_number_3827;
            this.button5.Label = "GINI index";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GINIIndexToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Image = global::ResakssAddIn.Properties.Resources._6_number_3075;
            this.button6.Label = "Household consumption expenditure per capita (constant 2010 USD)";
            this.button6.Name = "button6";
            this.button6.ShowImage = true;
            this.button6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.HouseholdConsumptionExpenditurePerCapitaconstant2010USDToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.Image = global::ResakssAddIn.Properties.Resources._7number_7_3074;
            this.button7.Label = "Poverty gap at $1.90 a day (2011 PPP) (%)";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            this.button7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PovertyGapAt190ADay2011PPPToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.Image = global::ResakssAddIn.Properties.Resources._8number_8_3824;
            this.button8.Label = "Poverty Headcount Ratio at $1.90 a day (2011 PPP) (%)";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            this.button8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PovertyHeadcountRatioAt190ADay2011PPPToolStripMenuItem_Click);
            // 
            // button9
            // 
            this.button9.Image = global::ResakssAddIn.Properties.Resources._9number_9_3071;
            this.button9.Label = "Prevalance of undernourishment (% of population)";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            this.button9.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PrevalanceOfUndernourishmentOfPopulationToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.Image = global::ResakssAddIn.Properties.Resources._10th_icon_icons_com_68909;
            this.button10.Label = "Prevalence of stunting, height for age (% of children under 5)";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            this.button10.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PrevalenceOfStuntingHeightForAgeOfChildrenUnder5ToolStripMenuItem_Click);
            // 
            // button11
            // 
            this.button11.Image = global::ResakssAddIn.Properties.Resources._11th_icon_icons_com_68925;
            this.button11.Label = "Prevalence of underweight, weight for age (% of children under 5)";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            this.button11.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PrevalenceOfUnderweightWeightForAgeOfChildrenUnder5ToolStripMenuItem_Click);
            // 
            // button12
            // 
            this.button12.Image = global::ResakssAddIn.Properties.Resources._12th_icon_icons_com_68914;
            this.button12.Label = "Prevalence of wasting (% of children under 5)";
            this.button12.Name = "button12";
            this.button12.ShowImage = true;
            this.button12.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.PrevalenceOfWastingOfChildrenUnder5ToolStripMenuItem_Click);
            // 
            // menu2
            // 
            this.menu2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu2.Image = global::ResakssAddIn.Properties.Resources.agri_growth;
            this.menu2.Items.Add(this.button15);
            this.menu2.Items.Add(this.button16);
            this.menu2.Items.Add(this.button17);
            this.menu2.Items.Add(this.button18);
            this.menu2.Items.Add(this.button19);
            this.menu2.Items.Add(this.button20);
            this.menu2.Items.Add(this.button21);
            this.menu2.Items.Add(this.button22);
            this.menu2.Items.Add(this.button23);
            this.menu2.Items.Add(this.button24);
            this.menu2.Items.Add(this.button25);
            this.menu2.Items.Add(this.button26);
            this.menu2.Label = "Level-2: Agricultural Transformation and Growth";
            this.menu2.Name = "menu2";
            this.menu2.ShowImage = true;
            // 
            // button15
            // 
            this.button15.Image = global::ResakssAddIn.Properties.Resources._1number_1_3831;
            this.button15.Label = "Agrciulture Production Index Number (2004-2006 = 100) (Int. $)";
            this.button15.Name = "button15";
            this.button15.ShowImage = true;
            this.button15.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgrciultureProductionIndexNumber20042006100IntToolStripMenuItem_Click);
            // 
            // button16
            // 
            this.button16.Image = global::ResakssAddIn.Properties.Resources._2number_2_3079;
            this.button16.Label = "Agriculture value added per hectare of agricultural land (constant 2010 USD)";
            this.button16.Name = "button16";
            this.button16.ShowImage = true;
            this.button16.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgricultureValueAddedPerHectareOfAgriculturalLandconstant2010USDToolStripMenuItem_Click);
            // 
            // button17
            // 
            this.button17.Image = global::ResakssAddIn.Properties.Resources._3number_3_3077;
            this.button17.Label = "Agriculture value added per worker (constant 2010 USD)";
            this.button17.Name = "button17";
            this.button17.ShowImage = true;
            this.button17.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgricultureValueAddedPerWorkerconstant2010USDToolStripMenuItem_Click);
            // 
            // button18
            // 
            this.button18.Image = global::ResakssAddIn.Properties.Resources._4number_4_3829;
            this.button18.Label = "Agriculture, value added (constant 2010 USD, million)";
            this.button18.Name = "button18";
            this.button18.ShowImage = true;
            this.button18.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgricultureValueAddedconstant2010USDMillionToolStripMenuItem_Click);
            // 
            // button19
            // 
            this.button19.Image = global::ResakssAddIn.Properties.Resources._5_number_3827;
            this.button19.Label = "Domestic food price volatility (index)";
            this.button19.Name = "button19";
            this.button19.ShowImage = true;
            this.button19.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DomesticFoodPriceVolatilityindexToolStripMenuItem_Click);
            // 
            // button20
            // 
            this.button20.Image = global::ResakssAddIn.Properties.Resources._6_number_3075;
            this.button20.Label = "Intra-African agricultural trade, exports (constant 2010 US$, million)";
            this.button20.Name = "button20";
            this.button20.ShowImage = true;
            this.button20.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.IntraAfricanAgriculturalTradeExportsconstant2010USMillionToolStripMenuItem_Click);
            // 
            // button21
            // 
            this.button21.Image = global::ResakssAddIn.Properties.Resources._7number_7_3074;
            this.button21.Label = "Intra-African agricultural trade, imports (constant 2010 USD, million)";
            this.button21.Name = "button21";
            this.button21.ShowImage = true;
            this.button21.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.IntraAfricanAgriculturalTradeImportsconstant2010USDMillionToolStripMenuItem_Click);
            // 
            // button22
            // 
            this.button22.Image = global::ResakssAddIn.Properties.Resources._8number_8_3824;
            this.button22.Label = "Yield, cassava (Tons per hectare)";
            this.button22.Name = "button22";
            this.button22.ShowImage = true;
            this.button22.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YieldCassavaTonsPerHectareToolStripMenuItem_Click);
            // 
            // button23
            // 
            this.button23.Image = global::ResakssAddIn.Properties.Resources._9number_9_3071;
            this.button23.Label = "Yield, maize (Tons per hectare)";
            this.button23.Name = "button23";
            this.button23.ShowImage = true;
            this.button23.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YieldMaizeTonsPerHectareToolStripMenuItem_Click);
            // 
            // button24
            // 
            this.button24.Image = global::ResakssAddIn.Properties.Resources._10th_icon_icons_com_68909;
            this.button24.Label = "Yield, meat (indigenous cattle, kilograms per head)";
            this.button24.Name = "button24";
            this.button24.ShowImage = true;
            this.button24.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YieldMeatindigenousCattleKilogramsPerHeadToolStripMenuItem_Click);
            // 
            // button25
            // 
            this.button25.Image = global::ResakssAddIn.Properties.Resources._11th_icon_icons_com_68925;
            this.button25.Label = "Yield, milk (whole fresh cow, kilograms per head)";
            this.button25.Name = "button25";
            this.button25.ShowImage = true;
            this.button25.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YieldMilkwholeFreshCowKilogramsPerHeadToolStripMenuItem_Click);
            // 
            // button26
            // 
            this.button26.Image = global::ResakssAddIn.Properties.Resources._12th_icon_icons_com_68914;
            this.button26.Label = "Yield, yams (Tons per hectare)";
            this.button26.Name = "button26";
            this.button26.ShowImage = true;
            this.button26.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.YieldYamsTonsPerHectareToolStripMenuItem_Click);
            // 
            // menu3
            // 
            this.menu3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu3.Image = global::ResakssAddIn.Properties.Resources.monitoring;
            this.menu3.Items.Add(this.button29);
            this.menu3.Items.Add(this.button30);
            this.menu3.Items.Add(this.button31);
            this.menu3.Label = "Level-3: Systemic capacity to deliver results";
            this.menu3.Name = "menu3";
            this.menu3.ShowImage = true;
            // 
            // button29
            // 
            this.button29.Image = global::ResakssAddIn.Properties.Resources._1number_1_3831;
            this.button29.Label = "Government agriculture expenditure (% of agriculture value added)";
            this.button29.Name = "button29";
            this.button29.ShowImage = true;
            this.button29.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GovernmentAgricultureExpenditureOfAgricultureValueAddedToolStripMenuItem_Click);
            // 
            // button30
            // 
            this.button30.Image = global::ResakssAddIn.Properties.Resources._2number_2_3079;
            this.button30.Label = "Government agriculture expenditure (constant 2010 US$, billion)";
            this.button30.Name = "button30";
            this.button30.ShowImage = true;
            this.button30.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GovernmentAgricultureExpenditureconstant2010USBillionToolStripMenuItem_Click);
            // 
            // button31
            // 
            this.button31.Image = global::ResakssAddIn.Properties.Resources._3number_3_3077;
            this.button31.Label = "Government agriculture expenditure (% of total expenditure)";
            this.button31.Name = "button31";
            this.button31.ShowImage = true;
            this.button31.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GovernmentAgricultureExpenditureOfTotalExpenditureToolStripMenuItem_Click);
            // 
            // menu4
            // 
            this.menu4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu4.Image = global::ResakssAddIn.Properties.Resources.barchart6_78008;
            this.menu4.Items.Add(this.button43);
            this.menu4.Items.Add(this.button44);
            this.menu4.Items.Add(this.button45);
            this.menu4.Items.Add(this.button46);
            this.menu4.Items.Add(this.button47);
            this.menu4.Items.Add(this.button48);
            this.menu4.Items.Add(this.button49);
            this.menu4.Items.Add(this.button50);
            this.menu4.Items.Add(this.button51);
            this.menu4.Items.Add(this.button52);
            this.menu4.Items.Add(this.button53);
            this.menu4.Items.Add(this.button54);
            this.menu4.Items.Add(this.button55);
            this.menu4.Items.Add(this.button56);
            this.menu4.Label = "Other Statistic";
            this.menu4.Name = "menu4";
            this.menu4.ShowImage = true;
            // 
            // button43
            // 
            this.button43.Image = global::ResakssAddIn.Properties.Resources._1number_1_3831;
            this.button43.Label = "Agricultural exports (% of total merchandise exports)";
            this.button43.Name = "button43";
            this.button43.ShowImage = true;
            this.button43.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgriculturalExportsOfTotalMerchandiseExportsToolStripMenuItem_Click);
            // 
            // button44
            // 
            this.button44.Image = global::ResakssAddIn.Properties.Resources._2number_2_3079;
            this.button44.Label = "Agricultural imports (% of total merchandise imports)";
            this.button44.Name = "button44";
            this.button44.ShowImage = true;
            this.button44.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgriculturalImportsOfTotalMerchandiseImportsToolStripMenuItem_Click);
            // 
            // button45
            // 
            this.button45.Image = global::ResakssAddIn.Properties.Resources._3number_3_3077;
            this.button45.Label = "Agricultural ODA (% of commitements)";
            this.button45.Name = "button45";
            this.button45.ShowImage = true;
            this.button45.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgriculturalODAOfCommitementsToolStripMenuItem_Click);
            // 
            // button46
            // 
            this.button46.Image = global::ResakssAddIn.Properties.Resources._4number_4_3829;
            this.button46.Label = "Agricultural ODA (% total ODA)";
            this.button46.Name = "button46";
            this.button46.ShowImage = true;
            this.button46.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgriculturalODATotalODAToolStripMenuItem_Click);
            // 
            // button47
            // 
            this.button47.Image = global::ResakssAddIn.Properties.Resources._5_number_3827;
            this.button47.Label = "Agricultural value added (% GDP)";
            this.button47.Name = "button47";
            this.button47.ShowImage = true;
            this.button47.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgriculturalValueAddedGDPToolStripMenuItem_Click);
            // 
            // button48
            // 
            this.button48.Image = global::ResakssAddIn.Properties.Resources._6_number_3075;
            this.button48.Label = "Agriculture value added gowth rate (%)";
            this.button48.Name = "button48";
            this.button48.ShowImage = true;
            this.button48.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AgricultureValueAddedGowthRateToolStripMenuItem_Click);
            // 
            // button49
            // 
            this.button49.Image = global::ResakssAddIn.Properties.Resources._7number_7_3074;
            this.button49.Label = "Annual inflation, GDP deflator (%)";
            this.button49.Name = "button49";
            this.button49.ShowImage = true;
            this.button49.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AnnualInflationGDPDeflatorToolStripMenuItem_Click);
            // 
            // button50
            // 
            this.button50.Image = global::ResakssAddIn.Properties.Resources._8number_8_3824;
            this.button50.Label = "Emergency food aid (% total ODA)";
            this.button50.Name = "button50";
            this.button50.ShowImage = true;
            this.button50.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EmergencyFoodAidTotalODAToolStripMenuItem_Click);
            // 
            // button51
            // 
            this.button51.Image = global::ResakssAddIn.Properties.Resources._9number_9_3071;
            this.button51.Label = "General government gross debt (% of GDP)";
            this.button51.Name = "button51";
            this.button51.ShowImage = true;
            this.button51.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GeneralGovernmentGrossDebtOfGDPToolStripMenuItem_Click);
            // 
            // button52
            // 
            this.button52.Image = global::ResakssAddIn.Properties.Resources._10th_icon_icons_com_68909;
            this.button52.Label = "General government gross revenue (% of GDP)";
            this.button52.Name = "button52";
            this.button52.ShowImage = true;
            this.button52.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GeneralGovernmentGrossRevenueOfGDPToolStripMenuItem_Click);
            // 
            // button53
            // 
            this.button53.Image = global::ResakssAddIn.Properties.Resources._11th_icon_icons_com_68925;
            this.button53.Label = "Global Hunger Index";
            this.button53.Name = "button53";
            this.button53.ShowImage = true;
            this.button53.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GlobalHungerIndexToolStripMenuItem_Click);
            // 
            // button54
            // 
            this.button54.Image = global::ResakssAddIn.Properties.Resources._12th_icon_icons_com_68914;
            this.button54.Label = "Gross Domestic Product (constant 2010 US$, billion)";
            this.button54.Name = "button54";
            this.button54.ShowImage = true;
            this.button54.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GrossDomesticProductconstant2010USBillionToolStripMenuItem_Click);
            // 
            // button55
            // 
            this.button55.Image = global::ResakssAddIn.Properties.Resources._13th_icon_icons_com_68929;
            this.button55.Label = "Ratio of agricultural exports to agricultural imports";
            this.button55.Name = "button55";
            this.button55.ShowImage = true;
            this.button55.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RatioOfAgriculturalExportsToAgriculturalImportsToolStripMenuItem_Click);
            // 
            // button56
            // 
            this.button56.Image = global::ResakssAddIn.Properties.Resources._14th_icon_icons_com_68910;
            this.button56.Label = "Total fertilizer consumption (kilogram per hectare)";
            this.button56.Name = "button56";
            this.button56.ShowImage = true;
            this.button56.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TotalFertilizerConsumptionkilogramPerHectareToolStripMenuItem_Click);
            // 
            // button57
            // 
            this.button57.Label = "button57";
            this.button57.Name = "button57";
            // 
            // rubanPrincipal
            // 
            this.Name = "rubanPrincipal";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.rubanPrincipal_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group9.ResumeLayout(false);
            this.group9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insertData;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button12;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button15;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button16;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button17;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button18;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button19;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button20;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button21;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button22;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button23;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button24;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button25;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button26;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button29;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button30;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button31;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button43;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button44;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button45;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button46;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button47;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button48;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button49;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button50;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button51;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button52;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button53;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button54;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button55;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button56;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lblResakss;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button57;
    }

    partial class ThisRibbonCollection
    {
        internal rubanPrincipal rubanPrincipal
        {
            get { return this.GetRibbon<rubanPrincipal>(); }
        }
    }
}
