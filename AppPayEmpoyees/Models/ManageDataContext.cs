using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPayEmpoyees.Models
{
    class ManageDataContext
    {
        //DAYS WEEK
        public List<DaysWeek> GetDaysWeeks()
        {
            return new List<DaysWeek>
            {
                new DaysWeek
                {
                    acronymDay = "MO",
                    nameDay = "Monday"
                },
                new DaysWeek
                {
                    acronymDay = "TU",
                    nameDay = "Tuesday"
                },
                new DaysWeek
                {
                    acronymDay = "WE",
                    nameDay = "Wednesday"
                },
                new DaysWeek
                {
                    acronymDay = "TH",
                    nameDay = "Thursday"
                },
                new DaysWeek
                {
                    acronymDay = "FR",
                    nameDay = "Friday"
                },
                new DaysWeek
                {
                    acronymDay = "SA",
                    nameDay = "Saturday"
                },
                new DaysWeek
                {
                    acronymDay = "SU",
                    nameDay = "Sunday"
                }
            };
        }


        //MANAGE LIST TO HOURS PAY DAYS WEEKS
        public List<HoursPay> GetHoursPayDayWeek()
        {
            return new List<HoursPay>
            {
                new HoursPay
                {
                   startTime = "00:01",
                   endTime = "09:00",
                   payValue = 25
                },
                new HoursPay
                {
                   startTime = "09:01",
                   endTime = "18:00",
                   payValue = 15
                },
                new HoursPay
                {
                   startTime = "18:01",
                   endTime = "00:00",
                   payValue = 20
                }

            };
        }

        //MANAGE LIST TO HOURS PAY DAYS END WEEKS
        public List<HoursPay> GetHoursPayDaysEndWeek()
        {
            return new List<HoursPay>
            {
                new HoursPay
                {
                   startTime = "00:01",
                   endTime = "09:00",
                   payValue = 30
                },
                new HoursPay
                {
                   startTime = "09:01",
                   endTime = "18:00",
                   payValue = 20
                },
                new HoursPay
                {
                   startTime = "18:01",
                   endTime = "00:00",
                   payValue = 25
                }

            };
        }

    }
}
