﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    internal class HiringDate : IComparable<HiringDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int CompareTo(HiringDate other)
        {
            if (Year != other.Year) return Year.CompareTo(other.Year);
            if (Month != other.Month) return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
