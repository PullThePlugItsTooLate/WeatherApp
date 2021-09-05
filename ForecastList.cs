using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{
    class ForecastList
    {
        public static List<Forecast> lstForecast = new List<Forecast>();


        public static List<Forecast> lstForecastFound = new List<Forecast>();// used for finding many items with the same city but different dates;
        public static List<Label> lstLblForecastDetails = new List<Label>();//used for passing labels 
        public static List<Panel> lstPnlForecastDetails = new List<Panel>();//used for passing panels
        public static List<PictureBox> lstPbForecastIcons = new List<PictureBox>();//used for passing picture boxes
        public static List<Label> lstFocusForecastDetails = new List<Label>();//used for passing labels- these are on the left of the UI
        public static List<ProgressBar> lstPbrFocusForecastDetails = new List<ProgressBar>();//used for passing progressbars
    }
}
