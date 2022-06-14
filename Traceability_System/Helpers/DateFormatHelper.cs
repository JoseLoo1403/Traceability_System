using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traceability_System.Helpers
{
    public static class DateFormatHelper
    {
        public static DateTime GetCurrentDate()
        {
            DateTime date = DateTime.Now;
            date = new DateTime(date.Ticks - (date.Ticks % TimeSpan.TicksPerSecond), date.Kind);

            return date;
        }
    }
}
