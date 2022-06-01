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

            GlobalContext.UserLoginEventHandler += UserLoggedEvent;

            //Initial calls
            LoadForm(new Login(GlobalContext));
        }

        private void UserLoggedEvent(object sender, User user)
        {
            LoadForm(new PieceScanForm());
            LblUser.Text = GlobalContext.CurrentUser.Name;
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
        }
    }
}
