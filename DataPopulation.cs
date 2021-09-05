using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
    public class DataPopulation
    {
        public static int pointer = -1;//used to keep track of the index of the panel that the user selected
        public static int j = 0; //used to keep track of all the items with different dates but the same city, its used as an index
        public static int numOfIterations = 0; //another index that is used to help return to the previous set of 10 items

        public static void populateForecastDetailsPanel(ComboBox cmbCity)
        {
            ForecastList.lstForecastFound.Clear();//pulling static list from forecastlist class this list is used to store items of the same city name but different date

            foreach (Panel panel in ForecastList.lstPnlForecastDetails) // goes to each panel stored in the panel list
            {
                panel.Hide();//hides all of the panels in the list
            }

            int k = 0;//used at an index to ensure that only 10 items get displayed at a time
            numOfIterations = 0;//assigned to zero in order to reset for the next method call

            foreach (Forecast item in ForecastList.lstForecast)//for each item in the forecast list do the following code
            {
                if (cmbCity.SelectedItem.Equals(item.City)) //checks if the selected city is equal to an item stored in the list
                {
                    ForecastList.lstForecastFound.Add(item);//adds the item to the found list because theres a city that has a forecast which the user selected
                }
            }
            
            for (int i = 0; i < ForecastList.lstForecastFound.Count; i++)//repeat this loop for the number of items there are in the found item list
            {
                if (k < 10 && j < ForecastList.lstForecastFound.Count)//display then do not attempt to display anything more
                {
                    
                    ForecastList.lstLblForecastDetails[k].Text = ForecastList.lstForecastFound[j].displayDetails(); //goes to the list of labels and then assigns it to the displayDetails method of the item stored in the found list . the display method is similar to a toString
                    ForecastList.lstPbForecastIcons[k].Image = Image.FromFile(ForecastList.lstForecastFound[j].WeatherIcon); //goes to the list of picture boxes. then that goes to the picture boxes property and assigns it to the weather icon thats stored in the forecast item
                    ForecastList.lstPnlForecastDetails[k].Show();//if those components are displayed prior then use their index and display the panel 
                    numOfIterations++;//keeping track of how many times this loop runs
                }
                else
                {
                    break;//immediately break if that citerion isnt met. code efficiency and reduces error by avoiding using a try catch
                }
                j++;//increase the index to be used for finding the rest of the items in the found list if the list is longer than 10 items
                k++;//ensuring only 10 items get shown at a time
            }
        }

        public static void populateCityList(ComboBox cmbCity)//populates the city combo box with city property from forecast list
        {
            cmbCity.Items.Clear();//first clears the combo box so that previous data wont be added to the new
            foreach (Forecast item in ForecastList.lstForecast)//for each item in the forecast list do the following code
            {
                if (!(cmbCity.Items.Contains(item.City)))//if the city isnt in the combo box then add it there
                {
                    cmbCity.Items.Add(item.City);// addiing an item city property to the combo box
                }
            }
            cmbCity.Sorted = true;//sorts the combo box in alphabetical order
            try
            {
                cmbCity.SelectedIndex = 0; //if there is a city to add then just select the first one
            }
            catch (Exception)
            {
                
            }
        }

        public static void setHeader(Label lblForecastHeader)
        {
            string s = "        "; //space which is meant to resemble a \t 
            string s2 = "  "; // altered space 
            //\t can't be used in labels
            lblForecastHeader.Text = "Condition" + s + "Date" + s + s + s + s2 + "Forecast";//formatting the header
        }

        public static void btnShowCheck(Button btnShow)
        {
            if (j >= 10) //if the index is greater than 10 then a button to show the rest of the items needs to be shown
            {
                btnShow.Show();//show the button
            }
            else 
            {
                btnShow.Hide();//hide the button
            }
        }

        public static void onClickPnlDetails(Label lblDetails ,PictureBox pbCondition) //parameters for labels and a picture box
        {
            pointer = -1;//pointer helps keep track of what panel the user selected
            foreach (Forecast item in ForecastList.lstForecast)//foreach item in the forecast list
            {

                pointer++;//incrementing the pointer, to loop through
                if (lblDetails.Text.Equals(item.displayDetails()))//matches what the user selected to what is in the list and then pulls all that data through                                                                            //they at the same because the entire to string of the forecast is like a primary key 
                {
                    ForecastList.lstFocusForecastDetails[0].Text = "↓ " + item.MinTemp.ToString() + " °C";//stores the min temp in the list
                    ForecastList.lstFocusForecastDetails[1].Text = "↑ " + item.MaxTemp.ToString() + " °C";//stores the max temp in the list
                    ForecastList.lstFocusForecastDetails[2].Text = item.Precip.ToString() + "%";//stores the precip in the list
                    ForecastList.lstFocusForecastDetails[3].Text = item.Humidity.ToString() + "%";//stores the humidity in the list
                    ForecastList.lstFocusForecastDetails[4].Text = item.WindSpeed.ToString() + " km/h";//stores the windspeed in the list
                    ForecastList.lstFocusForecastDetails[5].Text = item.Condition;//stores the condition in the list

                    ForecastList.lstPbrFocusForecastDetails[0].Value = item.Precip;//sets the progress bar for the precip value
                    ForecastList.lstPbrFocusForecastDetails[1].Value = item.Humidity;//sets the progress bar for the humidity value
                    ForecastList.lstPbrFocusForecastDetails[2].Value = Convert.ToInt32(Convert.ToDouble(item.WindSpeed) / 380 * 100);//sets the progress bar for the windspeed

                    foreach (ProgressBar bar in ForecastList.lstPbrFocusForecastDetails)//loops through the progress bars
                    {
                        setPbrColor(bar);//sets the color for the progress bar
                    }

                    pbCondition.Image = Image.FromFile(item.WeatherIcon);//sets appropriate image for the forecast selected
                    pbCondition.SizeMode = PictureBoxSizeMode.StretchImage;//streches the image to fit the picture component
                    break;//code efficiency, once the if statement has been triggered there is no need to carry on looping through the entire list
                }
            }
        }

        public static void setPbrColor(ProgressBar pbrItemDetail) //set the progress bar color
        {
            pbrItemDetail.SetState(1);//set the progress bar to green

            if (pbrItemDetail.Value > 33 && pbrItemDetail.Value < 67)//if the value gets to mid range then change color
            {
                pbrItemDetail.SetState(3);//change the progress bar to yellow
            }
            else 
            {
                if (pbrItemDetail.Value >= 67)//if it get too high then change its color
                {
                    pbrItemDetail.SetState(2);//change the progress bar to red
                }
            }
        }

        public static void setCounter()
        {
            j -= (numOfIterations + 10);// used when the user wants to go back to the previous 10 items ... this method is used to reset the index to go back
        }

        public static void populateCityCheckList(CheckedListBox ckl)//report
        {
            ckl.Items.Clear();//clears the old data so that it can be filled with new data (cities)
            foreach (Forecast item in ForecastList.lstForecast) //does the code below for each item in the forecast list
            {
                if (!(ckl.Items.Contains(item.City)))//if the city is not in the list then add it there
                {
                    ckl.Items.Add(item.City);// adding a city to a check list box
                }
            }
            ckl.Sorted = true;//sorts the cities in alphabetical order
            try
            {
                ckl.SelectedIndex = 0;//if there is a city then select it (the first one)
            }
            catch (Exception)
            {
                
            }
        }
        
        public static void clearFields(Label lblMinTemp,//simply assigns all the labels that display the specific details for each item to a starting value of zero
            Label lblMaxTemp, //passing labels for displaying
            Label lblPrecip,
            Label lblHumidity,
            Label lblWindSpeed)
        {
            lblMinTemp.Text = "0 °C"; //concat degree symbol
            lblMaxTemp.Text = "0 °C";
            lblPrecip.Text = "0%";
            lblHumidity.Text = "0%";
            lblWindSpeed.Text = "0 km/h";
        }

        public static string extremeReport = "";//used to generate the lowest minimum and highest everything else
        public static string concat = "";//used to generate the normal report

        public static void generateReport(RichTextBox rtbx,
            CheckedListBox ckl,
            DateTimePicker dtpStart,
            DateTimePicker dtpEnd) //passes in components from the report form
        {
            concat = "General Report" + "\n----------------------------------\n";//clear the old data
            extremeReport = "";//clear the old data
            rtbx.Clear();//clear the rich text box
            
            int minTemp = 1000;//created variables used to sift out the extreme values
            int maxTemp = 0;
            int precip = 0;
            int humidity = 0;
            int windSpeed = 0;

            foreach (var city in ckl.CheckedItems)//for item that is check do the following
            {
                if (!(ckl.SelectedIndex == -1 || ckl.CheckedItems.Count == 0)) //making sure that atleast something is selected
                {
                    foreach (Forecast item in ForecastList.lstForecast) // for each item in the forecast list do the following code
                    {
                        if (city.ToString().Equals(item.City))//if the checked item is equal to an attribute (city) in the items in forcast then do the following
                        {
                            if (DateTime.Compare(dtpStart.Value, item.Date.AddHours(24)) <= 0
                                && DateTime.Compare(dtpEnd.Value, item.Date) >= 0) //ensures that the date you have selected is within the items range
                            {
                                concat += item.ToString() + "\n\n";//calls the tostring method of the item and concats it to a string avariable which creates the report
                                minTemp = MathCalculation.findLowest(minTemp, item.MinTemp);//calls the findlowest method which attempts to find the lowest value
                                maxTemp = MathCalculation.findHighest(maxTemp, item.MaxTemp);//calls the findHighest method which attempts to find the highest values
                                precip = MathCalculation.findHighest(precip, item.Precip);
                                humidity = MathCalculation.findHighest(humidity, item.Humidity);
                                windSpeed = MathCalculation.findHighest(windSpeed, item.WindSpeed);
                            }
                        }
                    }

                    if (!(minTemp == 1000))//if the min Temperature is not equal to 1000 then do the following
                    {
                        extremeReport += "\nCity: " + city//generates the side headings
                        + "\nMin: " + minTemp
                        + "\nMax: " + maxTemp
                        + "\nPrecipitation: " + precip
                        + "\nHumidity: " + humidity
                        + "\nWind Speed: " + windSpeed
                        + "\n\n";
                    }

                    minTemp = 1000;//reassigning values for the next iteration
                    maxTemp = 0;
                    precip = 0;
                    humidity = 0;
                    windSpeed = 0;
                }
                else
                {
                    MessageBox.Show("Try selecting a City");
                }
            }

            extremeReport = "Intense Value Report:"//basic string formatting
                + "\n----------------------------------"
                + extremeReport
                + "\n----------------------------------";
            rtbx.Text = concat;//sends the text to the component
            FileManipulation.WriteReportToFile(concat);//records the data in the report file
        }

        public static void appendReport(RichTextBox rtbxOutput)
        {
            rtbxOutput.Clear();//clears the components
            rtbxOutput.Text = extremeReport + "\n\n" + concat;//appends the output
            FileManipulation.WriteReportToFile(extremeReport + "\n\n" + concat);//writes the report to the report txtfile. its basic text so its simple to print out
        }
        //add form
        public static void verifyAddForecast(TextBox txbCity,
            DateTimePicker dtpDate,
            NumericUpDown nudMinT,
            NumericUpDown nudMaxT,
            NumericUpDown nudP,
            NumericUpDown nudH,
            NumericUpDown nudWs,
            ComboBox cmbCondition,
            int methodShift) //passing the add form components
        {
            bool flag = false;//used to tell whether an item should be added or not 
            if (!(string.IsNullOrWhiteSpace(txbCity.Text)))//checks if the text area is blank
            {
                foreach (Forecast item in ForecastList.lstForecast)// foreach item in forecast list
                {
                    if (txbCity.Text.Equals(item.City) && dtpDate.Value.Date.CompareTo(item.Date.Date) == 0 && methodShift == 0)//checks if the date already has a forecast
                    {
                        //checks if the city is equal and then it checks if the date is the same
                        MessageBox.Show(item.City + " already has a forecast for the " + item.Date);//tells the user that the forecast already has a date
                        flag = false;//sets flag false
                        break;//code efficiency
                    }
                    else
                    {
                        flag = true;//allows the program to add an item
                    }
                }
            }
            else
            {
                MessageBox.Show("Try entering a city"); // encourages user input
                flag = false;//sets flag to false
            }

            if (flag)//if true
            {
                string icon = "Weather_Icons/32.png";//just in case but ordinarily this image shouldnt come up unless the user enters text in the combo box

                switch (cmbCondition.SelectedItem)//switch statement dependent on what condition the user selects the appropriate image will be stored in the forecast object
                {
                    case "Sunny"://if the condition is sunny then pick the appropriate image
                        icon = "Weather_Icons/01.png";
                        break;
                    case "Few Clouds"://if the condition is few clouds then pick the appropriate image
                        icon = "Weather_Icons/02.png";
                        break;
                    case "Scattered Clouds"://if the condition is scattered clouds then pick the appropriate image
                        icon = "Weather_Icons/03.png";
                        break;
                    case "Broken Clouds"://if the condition is broken clouds then pick the appropriate image
                        icon = "Weather_Icons/04.png";
                        break;
                    case "Cloudy"://if the condition is cloudy then pick the appropriate image
                        icon = "Weather_Icons/05.png";
                        break;
                    case "Misty"://if the condition is misty then pick the appropriate image
                        icon = "Weather_Icons/06.png";
                        break;
                    case "Rain"://if the condition is rain then pick the appropriate image
                        icon = "Weather_Icons/07.png";
                        break;
                    case "Thundershower"://if the condition is thundershowers then pick the appropriate image
                        icon = "Weather_Icons/08.png";
                        break;
                    case "Hail"://if the condition is hail then pick the appropriate image
                        icon = "Weather_Icons/09.png";
                        break;
                    case "Snow"://if the condition is snow then pick the appropriate image
                        icon = "Weather_Icons/10.png";
                        break;
                    default:
                        MessageBox.Show("Please select a Weather Condition");//in case the user has not selected any condition
                        break;
                }

                if (methodShift == 0)//uses the same code but runs this block when I need it to
                {
                    FileManipulation.WriteToFile(txbCity.Text,//parsing in all the string values for the method
                    dtpDate.Value.ToString(),
                    nudMinT.Value.ToString(),
                    nudMaxT.Value.ToString(),
                    nudP.Value.ToString(),
                    nudH.Value.ToString(),
                    nudWs.Value.ToString(),
                    icon,
                    cmbCondition.Text);

                    MessageBox.Show("You have successfully added a new forecast");// tells the user they added an item
                    FileManipulation.ReadFromFile();//calls the read from file
                }

                if (methodShift == 1)//uses the same code prior but runs this block when its needed
                {
                    ForecastList.lstForecast[DataPopulation.pointer].City = txbCity.Text;//helps point to the forecast the user selected
                    ForecastList.lstForecast[DataPopulation.pointer].Date = dtpDate.Value;
                    ForecastList.lstForecast[DataPopulation.pointer].MinTemp = Convert.ToInt32(nudMinT.Value);
                    ForecastList.lstForecast[DataPopulation.pointer].MaxTemp = Convert.ToInt32(nudMaxT.Value);
                    ForecastList.lstForecast[DataPopulation.pointer].Precip = Convert.ToInt32(nudP.Value);
                    ForecastList.lstForecast[DataPopulation.pointer].Humidity = Convert.ToInt32(nudH.Value);
                    ForecastList.lstForecast[DataPopulation.pointer].WindSpeed = Convert.ToInt32(nudWs.Value);
                    ForecastList.lstForecast[DataPopulation.pointer].Condition = cmbCondition.SelectedItem.ToString();
                    ForecastList.lstForecast[DataPopulation.pointer].WeatherIcon = icon;
                    FileManipulation.writeListToFile();//updates the file
                    MessageBox.Show("You have successfully updated the forecast");//tells the user that they have updated the forecast
                }
            }
        }

        public static void setDate(DateTimePicker dtpDate)
        {
            dtpDate.MinDate = DateTime.Now;//ensures that the user does not forecast for the past
        }
    }
}