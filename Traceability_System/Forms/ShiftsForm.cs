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
using Traceability_System.Helpers;

namespace Traceability_System.Forms
{
    public partial class ShiftsForm : UserControl
    {
        Shift UpdateShift;
        GlobalContextInfo ContextInfo;

        public ShiftsForm(GlobalContextInfo info)
        {
            InitializeComponent();

            ContextInfo = info;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ShiftsRepository repository = new ShiftsRepository();

            try
            {
                Shift shiftAdder = new Shift()
                {
                    Shift1 = TxtShiftName.Text,
                    HourStart = new TimeSpan(0,(int)TxtStartHour.Value, (int)TxtStartMinute.Value, 0),
                    HourEnd = new TimeSpan(0, (int)TxtEndHour.Value, (int)TxtEndMinute.Value, 0)
                };

                repository.AddNewShift(shiftAdder);
            }
            catch (Exception)
            {
                ChangeTextMainGuide("Ocurrio un error creando el turno", Color.Red);
                ClearTextBoxesForAdd();
                return;
            }

            ChangeTextMainGuide("Turno creado existosamente", Color.Green);
            ContextInfo.ShiftUpdateEvent(UpdateShift);
            ClearTextBoxesForAdd();
        }

        private void ClearTextBoxesForAdd()
        {
            TxtShiftName.Clear();
            TxtStartHour.Value = 0;
            TxtStartMinute.Value = 0;
            TxtEndHour.Value = 0;
            TxtEndMinute.Value = 0;
        }

        private void ClearTextBoxesForUpdate()
        {
            TxtModificationStartHour.Value = 0;
            TxtModificationStartMinute.Value = 0;
            TxtModificationEndHour.Value = 0;
            TxtModificationEndMinute.Value = 0;
            TxtShiftUpate.Clear();
        }

        private void SetUpdateShift()
        {
            TxtModificationStartHour.Value = UpdateShift.HourStart.Hours;
            TxtModificationStartMinute.Value = UpdateShift.HourStart.Minutes;
            TxtModificationEndHour.Value = UpdateShift.HourEnd.Hours;
            TxtModificationEndMinute.Value = UpdateShift.HourEnd.Minutes;
        }
        private void ChangeTextMainGuide(string text, Color color)
        {
            var t = new Timer();
            t.Interval = 2000;

            LblMainGuide.Text = text;
            LblMainGuide.ForeColor = color;

            t.Tick += (s, e) =>
            {
                LblMainGuide.Text = "";
                t.Stop();
            };
            t.Start();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ShiftsRepository repository = new ShiftsRepository();

            var result = repository.GetShiftByName(TxtShiftUpate.Text);

            if (result == null)
            {
                ChangeTextMainGuide("No se encontro ningun turno", Color.Red);
                return;
            }

            UpdateShift = result;
            ChangeTextMainGuide("Turno encontrado", Color.Green);
            SetUpdateShift();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateShift == null)
            {
                ChangeTextMainGuide("Porfavor busque un turno", Color.Red);
                TxtShiftUpate.Focus();
                return;
            }

            ShiftsRepository repository = new ShiftsRepository();

            UpdateShift.HourStart = new TimeSpan(0, (int)TxtModificationStartHour.Value, (int)TxtModificationStartMinute.Value, 0);
            UpdateShift.HourEnd = new TimeSpan(0, (int)TxtModificationEndHour.Value, (int)TxtModificationEndMinute.Value, 0);

            repository.UpdateShift(UpdateShift);
            ClearTextBoxesForUpdate();
            ChangeTextMainGuide("Turno modificado exitosamente", Color.Green);
            ContextInfo.ShiftUpdateEvent(UpdateShift);
            UpdateShift = null;
        }
    }
}
