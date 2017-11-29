using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarYearMonth
{
    public class CalendarYearMonth
    {
        #region Constructors

        public CalendarYearMonth() {}

        public CalendarYearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        #endregion

        #region Member variables

        public int Year { get; set; }
        public int Month { get; set; }

        #endregion

        public static CalendarYearMonth operator +(CalendarYearMonth calendarYearMonth, int months)
        {
            CalendarYearMonth calYrMth;
            int totalMonths = ConvertCalendarYearMonthToMonths(calendarYearMonth) + months;
            calYrMth = ConvertMonthsToCalendarYearMonth(totalMonths);
            return calYrMth;
        }

        public static CalendarYearMonth operator +(CalendarYearMonth calendarYearMonth1, CalendarYearMonth calendarYearMonth2)
        {
            CalendarYearMonth calYrMth;
            int totalMonths = ConvertCalendarYearMonthToMonths(calendarYearMonth1)
                + ConvertCalendarYearMonthToMonths(calendarYearMonth2);
            calYrMth = ConvertMonthsToCalendarYearMonth(totalMonths);
            return calYrMth;
        }

        #region Private functions

        private static int ConvertCalendarYearMonthToMonths(CalendarYearMonth calYrMth)
        {
            return (calYrMth.Year * 12) + calYrMth.Month;
        }

        private static CalendarYearMonth ConvertMonthsToCalendarYearMonth(int months)
        {
            CalendarYearMonth calYrMth = new CalendarYearMonth();
            int modMonth = months % 12;
            if (modMonth == 0)
            {
                calYrMth.Year = (months / 12) - 1;
                calYrMth.Month = 12;
            }
            else
            {
                int year = (int)Math.Truncate((decimal)(months / 12));
                calYrMth.Year = year;
                calYrMth.Month = modMonth;
            }
            return calYrMth;
        }

        #endregion
    }
}
