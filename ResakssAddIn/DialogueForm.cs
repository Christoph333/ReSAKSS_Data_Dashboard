using Microsoft.Data.Sqlite;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace ResakssAddIn
{
    public partial class DialogueForm : Form
    {
        public DialogueForm()
        {
            InitializeComponent();
        }
        public string QueryAll2 { get; set; }
        public string tableName2 { get; set; }
        private string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"ResakssDB.db");

        private void Button4_Click(object sender, EventArgs e)
        {

        }
        private DataTable dg = new DataTable();
        private void DialogueForm_Load(object sender, EventArgs e)
        {
           // string sql = QueryAll2;
            const string sql2 = "select * from ReSAKSS_indicators_methodology;";
           // var conn = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
            lbl_dataview.Text = tableName2;

            try
            {
                using (SqliteConnection db =
                   new SqliteConnection("Filename=" + fileName))
                {
                    db.Open();

                    SqliteCommand selectCommand = new SqliteCommand
                        (QueryAll2, db);

                    // SqliteDataReader query = selectCommand.ExecuteReader();
                    using (SqliteDataReader query = selectCommand.ExecuteReader())
                    {
                        System.Data.DataTable dgSchema = query.GetSchemaTable();


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
                    grid2.DataSource = dg.DefaultView;

                    db.Close();
                }




                //**************************************

                using (SqliteConnection db =
                       new SqliteConnection("Filename=" + fileName))
                {
                    db.Open();

                    SqliteCommand selectCommand = new SqliteCommand
                        (sql2, db);

                    // SqliteDataReader query = selectCommand.ExecuteReader();
                    using (SqliteDataReader query = selectCommand.ExecuteReader())
                    {
                        System.Data.DataTable dgSchema = query.GetSchemaTable();


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
                    gridDescription.DataSource = dg.DefaultView;

                    db.Close();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double totalRow = 0;
            double totalColumn = 0;
            try
            {
               
                System.Data.DataTable dt = new System.Data.DataTable();

                using (SqliteConnection db =
                    new SqliteConnection("Filename=" + fileName))
                {
                    db.Open();

                    SqliteCommand selectCommand = new SqliteCommand
                        (QueryAll2, db);

                    // SqliteDataReader query = selectCommand.ExecuteReader();
                    using (SqliteDataReader query = selectCommand.ExecuteReader())
                    {
                        System.Data.DataTable dgSchema = query.GetSchemaTable();


                        dt = new DataTable();
                        if (dgSchema != null)
                            if (dgSchema.Rows.Count > 0)
                                for (int i = 0; i < dgSchema.Rows.Count; i++)
                                {
                                    DataColumn Col = new DataColumn(dgSchema.Rows[i]["ColumnName"].ToString(), (Type)dgSchema.Rows[i]["DataType"]);
                                    Col.AllowDBNull = true;
                                    Col.Unique = false;
                                    Col.AutoIncrement = false;
                                    dt.Columns.Add(Col);
                                }

                        while (query.Read())
                        {
                            //Read data and fill it to our datatable
                            DataRow Row = dt.NewRow();
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                Row[i] = query[i];
                            }
                            dt.Rows.Add(Row);
                        }
                    }

                    db.Close();
                }

                //INSERER LES DONNEES DANS EXCEL


                Microsoft.Office.Interop.Excel.Worksheet newWorksheet;
                newWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();

                if (dt.Rows.Count <= 0)
                {
                    return;
                }

                Globals.ThisAddIn.Application.ActiveSheet.Cells.ClearContents();
                //  my_range.NumberFormat = "0.0"; // change number of decimal places as needed


                int c = 1;
                foreach (DataColumn column in dt.Columns)
                {

                    //Console.WriteLine(column.ColumnName);
                    Globals.ThisAddIn.Application.ActiveSheet.Cells[2, c].Value2 = column.ColumnName;


                    c = c + 1;

                }
                Globals.ThisAddIn.Application.ActiveSheet.Cells[1, 1].Value2 = tableName2.ToString();
                Globals.ThisAddIn.Application.ActiveSheet.Cells[1, 1].EntireRow.Font.Bold = true;
                Globals.ThisAddIn.Application.ActiveSheet.Cells[1, 1].EntireRow.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                Globals.ThisAddIn.Application.ActiveSheet.Cells[1, 1].EntireRow.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                Globals.ThisAddIn.Application.ActiveSheet.Cells[2, 1].Value2 = "";



                totalColumn = dt.Columns.Count;
                totalRow = dt.Rows.Count;


                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    for (int j = 0; j <= dt.Columns.Count - 1; j++)

                    {

                        Globals.ThisAddIn.Application.ActiveSheet.Cells[i + 3, j + 1].Value2 = dt.Rows[i][j].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
            }

            object valeur;
            double valeurDouble;
            for (int i = 0; i <= totalRow - 1; i++)
            {
                for (int j = 0; j <= totalColumn - 1; j++)

                {
                    // Globals.ThisAddIn.Application.ActiveSheet.Cells[i + 2, j + 1] = Convert.ToDouble(); 


                    var cell = (Range)Globals.ThisAddIn.Application.ActiveSheet.Cells[i + 3, j + 1];
                    valeur = cell.Value;
                    valeurDouble = Convert.ToDouble(valeur);
                    cell.Value = valeurDouble;

                }
            }
            if (lbl_dataview.Text.Length < 31)
            {
                Globals.ThisAddIn.Application.ActiveSheet.Name = lbl_dataview.Text.Substring(0, lbl_dataview.Text.Length);
            }
            else
            {
                Globals.ThisAddIn.Application.ActiveSheet.Name = lbl_dataview.Text.Substring(0, 31);

            }

            DialogResult dialogResult = MessageBox.Show("Data saved to Excel successfully. Close DataWindow and continue", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            // Globals.ThisAddIn.Application.ActiveSheet.Name = tableName2;

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
