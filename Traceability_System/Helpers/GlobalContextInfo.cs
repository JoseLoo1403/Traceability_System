using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Models;

namespace Traceability_System.Helpers
{
    public class GlobalContextInfo
    {
        public event EventHandler<User> UserLoginEventHandler;
        public event EventHandler<UserControl> OpenNewFormEventHandler;

        public User CurrentUser { get; set; }

        public void UserLoginEvent(User user)
        {
            CurrentUser = user;
            UserLoginEventHandler?.Invoke(this,user);
        }

        public void OpenNewFormEvent(UserControl form)
        {
            OpenNewFormEventHandler?.Invoke(this, form);
        }
    }
}
