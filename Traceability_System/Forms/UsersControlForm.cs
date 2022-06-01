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

namespace Traceability_System.Forms
{
    public partial class UsersControlForm : UserControl
    {
        public UsersControlForm()
        {
            InitializeComponent();
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();

            if (!SecureInfoIfNull()) return;

            User NewUser = new User() {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                UserCode = TxtUserCode.Text,
                Position = TxtPosition.Text,
                Active = false,
                LastLogin = null
            };

            repo.AddNewUser(NewUser);
            ClearTextBoxes();

            LblSaveGuide.Text = "Usuario agregado exitosamente!";
            LblSaveGuide.ForeColor = Color.Green;
        }

        private bool SecureInfoIfNull()
        {
            if (string.IsNullOrEmpty(TxtName.Text) || 
                string.IsNullOrEmpty(TxtSurname.Text) ||
                string.IsNullOrEmpty(TxtUserCode.Text) ||
                string.IsNullOrEmpty(TxtPosition.Text))
            {
                LblSaveGuide.Text = "El usuario no puede ser agregado, uno de los campos esta vacio";
                LblSaveGuide.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        private void ClearTextBoxes()
        {
            TxtName.Clear();
            TxtSurname.Clear();
            TxtUserCode.Clear();
            TxtPosition.Clear();
        }
    }
}
