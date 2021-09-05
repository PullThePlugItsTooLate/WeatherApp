using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{
    public static class ComponentDisplay
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]//imported to get a different style of progress bars
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);//implements the state change on progress bars

        public static void SetState(this ProgressBar pBar, int state)//takes in a progress back and the integer for how much to fill it 
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);//sets the state for the pointer
        }

        public static void showSelectedPnl(int i)
        {
            ForecastList.lstPnlForecastDetails[i].BackColor = Color.FromArgb(142, 150, 23);//setting the selected panel to a specific 
                                                                                           //colour thats different from the others so that the user will know that they have selected that item
            for (int j = 0; j < 10; j++) //for as long as j is below 10 . this ensures that the code doesnt change 
                                         //colors of panels that dont exist
            {
                if (!(j == i))//do the following code for every panel besides the panel that is selected 
                {
                    if (j % 2 == 0)//j mod 2. used to find out the even panels so that they can be reverted to their 
                                   //original colors
                    {
                        ForecastList.lstPnlForecastDetails[j].BackColor = Color.FromArgb(59, 94, 173);//assigns the even panels to a 
                        //specific color [orginal color]
                    }
                    else
                    {
                        ForecastList.lstPnlForecastDetails[j].BackColor = Color.FromArgb(44, 70, 130);//assings the odd panels to a 
                        //specific color [orginal color]
                    }
                }
            }
        }

        public static void detailButton(int i, Button btnHide)
        {
            if (DataPopulation.j == i)//compares the total index with a count of the list or zero
            {
                btnHide.Hide(); // depending on which button is passed you could hide the show or back button depending 
                //on where about in the list the user is in
            }
        }

        public static void formTransitions(Form frmMain, Form frmInstance)
        {
            //used whenever the user is going from the main form to an external form
            frmInstance.Tag = frmMain;// the tag property stores the current instance of main form and 
            //calls it when the user taps the back button instead of creating an form
            frmInstance.Show(frmMain);//shows the instance and passes the main form as an argument
            frmMain.Hide();//hides the form
        }

        public static void backButton(frmMainWeatherMenu frmMain, Form frmInstance)
        {
            DataPopulation.populateCityList(frmMain.cmbCity);//calling the populatecitylist to fill the combo box again in case of new items
            frmMain.cmbCity.SelectedIndex = 0;//makes the combo
            frmMain.intializeData(frmMain.cmbCity);//calls the intialize data method from the main form
            frmMain.Show();//show main form
            frmMain.btnShowMore.Hide();//hides the show more button
            FileManipulation.ReadFromCookieFile(frmMain.cmbFavCity);//update the favourite cities combo box
            frmInstance.Close();//closes the instance;   
        }
        public static void backButton(frmMainWeatherMenu frmMain)
        {
            DataPopulation.populateCityList(frmMain.cmbCity);//calling the populatecitylist to fill the combo box again in case of new items
            frmMain.cmbCity.SelectedIndex = 0;//makes the combo
            frmMain.intializeData(frmMain.cmbCity);//calls the intialize data method from the main form
            frmMain.Show();//shows the main form
            frmMain.btnShowMore.Hide();//hides the show more button
            FileManipulation.ReadFromCookieFile(frmMain.cmbFavCity);//calling the read from cookie file method to update the favourite city combo box
        }
    }
}
