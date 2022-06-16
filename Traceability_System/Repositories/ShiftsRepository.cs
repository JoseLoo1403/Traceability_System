using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class ShiftsRepository
    {
        Traceability_System_DbContext context;

        public ShiftsRepository()
        {
            context = new Traceability_System_DbContext();
        }

        public List<Shift> GetAllShifts()
        {
            return context.Shifts.ToList();
        }

        public Shift GetCurrentShift()
        {
            return context.Shifts.FirstOrDefault(x => x.HourStart < DateTime.Now.TimeOfDay && x.HourEnd > DateTime.Now.TimeOfDay);
        }
    }
}
