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
using Traceability_System.Forms.EntitiesViews;

namespace Traceability_System.Forms
{
    public partial class UsersControlForm : UserControl
    {
        //Global variables
        User CurrentUserActivation;
        GlobalContextInfo ContextInfo {get; set;}
        public UsersControlForm(GlobalContextInfo info)
        {
            InitializeComponent();
            ContextInfo = info;
        }

        private void BtnSaveUser_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();

            if (!SecureInfoIfNull()) return;

            User NewUser = new User() {
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                UserCode = Convert.ToInt32(TxtUserCode.Text),
                Position = TxtPosition.Text,
                Shift = TxtShift.Text,
                Active = true,
                LastLogin = null
            };

            ClearTextBoxes();

            try
            {
                repo.AddNewUser(NewUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                return;
            }

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
            TxtShift.Clear();
        }

        private void BtnSearchActiveUser_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository();

            CurrentUserActivation = repository.GetUserByCode(Convert.ToInt32(TxtActiveUserCode.Text));

            if (CurrentUserActivation == null) 
            {
                LblActivationGuide.Text = "Usuario no encontrado";
            }

            if (CurrentUserActivation.Active == false)
            {
                LblActivationGuide.Text = $"El usuario [{CurrentUserActivation.Name}] esta inactivo";
                BtnChangeActive.Text = "Activar Usuario";
            }
            else
            {
                LblActivationGuide.Text = $"El usuario [{CurrentUserActivation.Name}] esta activo";
                BtnChangeActive.Text = "Desactivar Usuario";
            }
        }

        private void BtnChangeActive_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository();

            if (CurrentUserActivation == null)
            {
                return;
            }

            if (CurrentUserActivation.Active == false)
            {
                repository.UserActiveChange(true, CurrentUserActivation.UserCode);
                LblActivationGuide.Text = $"Usuario [{CurrentUserActivation.Name}] ha sido activado";
            }
            else
            {
                repository.UserActiveChange(false, CurrentUserActivation.UserCode);
                LblActivationGuide.Text = $"Usuario [{CurrentUserActivation.Name}] ha sido desactivado";
            }

            TxtActiveUserCode.Clear();
            CurrentUserActivation = null;
        }

        private void BtnViewUserTable_Click(object sender, EventArgs e)
        {
            ContextInfo.OpenNewFormEvent(new UsersTableView());
        }
    }
}
