﻿using System;
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
        public User GetUserByCode(int code)
        {
            return Context.Users.FirstOrDefault(x => x.UserCode == code);
        }

        public List<User> GetAllUsers()
        {
            return Context.Users.ToList();
        }

        public void RegisterUserLog(int userCode, DateTime lastLog)
        {
            var LoggedUser = Context.Users.FirstOrDefault(x => x.UserCode == userCode);

            //Cleaning miliseconds
            DateTime LastLog = DateTime.Now;
            LoggedUser.LastLogin = LastLog;
            Context.SaveChanges();
        }

        public void AddNewUser(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }

        public void UserActiveChange(bool state, int userCode)
        {
            var CurrentUser = Context.Users.FirstOrDefault(x => x.UserCode == userCode);
            CurrentUser.Active = state;
            Context.SaveChanges();
        }
    }
}
