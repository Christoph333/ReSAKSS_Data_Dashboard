
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using System.Diagnostics;
/// <summary>
/// Author      : Shanu
/// Create date : 2015-02-23
/// Description :Excel AddIn Control
/// Latest
/// Modifier    :Shanu
/// Modify date :  2015-02-23
/// </summary>
namespace ResakssAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
           
            /*
            // ShowShanuControl();
            //INITIALISER LE NAVIGATEUR POUR JAVASCRIPTE
            SetBrowserFeatureControl();
            //webEatlas eatlas = new webEatlas();

            //eatlas.siteEatlas.Navigate(Globals.ThisAddIn.UrlSite);
            var AssemblyPath = AppDomain.CurrentDomain.BaseDirectory;
            string applicationDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

            //POUR AFFICHER LE SITE DE RESAKSS
            myCustomTaskPane.Visible = false;
            myCustomTaskPane.VisibleChanged +=
                  new EventHandler(taskPaneValue_VisibleChanged);

          */
                
        }
        
  
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}

