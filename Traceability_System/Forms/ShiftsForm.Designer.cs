
namespace Traceability_System.Forms
{
    partial class ShiftsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.TxtShiftName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtStartHour = new System.Windows.Forms.NumericUpDown();
            this.TxtStartMinute = new System.Windows.Forms.NumericUpDown();
            this.LblMainGuide = new System.Windows.Forms.Label();
            this.TxtEndMinute = new System.Windows.Forms.NumericUpDown();
            this.TxtEndHour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtShiftUpate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtModificationEndMinute = new System.Windows.Forms.NumericUpDown();
            this.TxtModificationEndHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtModificationStartMinute = new System.Windows.Forms.NumericUpDown();
            this.TxtModificationStartHour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationStartHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(184, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Turno:";
            // 
            // TxtShiftName
            // 
            this.TxtShiftName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtShiftName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtShiftName.Location = new System.Drawing.Point(349, 176);
            this.TxtShiftName.Name = "TxtShiftName";
            this.TxtShiftName.Size = new System.Drawing.Size(197, 31);
            this.TxtShiftName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(184, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora de inicio:";
            // 
            // TxtStartHour
            // 
            this.TxtStartHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtStartHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStartHour.Location = new System.Drawing.Point(401, 255);
            this.TxtStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TxtStartHour.Name = "TxtStartHour";
            this.TxtStartHour.Size = new System.Drawing.Size(70, 31);
            this.TxtStartHour.TabIndex = 23;
            // 
            // TxtStartMinute
            // 
            this.TxtStartMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtStartMinute.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStartMinute.Location = new System.Drawing.Point(563, 255);
            this.TxtStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TxtStartMinute.Name = "TxtStartMinute";
            this.TxtStartMinute.Size = new System.Drawing.Size(70, 31);
            this.TxtStartMinute.TabIndex = 24;
            // 
            // LblMainGuide
            // 
            this.LblMainGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMainGuide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMainGuide.Location = new System.Drawing.Point(189, 753);
            this.LblMainGuide.Name = "LblMainGuide";
            this.LblMainGuide.Size = new System.Drawing.Size(736, 25);
            this.LblMainGuide.TabIndex = 26;
            this.LblMainGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtEndMinute
            // 
            this.TxtEndMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEndMinute.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEndMinute.Location = new System.Drawing.Point(563, 324);
            this.TxtEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TxtEndMinute.Name = "TxtEndMinute";
            this.TxtEndMinute.Size = new System.Drawing.Size(70, 31);
            this.TxtEndMinute.TabIndex = 29;
            // 
            // TxtEndHour
            // 
            this.TxtEndHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEndHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEndHour.Location = new System.Drawing.Point(401, 324);
            this.TxtEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TxtEndHour.Name = "TxtEndHour";
            this.TxtEndHour.Size = new System.Drawing.Size(70, 31);
            this.TxtEndHour.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hora de final:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(724, 163);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(250, 85);
            this.BtnAdd.TabIndex = 31;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearch.Location = new System.Drawing.Point(446, 506);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(33, 29);
            this.BtnSearch.TabIndex = 34;
            this.BtnSearch.Text = "B";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(189, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Turno a modificar:";
            // 
            // TxtShiftUpate
            // 
            this.TxtShiftUpate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtShiftUpate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtShiftUpate.Location = new System.Drawing.Point(192, 504);
            this.TxtShiftUpate.Name = "TxtShiftUpate";
            this.TxtShiftUpate.Size = new System.Drawing.Size(248, 31);
            this.TxtShiftUpate.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(192, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 31);
            this.label5.TabIndex = 36;
            this.label5.Text = "Agregar Turno";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.Location = new System.Drawing.Point(724, 565);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(250, 89);
            this.BtnUpdate.TabIndex = 37;
            this.BtnUpdate.Text = "Modificar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtModificationEndMinute
            // 
            this.TxtModificationEndMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtModificationEndMinute.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModificationEndMinute.Location = new System.Drawing.Point(563, 658);
            this.TxtModificationEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TxtModificationEndMinute.Name = "TxtModificationEndMinute";
            this.TxtModificationEndMinute.Size = new System.Drawing.Size(70, 31);
            this.TxtModificationEndMinute.TabIndex = 44;
            // 
            // TxtModificationEndHour
            // 
            this.TxtModificationEndHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtModificationEndHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModificationEndHour.Location = new System.Drawing.Point(401, 656);
            this.TxtModificationEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TxtModificationEndHour.Name = "TxtModificationEndHour";
            this.TxtModificationEndHour.Size = new System.Drawing.Size(70, 31);
            this.TxtModificationEndHour.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Hora de final:";
            // 
            // TxtModificationStartMinute
            // 
            this.TxtModificationStartMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtModificationStartMinute.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModificationStartMinute.Location = new System.Drawing.Point(563, 589);
            this.TxtModificationStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TxtModificationStartMinute.Name = "TxtModificationStartMinute";
            this.TxtModificationStartMinute.Size = new System.Drawing.Size(70, 31);
            this.TxtModificationStartMinute.TabIndex = 40;
            // 
            // TxtModificationStartHour
            // 
            this.TxtModificationStartHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtModificationStartHour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtModificationStartHour.Location = new System.Drawing.Point(400, 587);
            this.TxtModificationStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TxtModificationStartHour.Name = "TxtModificationStartHour";
            this.TxtModificationStartHour.Size = new System.Drawing.Size(70, 31);
            this.TxtModificationStartHour.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(184, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Hora de inicio:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(184, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 31);
            this.label8.TabIndex = 46;
            this.label8.Text = "Moficiar turno";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(344, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hora:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(488, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Minuto:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(484, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Minuto:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(340, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Hora:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(488, 662);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 25);
            this.label13.TabIndex = 54;
            this.label13.Text = "Minuto:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(340, 658);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 25);
            this.label14.TabIndex = 53;
            this.label14.Text = "Hora:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(488, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 52;
            this.label15.Text = "Minuto:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(340, 591);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 51;
            this.label16.Text = "Hora:";
            // 
            // ShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtModificationEndMinute);
            this.Controls.Add(this.TxtModificationEndHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtModificationStartMinute);
            this.Controls.Add(this.TxtModificationStartHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtShiftUpate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtEndMinute);
            this.Controls.Add(this.TxtEndHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMainGuide);
            this.Controls.Add(this.TxtStartMinute);
            this.Controls.Add(this.TxtStartHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtShiftName);
            this.Name = "ShiftsForm";
            this.Size = new System.Drawing.Size(1129, 799);
            ((System.ComponentModel.ISupportInitialize)(this.TxtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModificationStartHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtShiftName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtStartHour;
        private System.Windows.Forms.NumericUpDown TxtStartMinute;
        private System.Windows.Forms.Label LblMainGuide;
        private System.Windows.Forms.NumericUpDown TxtEndMinute;
        private System.Windows.Forms.NumericUpDown TxtEndHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtShiftUpate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.NumericUpDown TxtModificationEndMinute;
        private System.Windows.Forms.NumericUpDown TxtModificationEndHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TxtModificationStartMinute;
        private System.Windows.Forms.NumericUpDown TxtModificationStartHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
