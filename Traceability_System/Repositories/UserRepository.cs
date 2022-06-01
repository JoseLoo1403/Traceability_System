using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Repositories
{
    public class UserRepository
    {
        Traceability_System_DbContext context;
        
        public UserRepository()
        {
            context = new Traceability_System_DbContext();
        }
        public User GetUserByCode(string code)
        {
            return context.Users.FirstOrDefault(x => x.UserCode == code);
        }
    }
}
