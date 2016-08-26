using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_lesson_12
{
    enum ZodiacIndexes
    {
        Aries,
        Leo,
        Sagittarius,
        Taurus,
        Virgo,
        Capricorn,
        Gemini,
        Libra,
        Aquarius,
        Cancer,
        Scorpio,
        Pisces
    }

    public struct Zodiac
    {
        public string name;
        public DateTime startDate;
        public DateTime endDate;

        public Zodiac(string name, string startDate, string endDate)
        {
            this.name = name;
            this.startDate = Convert.ToDateTime(startDate);
            this.endDate = Convert.ToDateTime(endDate);
        }
    }
}
