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
using Traceability_System.Forms.PieceScanSelectionViews;
using Traceability_System.Forms.EntitiesViews;
using Traceability_System.Repositories;
using Traceability_System.Modbus;

namespace Traceability_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        GlobalContextInfo GlobalContext;
        Shift CurrentShift;

        private void Main_Load(object sender, EventArgs e)
        {
            GlobalContext = new GlobalContextInfo();

            //Events
            GlobalContext.UserLoginEventHandler += UserLoggedEvent;
            GlobalContext.OpenNewFormEventHandler += OpenTabEvent;
            GlobalContext.UserLogoutEventHandler += UserLogoutEvent;
            GlobalContext.AuthorizationRequiredEventHandler += AuthorizationLogin;
            GlobalContext.ShiftUpdateEventHandler += ShiftUpdatedEvent;

            //Initial calls
            LoadForm(new Login(GlobalContext,"login"));
            ButtonsRestrictions();
            StartShiftValidation();
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
                BtnPieces.Enabled = false;
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
                BtnPieces.Enabled = true;
            }
        }

        private void OpenTabEvent(object sender, UserControl e)
        {
            LoadForm(e);
        }
        private void UserLogoutEvent(object sender, EventArgs e)
        {
            Logout();
        }

        private void UserLoggedEvent(object sender, User user)
        {
            LoadForm(new SelectGenerationForm(GlobalContext));
            LblUser.Text = GlobalContext.CurrentUser.Name;
            ButtonsRestrictions();
        }
        
        private void AuthorizationLogin(object sender, string e)
        {
            if (e == "authorization")
            {
                Login f = new Login(GlobalContext, e);
                f.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(f);
                MainPanel.Tag = f;
                MainPanel.Controls[0].Visible = false;
                MainPanel.Refresh();
            }
            else if(e == "active")
            {
                MainPanel.Controls.RemoveAt(1);
                MainPanel.Controls[0].Visible = true;
            }
        }

        private void ShiftUpdatedEvent(object sender, Shift e)
        {
            GetCurrentShift();
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

        private void StartShiftValidation()
        {
            GetCurrentShift();

            Timer timer = new Timer();
            timer.Interval = 1000;

            timer.Tick += (s, e) =>
            {
                if (CurrentShift.HourEnd < DateTime.Now.TimeOfDay)
                {
                    //Shift change
                    ResetSystem();
                }
            };
            timer.Start();
        }

        private void GetCurrentShift()
        {
            ShiftsRepository repository = new ShiftsRepository();
            CurrentShift = repository.GetCurrentShift();

            if (CurrentShift == null)
            {
                CurrentShift = new Shift()
                {
                    Shift1 = "Default",
                    HourStart = new TimeSpan(0, 1, 0, 0),
                    HourEnd = new TimeSpan(0, 23, 59, 0)
                };
            }

            LblShift.Text = $"Turno actual: {CurrentShift.Shift1}";
        }

        private void ResetSystem()
        {
            GlobalContext.CurrentUser = null;
            GetCurrentShift();
            LoadForm(new Login(GlobalContext, "ShiftChange"));
            ButtonsRestrictions();
        }

        private void Logout()
        {
            GlobalContext.CurrentUser = null;
            LoadForm(new Login(GlobalContext,"login"));
            LblUser.Text = "";
            ButtonsRestrictions();
        }
        private void BtnScanPiece_Click(object sender, EventArgs e)
        {
            LoadForm(new SelectGenerationForm(GlobalContext));
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
            Logout();
        }

        private void BtnLogRecords_Click(object sender, EventArgs e)
        {
            LoadForm(new LogRecordView());
        }

        private void BtnPieces_Click(object sender, EventArgs e)
        {
            LoadForm(new AddPiecesForm(GlobalContext));
        }

        private void BtnConfiguration_Click(object sender, EventArgs e)
        {
            LoadForm(new ConfigurationsForm(GlobalContext));
        }
    }
}
