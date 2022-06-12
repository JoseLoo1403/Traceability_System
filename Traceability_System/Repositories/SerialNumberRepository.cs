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
    }
}
