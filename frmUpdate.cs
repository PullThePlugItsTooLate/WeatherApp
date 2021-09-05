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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            txbCity.Text = ForecastList.lstForecast[DataPopulation.pointer].City;
            dtpDate.Value = ForecastList.lstForecast[DataPopulation.pointer].Date;
            nudMinTemp.Value = ForecastList.lstForecast[DataPopulation.pointer].MinTemp;
            nudMaxTemp.Value = ForecastList.lstForecast[DataPopulation.pointer].MaxTemp;
            nudPrecip.Value = ForecastList.lstForecast[DataPopulation.pointer].Precip;
            nudHumidity.Value = ForecastList.lstForecast[DataPopulation.pointer].Humidity;
            nudWindSpeed.Value = ForecastList.lstForecast[DataPopulation.pointer].WindSpeed;
            cmbCondition.SelectedItem = ForecastList.lstForecast[DataPopulation.pointer].Condition;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataPopulation.verifyAddForecast(txbCity, dtpDate, nudMinTemp, nudMaxTemp, nudPrecip, nudHumidity, nudWindSpeed, cmbCondition, 1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag, this);
        }

        private void frmUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComponentDisplay.backButton((frmMainWeatherMenu)Tag);
        }
    }
}
