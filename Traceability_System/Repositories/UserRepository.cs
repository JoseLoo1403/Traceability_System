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
        Traceability_System_DbContext Context;
        
        public UserRepository()
        {
            Context = new Traceability_System_DbContext();
        }
        public User GetUserByCode(string code)
        {
            return Context.Users.FirstOrDefault(x => x.UserCode == code);
        }

        public void RegisterUserLog(int id)
        {
            var LoggedUser = Context.Users.FirstOrDefault(x => x.Id == id);

            //Cleaning miliseconds
            DateTime LastLog = DateTime.Now;
            LastLog = new DateTime(LastLog.Ticks - (LastLog.Ticks % TimeSpan.TicksPerSecond), LastLog.Kind);

            LoggedUser.LastLogin = LastLog;
            LoggedUser.Active = true;
            Context.SaveChanges();
        }

        public void UserActiveChange(bool state, int id)
        {
            var CurrentUser = Context.Users.FirstOrDefault(x => x.Id == id);
            CurrentUser.Active = state;
            Context.SaveChanges();
        }

        public void AddNewUser(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }
    }
}
