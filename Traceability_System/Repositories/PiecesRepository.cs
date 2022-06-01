using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class PiecesRepository
    {
        private Traceability_System_DbContext context;

        public PiecesRepository()
        {

            context = new Traceability_System_DbContext();
        }
    }
}
