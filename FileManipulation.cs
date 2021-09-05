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
    public static class FileManipulation
    {
        private static StreamReader fileReader;//declaring a file reader 
        private static StreamWriter writeToFile;//declaring a file writer
        public static string userType = "wf";//declaring a usertype variable
        private static string usernameP = "";//declaring a username variable to store the just users username

        public static void ReadFromFile()//reads from textfile the forecasts into the main list
        {
            ForecastList.lstForecast.Clear();//clears forecast list
            string line;//declaring a string variable
            if (File.Exists("ForecastListData.txt"))//checks if the file exists
            {
                int i = 0;//declares an integer variable and assigns it to zero
                try
                {
                    fileReader = new StreamReader("ForecastListData.txt");//filereader is assigned to read the forecastlistdata
                    while ((line = fileReader.ReadLine()) != null)//while the file reader is not at the end of the file keep on running the loop
                    {
                        ForecastList.lstForecast.Add(new Forecast());//create a new forecast object in the main forecast list
                        ForecastList.lstForecast[i].City = line;//assign the city attribute to line 
                        ForecastList.lstForecast[i].Date = Convert.ToDateTime(fileReader.ReadLine());//assign the string from the file to the date attribute. the string needs to be converted first into date
                        ForecastList.lstForecast[i].MinTemp = Convert.ToInt32(fileReader.ReadLine());//assign the string read from the file to min temperature. the string needs to be converted first before it can be assigned 
                        ForecastList.lstForecast[i].MaxTemp = Convert.ToInt32(fileReader.ReadLine());//assign the string read from the file to max temperature. the string needs to be converted first before it can be assigned 
                        ForecastList.lstForecast[i].Precip = Convert.ToInt32(fileReader.ReadLine());//assign the string read from the file to the precip attribute. the value needs to be converted
                        ForecastList.lstForecast[i].Humidity = Convert.ToInt32(fileReader.ReadLine());//assign the string read from the file to humidity. the string needs to be converted first before it can be assigned 
                        ForecastList.lstForecast[i].WindSpeed = Convert.ToInt32(fileReader.ReadLine());//assign the string read from the file to windspeed. the string needs to be converted first before it can be assigned 
                        ForecastList.lstForecast[i].WeatherIcon = fileReader.ReadLine();//assign the string read from the filereader to the weathericon file path
                        ForecastList.lstForecast[i].Condition = fileReader.ReadLine();//assign the string read from the filereader to the condition attribute for the object
                        i++;//increments the i value by one
                    }
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);//shows error message
                }
            }
            else
            {
                MessageBox.Show("File does not exsist");
            }

            try
            {
                fileReader.Close();//close the file reader
            }
            catch(Exception)
            {
                MessageBox.Show("file reader could not close properly");//tells the user that the file could not be closed properly
            }
        }

        public static void ReadFromCookieFile(ComboBox cmb)
        {
            cmb.Items.Clear();//clears the combo box of all data that it may have 
            cmb.Text = "";//clears the selected text from the combo box
            string fav = "";//declares and assigns the fav string variable to an empty string

            if (File.Exists("FavouriteCities.txt"))//checks if the file exists
            {
                string[] lines = File.ReadAllLines("FavouriteCities.txt");//declares an array called lines of type string and read all the lines from the favourite cities.txt to the array

                foreach (string line in lines)//run this code for each string inside the array lines 
                {
                    if (line.Contains(usernameP))//checks to see if the line variable contains the users username in it 
                    {
                        fav = line;//takes the line variable and assigns it to the fav variable
                    }
                }

                string[] col = fav.Split('#');//declare an array of strings and assign it to split the fav variable using # as a delimiter. 
                for (int i = 1; i < col.Length; i++)//run this for the length of the col array
                {
                    cmb.Items.Add(col[i]);//add the cities to the combo box in the main form ... making sure to leave out the username 
                }
            }
            else
            {
                MessageBox.Show("File does not exsist");//tells the user that the favourites file is not it the apps directory
            }
        }

        public static void ReadFromLoginFile(string username, string password, Form frmLogin)
        {
            int flag = 0;//integer variable named flag assigned to zero
            string line;//string variable named line 
            
            if (File.Exists("Login.txt"))//checks if the login file exists
            {
                try
                {
                    fileReader = new StreamReader("Login.txt");//filereader is assigned to read the login file
                    while ((line = fileReader.ReadLine()) != null)//loop through this code until it reaches the end of the file
                    {
                        if (line.Equals(username))//if the line equals to the username then do the following
                        {
                            if (fileReader.ReadLine().Equals(password))//if the line is equal to the users password  then do the following
                            {
                                flag++;//incrementing the flag variable
                                usernameP = username;//assigns the username in the method to the global username variable

                                if (fileReader.ReadLine().Equals("gu"))//reads the file and checks the usertype of the user
                                {
                                    userType = "gu";//assigns the usertype to general user
                                }
                            }
                        }
                    }

                    if (flag == 0)//if the flag variable is assigned to zero then do the following code
                    {
                        MessageBox.Show("Please check that you have entered your correct username and password");//tells the user to check their credentials
                    }
                    else 
                    {
                        ComponentDisplay.formTransitions(frmLogin, new frmMainWeatherMenu());//otherwise the user has successfully logged it, show them the main forecast screen
                    }
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);//error message 
                }
            }
            else
            {
                MessageBox.Show("File does not exsist");//error message for the file not being found
            }
            fileReader.Close();//close the file reader
        }

        public static void WriteToFile(string sCity,
            string sDate,
            string sMinTemp,
            string sMaxTemp,
            string sPrecip,
            string sHumidity,
            string sWindSpeed,
            string sWeatherIcon,
            string sCondition) //parameters for the method to write to the forecast file
        {
            try
            {
                writeToFile = new StreamWriter("ForecastListData.txt", true);//append the file
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid directory" + exc.Message);//error message in case the creation of the file failed in the case that one was not found
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);//error message for an io error occuring
            }

            try
            {
                writeToFile.WriteLine(sCity);
                writeToFile.WriteLine(sDate);
                writeToFile.WriteLine(sMinTemp);
                writeToFile.WriteLine(sMaxTemp);
                writeToFile.WriteLine(sPrecip);
                writeToFile.WriteLine(sHumidity);
                writeToFile.WriteLine(sWindSpeed);
                writeToFile.WriteLine(sWeatherIcon);
                writeToFile.WriteLine(sCondition);//individually adding each attribute to the file
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);//error message for an io error occuring
            }

            try
            {
                writeToFile.Close();//close the file writer
            }
            catch
            {
                MessageBox.Show("File did not close properly: ");//error message showing that the file did not close properly
            }
        }

        public static void WriteFavsFile(CheckedListBox cklbList) //parameters for a check list box
        {
            string line = "";//creates the a variable of type string assigning it to empty string
            List<string> favouriteCityList = new List<string>();//declaring a list of type strings
            int overwriteIndex = 0;//used for pointing to a specific index
            bool userFavExists = false;//declares a bool type variable and assigning it to false

            if (File.Exists("FavouriteCities.txt"))//checks if file exists
            {
                try
                {
                    fileReader = new StreamReader("FavouriteCities.txt");// assigns the file reader to read the favourite cities text file
                    while ((line = fileReader.ReadLine()) != null)//while the file reader is not at the end of the file keep running the following code
                    {
                        favouriteCityList.Add(line);//read all the lines in the file to the list
                    }

                    for (int i = 0; i < favouriteCityList.Count; i++)//for the length of the favourite city list do the following code
                    {
                        if (favouriteCityList[i].Contains(usernameP))//if the list contains the current users username then run the following code
                        {
                            overwriteIndex = i;//assign the overwriteindex to i
                            userFavExists = true;//assign the userfavexists variable to true
                        }
                    }

                    if (userFavExists)//if the userfavexists variable is true then do the following code
                    {
                        favouriteCityList.RemoveAt(overwriteIndex);//go to the list and remove that specific string 
                    }

                    line = usernameP;//assign the users current username to the line variable
                    for (int i = 0; i < cklbList.Items.Count; i++)//run this code for the length of the check list box 
                    {
                        if (cklbList.GetItemChecked(i))//check if the item is checked
                        {
                            line += "#" + (string)cklbList.Items[i];//if it is checked then store it in the line variable
                        }
                    }
                    favouriteCityList.Add(line);//once the loop is complete add the line variable to the list
                }
                catch (System.IO.IOException exc)
                {
                    MessageBox.Show(exc.Message);//shows an error message when an io error occurs
                }
            }
            else
            {
                MessageBox.Show("File does not exist");//tells the user that the file does not exist
            }
            fileReader.Close();//close the file reader

            try
            {
                writeToFile = new StreamWriter("FavouriteCities.txt", false);//overwrite the file
                foreach (string favCity in favouriteCityList)//do the following code for each of the items in favourite city list
                {
                    writeToFile.WriteLine(favCity);//write the entire string to the file, the username and all the favourite cities
                }
                MessageBox.Show("Your Favourite Cities have been saved");//tells the user that their favourite cities have been saved
            }

            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid directory" + exc.Message);//error message for invalid directory
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);//error message showing if an io error occurs
            }

            try
            {
                writeToFile.Close();//close the file writer
            }
            catch
            {
                MessageBox.Show("File did not close properly: ");//tells the user that the file did not close properly
            }
        }

        public static void writeListToFile()
        {
            try
            {
                writeToFile = new StreamWriter("ForecastListData.txt", false);//overwrite the file
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid directory" + exc.Message);//error message showing if the directory isnt found
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);//show error message if an io error occurs
            }

            try
            {
                foreach (var item in ForecastList.lstForecast)//foreach item in the list do the following code
                {
                    writeToFile.WriteLine(item.City);
                    writeToFile.WriteLine(item.Date);
                    writeToFile.WriteLine(item.MinTemp);
                    writeToFile.WriteLine(item.MaxTemp);
                    writeToFile.WriteLine(item.Precip);
                    writeToFile.WriteLine(item.Humidity);
                    writeToFile.WriteLine(item.WindSpeed);
                    writeToFile.WriteLine(item.WeatherIcon);
                    writeToFile.WriteLine(item.Condition);//write each attribute of the object to the file
                }
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }

            try
            {
                writeToFile.Close();//close the file writer
            }
            catch
            {
                MessageBox.Show("File did not close properly: ");//tells the user that the file did not close properly
            }
        }

        public static void WriteReportToFile(string report) //stores the generated report in the file
        {
            try
            {
                writeToFile = new StreamWriter("Report.txt", false);//overwrite the report text file
            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show("Invalid directory" + exc.Message);
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }

            try
            {
                    writeToFile.WriteLine(report);//stores the report to text file
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }

            try
            {
                writeToFile.Close();//close the file writer
            }
            catch
            {
                MessageBox.Show("File did not close properly: ");//tells the user that the file did not close properly
            }
        }
    }
}
