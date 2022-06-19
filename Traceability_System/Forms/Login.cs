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
using Traceability_System.Repositories;

namespace Traceability_System.Forms
{
    public partial class Login : UserControl
    {
        GlobalContextInfo contextInfo { get; set; }
        UserRepository userRepository { get; set; }
        string Mode { get; set; }
        public Login(GlobalContextInfo info, string mode)
        {
            InitializeComponent();
            contextInfo = info;
            userRepository = new UserRepository();
            Mode = mode;

            InitialMessage();
        }

        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void ValidateInfo(string text = null)
        {

            if (text == null || text.Count() < 1)
            {
                return;
            }

            var UserRespond = userRepository.GetUserByCode(Convert.ToInt32(text));

            if (UserRespond == null)
            {
                ChangeTextMainGuide($"El usuario con codigo [ {text} ] no existe", Color.Red);
                return;
            }

            if (!UserRespond.Active)
            {
                ChangeTextMainGuide("El usuario no esta habilitado", Color.Red);
                return;
            }
            LogWithSelectedMode(UserRespond);
        }

        private void LogWithSelectedMode(User user)
        {
            switch (Mode)
            {
                case "login":
                    contextInfo.UserLoginEvent(user); //User succesfully logged
                    userRepository.RegisterUserLog(user.UserCode, DateFormatHelper.GetCurrentDate()); //Registering last login
                    break;

                case "authorization":
                    if (user.Position == "admin")
                    {
                        contextInfo.AuthorizationRequiredEvent("active");
                    }
                    else
                    {
                        ChangeTextMainGuide($"El usuario [ {user.Name} ] no esta autorizado para realizar esta accion", Color.Red);
                        return;
                    }
                    break;

                case "ShiftChange":
                    contextInfo.UserLoginEvent(user); //User succesfully logged
                    userRepository.RegisterUserLog(user.UserCode, DateFormatHelper.GetCurrentDate()); //Registering last login
                    break;
            }

            ValidatorTm.Enabled = false;
        }

        private void InitialMessage()
        {
            switch (Mode)
            {
                case "authorization":
                    LblAuthorizationTitle.Text = "La pieza que escaneo no pertenece a la generacion seleccionada, porfavor contacte un supervisor";
                    LblAuthorizationTitle.ForeColor = Color.Red;
                    break;
                case "ShiftChange":
                    LblAuthorizationTitle.Text = "Cambio de turno";
                    LblAuthorizationTitle.ForeColor = Color.Green;
                    break;
            }
        }

        private void ChangeTextMainGuide(string text, Color color)
        {
            var t = new Timer();
            t.Interval = 4000;

            LblInstrucctions.Text = text;
            LblInstrucctions.ForeColor = color;

            t.Tick += (s, e) =>
            {
                LblInstrucctions.Text = "";
                t.Stop();
            };
            t.Start();
        }

        private void ValidatorTm_Tick(object sender, EventArgs e)
        {
            ValidateInfo(TxtCode.Text);
            TxtCode.Clear();
            TxtCode.Focus();
        }
    }
}
