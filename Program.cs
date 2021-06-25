using System;
using System.Collections.Generic;

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
            Console.WriteLine($"selectedMonth={selectedMonth};selectedyear={selectedyear};numberOfDaysInMonth={numberOfDaysInMonth};");
            //returns all the dates of the appointment from the given month
            List<DateTime> dates = new List<DateTime>() {
                new DateTime()
            };
            // //for example for the above data would return sorted list such as – '1/2/2001', '1/2/2001', '1/2/2001', '1/2/2001', '3/2/2001', '4/2/2001', '4/2/2001', '4/2/2001' … and so on

            List<AppointmentsDateInfo> listToPopulate = new List<AppointmentsDateInfo>();

            // //we want the code that adapts\converts from dates to listToPopulate
            // //------------ complete the code that should be written here...

            // //-------------------------
            var ctlAppointmentsDate = new AppointmentsDateControl();
            ctlAppointmentsDate.Populate(listToPopulate);
        }
    }
}


