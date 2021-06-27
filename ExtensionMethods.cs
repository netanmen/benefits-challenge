using System;
using System.Collections.Generic;
using System.Linq;

namespace benefits
{
    public static class ExtensionMethods
    {
        public static List<AppointmentsDateInfo> ConvertToAppointmentDateInfoList(this List<DateTime> dates, int selectedMonth, int selectedyear, int numberOfDaysInMonth)
        {
            var dict = new Dictionary<DateTime, int>();

            for (int i = 1; i <= numberOfDaysInMonth; i++)
            {
                DateTime date = new DateTime(selectedyear, selectedMonth, i);
                dict[date] = 0;
            }
            
            dates.ForEach(date =>
            {
                ++dict[date];
            });

            List<AppointmentsDateInfo> appointmentsDateInfoList = dict
            .Select(entry => new AppointmentsDateInfo()
                {
                    Date = entry.Key,
                    CountAppointments = entry.Value
                }
            )
            .ToList();

            return appointmentsDateInfoList;
        }
    }
}