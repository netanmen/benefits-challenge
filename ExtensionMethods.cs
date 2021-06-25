using System;
using System.Collections.Generic;
using System.Linq;

namespace benefits
{
    public static class ExtensionMethods
    {
        public static List<AppointmentsDateInfo> ConvertToAppointmentDateInfoList(this List<DateTime> dates)
        {
            var dict = new Dictionary<DateTime, int>();
            dates.ForEach(date =>
            {
                dict[date] = dict.ContainsKey(date) ? ++dict[date] : 1;
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