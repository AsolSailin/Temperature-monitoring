using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_monitoring
{
    class Test
    {
        string name = "Сёмга";
        int maxTemp = 5;
        int maxTime = 20;
        int minTemp = -3;
        int minTime = 60;
        string date = "12.06.2022 12:23";
        string temp = "1 2 3 3 4 3 5 4 2 1 1 1 1 0 -1 -2 -2 -3 -4 -4 -5 -5 -4 -4 -4 -3";

        //string name = "Минтай";
        //int maxTemp = -5;
        //int maxTime = 20;
        //string date = "14.06.2022 06:17";
        //string temp = "-10 -8 -4 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -2 -4 -4 -5 -5 -4 -4 -4";

        public void Date_Time(string date)
        {
            this.date = date;

            int year, month, day, hour, minute;
            DateTime newDate;
            string[] strDateTime = date.Split(" ");
            string[] strDate = strDateTime[0].Split(".");
            string[] strTime = strDateTime[1].Split(":");

            day = int.Parse(strDate[0]);
            month = int.Parse(strDate[1]);
            year = int.Parse(strDate[2]);
            hour = int.Parse(strTime[1]);
            minute = int.Parse(strTime[0]);

            newDate = new DateTime(year, month, day, hour, minute, 0);
        }
        public void Temp(string temp, int maxTemp, int minTemp)
        {
            this.temp = temp;
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;

            string[] temp2 = temp.Split(" ");

            int max, min = 0;

            for (int i = 0; i < temp2.Length; i++)
            {
                if (int.Parse(temp2[i]) > maxTemp)
                {
                    max = int.Parse(temp2[i]);
                }
                else if (int.Parse(temp2[i]) < minTemp)
                {
                    min = int.Parse(temp2[i]);
                }
            }
        }
    }
}
