using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Models;
using Traceability_System.Repositories;

namespace Traceability_System.Forms.EntitiesViews
{
    public partial class UsersTableView : UserControl
    {
        public UsersTableView()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            UserRepository repository = new UserRepository();
            UsersGv.DataSource = null;
            UsersGv.DataSource = repository.GetAllUsers();
            UsersGv.Columns["LogRecords"].Visible = false;
            UsersGv.Columns["ShiftNavigation"].Visible = false;
            UsersGv.Columns["SerialNumbers"].Visible = false;
        }
        private void UsersTableView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
