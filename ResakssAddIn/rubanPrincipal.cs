using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace ResakssAddIn
{
    public partial class rubanPrincipal
    {

        private void rubanPrincipal_Load(object sender, RibbonUIEventArgs e)
        {
         

        }


        private void Btn_insertData_Click(object sender, RibbonControlEventArgs e)
        {

            Form_Principal new_Form = new Form_Principal();
            new_Form.firstquery = "Agricultural imports (% of total merchandise imports)";
            new_Form.Show();
           /* Form_BD new_Form = new Form_BD();
            new_Form.Show();*/
        }

        private void CerealImportDependencyRatioToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            new_Form.firstquery = "Cereal import dependency ratio (%)";
            new_Form.Show();
        }

        private void EmploymentRateOfLaborForce1564YearsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            new_Form.firstquery = "Employment rate (% of labor force, 15-64 years)";
            new_Form.Show();
        }

        private void EmploymentRateOfPopulation15YearsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            new_Form.firstquery = "Employment rate (% of population, 15+ years)";
            new_Form.Show();
        }

        private void GDPPerCapitaconstant2010USDToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            new_Form.firstquery = "GDP per capita (constant 2010 USD)";
            new_Form.Show();
        }

        private void GINIIndexToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="GINI index";
            new_Form.Show();
        }

        private void HouseholdConsumptionExpenditurePerCapitaconstant2010USDToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Household consumption expenditure per capita (constant 2010 USD)";
            new_Form.Show();
        }

        private void PovertyGapAt190ADay2011PPPToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Poverty gap at $1.90 a day (2011 PPP) (%)";
            new_Form.Show();
        }

        private void PovertyHeadcountRatioAt190ADay2011PPPToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Poverty Headcount Ratio at $1.90 a day (2011 PPP) (%)";
            new_Form.Show();
        }

        private void PrevalanceOfUndernourishmentOfPopulationToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Prevalance of undernourishment (% of population)";
            new_Form.Show();
        }

        private void PrevalenceOfStuntingHeightForAgeOfChildrenUnder5ToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Prevalence of stunting, height for age (% of children under 5)";
            new_Form.Show();
        }

        private void PrevalenceOfUnderweightWeightForAgeOfChildrenUnder5ToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Prevalence of underweight, weight for age (% of children under 5)";
            new_Form.Show();
        }

        private void PrevalenceOfWastingOfChildrenUnder5ToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Prevalence of wasting (% of children under 5)";
            new_Form.Show();
        }

        private void AgrciultureProductionIndexNumber20042006100IntToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agrciulture Production Index Number (2004-2006 = 100) (Int.$)";
            new_Form.Show();
        }

        private void AgricultureValueAddedPerHectareOfAgriculturalLandconstant2010USDToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agriculture value added per hectare of agricultural land (constant 2010 USD)";
            new_Form.Show();
        }

        private void AgricultureValueAddedPerWorkerconstant2010USDToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agriculture value added per worker (constant 2010 USD)";
            new_Form.Show();
        }

        private void AgricultureValueAddedconstant2010USDMillionToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agriculture, value added (constant 2010 USD, million)";
            new_Form.Show();
        }

        private void DomesticFoodPriceVolatilityindexToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Domestic food price volatility (index)";
            new_Form.Show();
        }

        private void IntraAfricanAgriculturalTradeExportsconstant2010USMillionToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Intra-African agricultural trade, exports (constant 2010 US$, million)";
            new_Form.Show();
        }

        private void IntraAfricanAgriculturalTradeImportsconstant2010USDMillionToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Intra-African agricultural trade, imports (constant 2010 USD, million)";
            new_Form.Show();
        }

        private void YieldCassavaTonsPerHectareToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Yield, cassava (Tons per hectare)";
            new_Form.Show();
        }

        private void YieldMaizeTonsPerHectareToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Yield, maize (Tons per hectare)";
            new_Form.Show();
        }

        private void YieldMeatindigenousCattleKilogramsPerHeadToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Yield, meat (indigenous cattle, kilograms per head)";
            new_Form.Show();
        }

        private void YieldMilkwholeFreshCowKilogramsPerHeadToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Yield, milk (whole fresh cow, kilograms per head)";
            new_Form.Show();
        }

        private void YieldYamsTonsPerHectareToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Yield, yams (Tons per hectare)";
            new_Form.Show();
        }

        private void GovernmentAgricultureExpenditureOfAgricultureValueAddedToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Government agriculture expenditure (% of agriculture value added)";
            new_Form.Show();
        }

        private void GovernmentAgricultureExpenditureconstant2010USBillionToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Government agriculture expenditure (constant 2010 US$, billion)";
            new_Form.Show();
        }

        private void GovernmentAgricultureExpenditureOfTotalExpenditureToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Government agriculture expenditure (% of total expenditure)";
            new_Form.Show();
        }

        private void AgriculturalExportsOfTotalMerchandiseExportsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agricultural exports (% of total merchandise exports)";
            new_Form.Show();
        }

        private void AgriculturalImportsOfTotalMerchandiseImportsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agricultural imports (% of total merchandise imports)";
            new_Form.Show();
        }

        private void AgriculturalODAOfCommitementsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agricultural ODA (% of commitements)";
            new_Form.Show();
        }

        private void AgriculturalODATotalODAToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agricultural ODA (% total ODA)";
            new_Form.Show();
        }

        private void AgriculturalValueAddedGDPToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agricultural value added (% GDP)";
            new_Form.Show();
        }

        private void AgricultureValueAddedGowthRateToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Agriculture value added gowth rate (%)";
            new_Form.Show();
        }

        private void AnnualInflationGDPDeflatorToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Annual inflation, GDP deflator (%)";
            new_Form.Show();
        }

        private void EmergencyFoodAidTotalODAToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Emergency food aid (% total ODA)";
            new_Form.Show();
        }

        private void GeneralGovernmentGrossDebtOfGDPToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="General government gross debt (% of GDP)";
            new_Form.Show();
        }

        private void GeneralGovernmentGrossRevenueOfGDPToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="General government gross revenue (% of GDP)";
            new_Form.Show();
        }

        private void GlobalHungerIndexToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Global Hunger Index";
            new_Form.Show();
        }

        private void GrossDomesticProductconstant2010USBillionToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Gross Domestic Product (constant 2010 US$, billion)";
            new_Form.Show();
        }

        private void RatioOfAgriculturalExportsToAgriculturalImportsToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Ratio of agricultural exports to agricultural imports";
            new_Form.Show();
        }

        private void TotalFertilizerConsumptionkilogramPerHectareToolStripMenuItem_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Principal new_Form = new Form_Principal();
            
            new_Form.firstquery="Total fertilizer consumption (kilogram per hectare)";
            new_Form.Show();
        }
    }
}
