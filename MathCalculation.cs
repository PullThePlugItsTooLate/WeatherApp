using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// StudentName: Suvashin
/// Student Number: 19003564
/// Module: Prog
/// </summary>

namespace WeatherApp
{
    public class MathCalculation
    {
        public static int findLowest(int i, int y)//finding the lowest value used for finding the lowest minimum value
        {
            if (y <= i)
            {
                return y;
            }
            else
            {
                return i;
            }
        }

        public static int findHighest(int i, int y)//finding the highest value used for finding the highest values across all number atttributes inn the forecast list
        {
            if (y >= i)
            {
                return y;
            }
            else
            {
                return i;
            }
        }
    }
}
