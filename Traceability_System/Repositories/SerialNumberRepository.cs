using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class SerialNumberRepository
    {
        Traceability_System_DbContext Context;

        public SerialNumberRepository()
        {
            Context = new Traceability_System_DbContext();
        }

        public SerialNumber GetSerialNumberByNumber(int serialNumber)
        {
            return Context.SerialNumbers.FirstOrDefault(x => x.SerialNumber1 == serialNumber);
        }

        public void AddSerialNumber(SerialNumber serialNumber)
        {
            Context.SerialNumbers.Add(serialNumber);
            Context.SaveChanges();
        }

        public void ChangeStateBySerialNumber(int serialNumber, bool state)
        {
            var result = Context.SerialNumbers.FirstOrDefault(x => x.SerialNumber1 == serialNumber);
            result.Active = state;
            Context.SaveChanges();
        }
    }
}
