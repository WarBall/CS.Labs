﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs3.Task1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    class WhatDay
    {
        private static void Main()
        {
            int[] DaysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Please enter a day number between 1 and 365: ");
            int dayNum = int.Parse(Console.ReadLine());
            int monthNum = 0;

            foreach (int daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    ++monthNum;
                }
            }

            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();

            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.ReadLine();
        }
    }
}
