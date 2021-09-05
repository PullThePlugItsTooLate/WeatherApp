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
    public partial class frmFavouriteCity : Form
    {
        public frmFavouriteCity()
        {
            InitializeComponent();
            DataPopulation.populateCityCheckList(cklCity);
        }

        private void btnFavSelection_Click(object sender, EventArgs e)
        {
            FileManipulation.WriteFavsFile(cklCity);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag, this);
        }

        private void frmFavouriteCity_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag);
        }
    }
}
