using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Please note that there is no comments found in this .cs file because all the methods that are used here are called from
/// the back end classes ... all the code has been commented on over there
/// this form simply contains method calls
/// 
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{   
    public partial class frmReportForecast : Form
    {

        public frmReportForecast()
        {
            InitializeComponent();
            DataPopulation.populateCityCheckList(cklCity);
            btnExtremeReport.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            btnExtremeReport.Show();
            DataPopulation.generateReport(rtbxReport, cklCity, dtpStart, dtpEnd);
            ErrorChecking.noReport(rtbxReport, btnExtremeReport);
        }

        private void cklCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BackEndFunction.populateDatepicker(cklCity, dtpStart, dtpEnd);
        }

        private void btnExtremeReport_Click(object sender, EventArgs e)
        {
            DataPopulation.appendReport(rtbxReport);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag, this);
        }

        private void frmReportForecast_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag);
        }
    }
}
