using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Helpers;
using Traceability_System.Models;
using Traceability_System.Forms;
using Traceability_System.Repositories;

namespace Traceability_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        GlobalContextInfo GlobalContext;
        private void Main_Load(object sender, EventArgs e)
        {
            GlobalContext = new GlobalContextInfo();

            //Events
            GlobalContext.UserLoginEventHandler += UserLoggedEvent;
            GlobalContext.OpenNewFormEventHandler += OpenTabEvent;

            //Initial calls
            LoadForm(new Login(GlobalContext));
            ButtonsRestrictions();
        }

        private void ButtonsRestrictions()
        {
            if (GlobalContext.CurrentUser == null)
            {
                BtnConfiguration.Enabled = false;
                BtnScanPiece.Enabled = false;
                BtnLogRecords.Enabled = false;
                BtnUsers.Enabled = false;
                BtnLogout.Enabled = false;
                BtnClose.Enabled = false;
                return;
            }

            BtnLogout.Enabled = true;
            BtnClose.Enabled = true;

            if (GlobalContext.CurrentUser.Position == "admin")
            {
                BtnConfiguration.Enabled = true;
                BtnScanPiece.Enabled = true;
                BtnLogRecords.Enabled = true;
                BtnUsers.Enabled = true;
            }
        }

        private void OpenTabEvent(object sender, UserControl e)
        {
            LoadForm(e);
        }

        private void UserLoggedEvent(object sender, User user)
        {
            LoadForm(new PieceScanForm());
            LblUser.Text = GlobalContext.CurrentUser.Name;
            ButtonsRestrictions();
        }

        private void LoadForm(object form)
        {
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.RemoveAt(0);
            UserControl f = form as UserControl;
            f.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(f);
            MainPanel.Tag = f;
        }
        private void BtnScanPiece_Click(object sender, EventArgs e)
        {
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new UsersControlForm(GlobalContext));
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (GlobalContext.CurrentUser.Position == "admin")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Este usuario no esta autorizado para cerrar el sistema");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            GlobalContext.CurrentUser = null;
            LoadForm(new Login(GlobalContext));
            LblUser.Text = "";
            ButtonsRestrictions();
        }
    }
}
