using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;

namespace Traceability_System.Helpers
{
    public class GlobalContextInfo
    {
        public event EventHandler<User> UserLoginEventHandler;

        public User CurrentUser { get; set; }

        public void UserLoginEvent(User user)
        {
            CurrentUser = user;
            UserLoginEventHandler?.Invoke(this,user);
        }
    }
}
