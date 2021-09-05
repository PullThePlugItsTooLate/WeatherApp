using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{
    public class ErrorChecking
    {
        public static void noReport(RichTextBox rtbxReport, Button btnExtremeReport)
        {
            if (string.IsNullOrWhiteSpace(rtbxReport.Text))//checks if the output area is blank
            {
                rtbxReport.Text = "There are sadly no forecasts for the Date Range you have selected :/";//tells the user that a report could not be generated
                btnExtremeReport.Hide();//ensures that the user does not click the generate extreme report before the normal report has been created 
            }
        }
    }
}
