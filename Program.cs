using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace benefits
{
    class Program
    {
        static void Main(string[] args)
        {
            FillControl(2, 2001, 28);
        }

        private static void FillControl(int selectedMonth = 2, int selectedyear = 2001, int numberOfDaysInMonth = 28)
        {
            List<DateTime> dates = GetDummyData();

            List<AppointmentsDateInfo> listToPopulate = dates.ConvertToAppointmentDateInfoList(2, 2001, 28);

            var ctlAppointmentsDate = new AppointmentsDateControl();
            ctlAppointmentsDate.Populate(listToPopulate);
        }

        private static List<DateTime> GetDummyData()
        {
            string[] dateStrings = { "1/2/2001", "1/2/2001", "1/2/2001", "1/2/2001", "3/2/2001", "4/2/2001", "4/2/2001", "4/2/2001" };
            List<DateTime> datesList = dateStrings.Select(dateString => DateTime.ParseExact(dateString, "d/M/yyyy", CultureInfo.CurrentCulture)).ToList();

            return datesList;
        }
    }
}


