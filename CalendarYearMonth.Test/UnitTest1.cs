using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalendarYearMonth.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddMonthTest1()
        {
            int year = 2016;
            int month = 12;
            int monthsToAdd = 3;

            CalendarYearMonth calYrMth = new CalendarYearMonth(year, month);
            CalendarYearMonth calYrMthResult = new CalendarYearMonth();
            calYrMthResult = calYrMth + monthsToAdd;

            Assert.AreEqual(3, calYrMthResult.Month);
            Assert.AreEqual(2017, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddMonthTest2()
        {
            int year = 2016;
            int month = 12;
            int monthsToAdd = 20;

            CalendarYearMonth calYrMth = new CalendarYearMonth(year, month);
            CalendarYearMonth calYrMthResult = new CalendarYearMonth();
            calYrMthResult = calYrMth + monthsToAdd;

            Assert.AreEqual(8, calYrMthResult.Month);
            Assert.AreEqual(2018, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddMonthTest3()
        {
            int year = 2016;
            int month = 7;
            int monthsToAdd = 4;

            CalendarYearMonth calYrMth = new CalendarYearMonth(year, month);
            CalendarYearMonth calYrMthResult = new CalendarYearMonth();
            calYrMthResult = calYrMth + monthsToAdd;

            Assert.AreEqual(11, calYrMthResult.Month);
            Assert.AreEqual(2016, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddMonthTest4()
        {
            int year = 2016;
            int month = 8;
            int monthsToAdd = 4;

            CalendarYearMonth calYrMth = new CalendarYearMonth(year, month);
            CalendarYearMonth calYrMthResult = new CalendarYearMonth();
            calYrMthResult = calYrMth + monthsToAdd;

            Assert.AreEqual(12, calYrMthResult.Month);
            Assert.AreEqual(2016, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddMonthTest5()
        {
            int year = 2016;
            int month = 8;
            int monthsToAdd = 16;

            CalendarYearMonth calYrMth = new CalendarYearMonth(year, month);
            CalendarYearMonth calYrMthResult = new CalendarYearMonth();
            calYrMthResult = calYrMth + monthsToAdd;

            Assert.AreEqual(12, calYrMthResult.Month);
            Assert.AreEqual(2017, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddCalendarYearMonthTest1()
        {
            int year1 = 2016; int month1 = 12;
            int year2 = 3; int month2 = 4;

            CalendarYearMonth calYrMth1 = new CalendarYearMonth(year1, month1);
            CalendarYearMonth calYrMth2 = new CalendarYearMonth(year2, month2);
            CalendarYearMonth calYrMthResult = calYrMth1 + calYrMth2;

            Assert.AreEqual(4, calYrMthResult.Month);
            Assert.AreEqual(2020, calYrMthResult.Year);
        }

        [TestMethod]
        public void AddCalendarYearMonthTest2()
        {
            int year1 = 2016; int month1 = 8;
            int year2 = 2; int month2 = 16;

            CalendarYearMonth calYrMth1 = new CalendarYearMonth(year1, month1);
            CalendarYearMonth calYrMth2 = new CalendarYearMonth(year2, month2);
            CalendarYearMonth calYrMthResult = calYrMth1 + calYrMth2;

            Assert.AreEqual(12, calYrMthResult.Month);
            Assert.AreEqual(2019, calYrMthResult.Year);
        }

    }

}
