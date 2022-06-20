using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traceability_System.Models;
using Traceability_System.Helpers;

namespace Traceability_System.Repositories
{
    public class ConfigurationRepository
    {
        Traceability_System_DbContext Context;

        public ConfigurationRepository()
        {
            Context = new Traceability_System_DbContext();
        }

        public Configuration[] GetTcpConfiguration()
        {
            return Context.Configurations.Where(x => x.Name == "Ip" || x.Name == "Port").ToArray();
        }

        public void UpdateConfiguration(string name, string value)
        {
            var update = Context.Configurations.FirstOrDefault(x => x.Name == name);

            update.Value = value;
            update.UpdatedDate = DateFormatHelper.GetCurrentDate();

            Context.SaveChanges();
        }
    }
}
