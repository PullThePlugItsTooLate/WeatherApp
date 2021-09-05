using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{
    public class Forecast
    {
        //attributes as requested in the POE as well as weatherIcon and condition as an add on for better functionality
        private string city;
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private int precip;
        private int humidity;
        private int windSpeed;
        private string weatherIcon;
        private string condition;

        //constructor including all attributes as parameters
        public Forecast(string city, DateTime date, int minTemp, int maxTemp, int precip, int humidity, int windSpeed, string weatherIcon, string condition)
        {
            this.city = city;
            this.date = date;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.precip = precip;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.weatherIcon = weatherIcon;
            this.condition = condition;

        }

        public Forecast()
        {

        }

        //gets and sets
        public string City 
        { 
            get => city; set => city = value; 
        }
        //gets and sets
        public DateTime Date 
        { 
            get => date; set => date = value; 
        }
        //gets and sets
        public int MinTemp 
        { 
            get => minTemp; set => minTemp = value; 
        }
        //gets and sets
        public int MaxTemp 
        { 
            get => maxTemp; set => maxTemp = value; 
        }
        //gets and sets
        public int Precip 
        { 
            get => precip; set => precip = value; 
        }
        //gets and sets
        public int Humidity 
        { 
            get => humidity; set => humidity = value; 
        }
        //gets and sets
        public int WindSpeed 
        { 
            get => windSpeed; set => windSpeed = value; 
        }
        //gets and sets
        public string WeatherIcon 
        { 
            get => weatherIcon; set => weatherIcon = value; 
        }
        //gets and sets
        public string Condition 
        { 
            get => condition; set => condition = value; 
        }


        //Overrode toString method displaying details for a forecast object
        public override string ToString()
        {
            return "City: " + city 
                + "\nDate: " + date 
                + "\nMinimum Temperature: " + minTemp 
                + "\nMaximum Temperature: " + maxTemp 
                + "\nPrecipitation: " + precip 
                + "\nHumidity: " + humidity
                + "\nWind Speed: " + windSpeed;
        }

        //displayDetails is similar to the toString however it uses ascii to help display its fields
        public string displayDetails() 
        {
            string s = "        "; //space
            return date.ToShortDateString() + " " + date.ToString("ddd") 
                + s + "↓" + minTemp + " °C"
                + s + "↑" + maxTemp + " °C"
                + s + "🌧" + precip
                + s + "💧" + humidity
                + s + "💨" + windSpeed;
        }
    }
}
