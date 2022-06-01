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
        public Login(GlobalContextInfo info)
        {
            InitializeComponent();
            contextInfo = info;
            userRepository = new UserRepository();
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

            var UserRespond = userRepository.GetUserByCode(text);

            if (UserRespond == null)
            {
                LblInstrucctions.Text = $"Este usuario con codigo {text} no existe";
                LblInstrucctions.ForeColor = Color.Red; 
                return;
            }

            ValidatorTm.Enabled = false;
            contextInfo.UserLoginEvent(UserRespond); //User succesfully logged
            userRepository.RegisterUserLog(UserRespond.Id); //Registering last login
        }

        private void ValidatorTm_Tick(object sender, EventArgs e)
        {
            ValidateInfo(TxtCode.Text);
            TxtCode.Clear();
            TxtCode.Focus();
        }
    }
}
