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
    public partial class frmMainWeatherMenu : Form
    {
        public frmMainWeatherMenu()
        {
            FileManipulation.ReadFromFile();
            InitializeComponent();
            DataPopulation.populateCityList(cmbCity);
            DataPopulation.setHeader(lblForecastHeader);
            btnShowMore.Hide();
            btnBackForecast.Hide();

            ForecastList.lstLblForecastDetails.Add(lblForecastDetail1);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail2);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail3);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail4);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail5);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail6);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail7);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail8);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail9);
            ForecastList.lstLblForecastDetails.Add(lblForecastDetail10);

            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail1);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail2);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail3);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail4);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail5);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail6);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail7);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail8);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail9);
            ForecastList.lstPnlForecastDetails.Add(pnlForecastDetail10);

            ForecastList.lstPbForecastIcons.Add(pbForecastDetail1);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail2);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail3);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail4);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail5);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail6);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail7);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail8);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail9);
            ForecastList.lstPbForecastIcons.Add(pbForecastDetail10);

            ForecastList.lstFocusForecastDetails.Add(lblMinTemp);
            ForecastList.lstFocusForecastDetails.Add(lblMaxTemp);
            ForecastList.lstFocusForecastDetails.Add(lblPrecip);
            ForecastList.lstFocusForecastDetails.Add(lblHumidity);
            ForecastList.lstFocusForecastDetails.Add(lblWindSpeed);
            ForecastList.lstFocusForecastDetails.Add(lblCondition);

            ForecastList.lstPbrFocusForecastDetails.Add(pbrPrecip);
            ForecastList.lstPbrFocusForecastDetails.Add(pbrHumidity);
            ForecastList.lstPbrFocusForecastDetails.Add(pbrWindSpeed);

            intializeData(cmbCity);

            if (FileManipulation.userType.Equals("gu"))
            {
                btnAdd.Hide();
                btnUpdate.Hide();
            }

            FileManipulation.ReadFromCookieFile(cmbFavCity);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComponentDisplay.formTransitions(this, new frmAddForecast());
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ComponentDisplay.formTransitions(this, new frmReportForecast());
        }

        public void intializeData(ComboBox cmb)
        {
            DataPopulation.j = 0;
            ComponentDisplay.detailButton(0, btnBackForecast);
            DataPopulation.clearFields(lblMinTemp, lblMaxTemp, lblPrecip, lblHumidity, lblWindSpeed);
            DataPopulation.populateForecastDetailsPanel(cmb);
            DataPopulation.onClickPnlDetails(lblForecastDetail1,pbCondition);
            ComponentDisplay.showSelectedPnl(0);
            DataPopulation.btnShowCheck(btnShowMore);
            
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            intializeData(cmbCity);
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            btnBackForecast.Show();
            DataPopulation.populateForecastDetailsPanel(cmbCity);
            ComponentDisplay.detailButton(ForecastList.lstForecastFound.Count, btnShowMore);
        }

        private void btnBackForecast_Click(object sender, EventArgs e)
        {
            DataPopulation.setCounter();
            btnShowMore.Show();
            ComponentDisplay.detailButton(0, btnBackForecast);
            DataPopulation.populateForecastDetailsPanel(cmbCity);
        }

        //panel details

        private void lblForecastDetail1_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail1, pbCondition);
            ComponentDisplay.showSelectedPnl(0);
        }

        private void pbForecastDetail1_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail1, pbCondition);

            ComponentDisplay.showSelectedPnl(0);
        }

        private void pnlForecastDetail1_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail1, pbCondition);//right here each lbl

            ComponentDisplay.showSelectedPnl(0);

        }

        private void pnlForecastDetail2_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail2, pbCondition);

            ComponentDisplay.showSelectedPnl(1);
        }

        private void lblForecastDetail2_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail2, pbCondition);

            ComponentDisplay.showSelectedPnl(1);
        }

        private void pbForecastDetail2_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail2, pbCondition);

            ComponentDisplay.showSelectedPnl(1);
        }

        private void pnlForecastDetail3_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail3, pbCondition);

            ComponentDisplay.showSelectedPnl(2);
        }

        private void lblForecastDetail3_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail3, pbCondition);

            ComponentDisplay.showSelectedPnl(2);
        }

        private void pbForecastDetail3_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail3, pbCondition);

            ComponentDisplay.showSelectedPnl(2);
        }

        private void pnlForecastDetail4_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail4, pbCondition);

            ComponentDisplay.showSelectedPnl(3);
        }

        private void lblForecastDetail4_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail4, pbCondition);

            ComponentDisplay.showSelectedPnl(3);
        }

        private void pbForecastDetail4_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail4, pbCondition);

            ComponentDisplay.showSelectedPnl(3);
        }

        private void pnlForecastDetail5_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail5, pbCondition);

            ComponentDisplay.showSelectedPnl(4);
        }

        private void lblForecastDetail5_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail5, pbCondition);

            ComponentDisplay.showSelectedPnl(4);
        }

        private void pbForecastDetail5_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail5, pbCondition);

            ComponentDisplay.showSelectedPnl(4);
        }

        private void pnlForecastDetail6_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail6, pbCondition);

            ComponentDisplay.showSelectedPnl(5);
        }

        private void lblForecastDetail6_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail6, pbCondition);

            ComponentDisplay.showSelectedPnl(5);
        }

        private void pbForecastDetail6_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail6, pbCondition);

            ComponentDisplay.showSelectedPnl(5);
        }

        private void pnlForecastDetail7_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail6, pbCondition);

            ComponentDisplay.showSelectedPnl(6);
        }

        private void lblForecastDetail7_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail7, pbCondition);

            ComponentDisplay.showSelectedPnl(6);
        }

        private void pbForecastDetail7_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail7, pbCondition);

            ComponentDisplay.showSelectedPnl(6);
        }

        private void pnlForecastDetail8_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail8, pbCondition);

            ComponentDisplay.showSelectedPnl(7);
        }

        private void lblForecastDetail8_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail8, pbCondition);

            ComponentDisplay.showSelectedPnl(7);
        }

        private void pbForecastDetail8_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail8, pbCondition);

            ComponentDisplay.showSelectedPnl(7);
        }

        private void pnlForecastDetail9_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail9, pbCondition);

            ComponentDisplay.showSelectedPnl(8);
        }

        private void lblForecastDetail9_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail9, pbCondition);

            ComponentDisplay.showSelectedPnl(8);
        }

        private void pbForecastDetail9_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail9, pbCondition);

            ComponentDisplay.showSelectedPnl(8);
        }

        private void pnlForecastDetail10_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail10, pbCondition);

            ComponentDisplay.showSelectedPnl(9);
        }

        private void lblForecastDetail10_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail10, pbCondition);

            ComponentDisplay.showSelectedPnl(9);
        }

        private void pbForecastDetail10_Click(object sender, EventArgs e)
        {
            DataPopulation.onClickPnlDetails(lblForecastDetail10, pbCondition);

            ComponentDisplay.showSelectedPnl(9);
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ComponentDisplay.formTransitions(this, new frmUpdate());
        }

        private void btnFavCity_Click(object sender, EventArgs e)
        {
            ComponentDisplay.formTransitions(this, new frmFavouriteCity());
        }

        private void cmbFavCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            intializeData(cmbFavCity);
        }

        private void frmMainWeatherMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
