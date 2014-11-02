using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _01.ReturnDayOfTheWeekInBulgarian
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DayOfWeekService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DayOfWeekService.svc or DayOfWeekService.svc.cs at the Solution Explorer and start debugging.
    public class DayOfWeekService : IDayOfWeekService
    {
        public string GetDayOfWeekInBulgarian(DateTime dateTime)
        {
            var dateOfWeekInEnglish = dateTime.DayOfWeek;

            switch (dateOfWeekInEnglish)
            {
                case DayOfWeek.Friday:
                    return "Петък";
                    break;
                case DayOfWeek.Monday:
                    return "Понеделник";
                    break;
                case DayOfWeek.Saturday:
                    return "Събота";
                    break;
                case DayOfWeek.Sunday:
                    return "Неделя";
                    break;
                case DayOfWeek.Thursday:
                    return "Четвъртък";
                    break;
                case DayOfWeek.Tuesday:
                    return "Вторник";
                    break;
                case DayOfWeek.Wednesday:
                    return "Сряда";
                    break;
                default:
                    throw new ArgumentException("There is no such day of the week");
                    break;
            }
        }
    }
}
