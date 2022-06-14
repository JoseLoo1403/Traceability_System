
namespace Traceability_System.Forms
{
    partial class AddSerialNumberForm
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
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDeactivateSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDeactivate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPiecePartNumber = new System.Windows.Forms.TextBox();
            this.LblGuide = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFinishedGood = new System.Windows.Forms.TextBox();
            this.ChkSecondGen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDays)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSerialNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSerialNumber.Location = new System.Drawing.Point(394, 173);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.Size = new System.Drawing.Size(200, 31);
            this.TxtSerialNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero serial:";
            // 
            // TxtDays
            // 
            this.TxtDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDays.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDays.Location = new System.Drawing.Point(394, 425);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(84, 31);
            this.TxtDays.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dias habiles:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(251, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero serial:";
            // 
            // TxtDeactivateSerial
            // 
            this.TxtDeactivateSerial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDeactivateSerial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDeactivateSerial.Location = new System.Drawing.Point(383, 501);
            this.TxtDeactivateSerial.Name = "TxtDeactivateSerial";
            this.TxtDeactivateSerial.Size = new System.Drawing.Size(200, 31);
            this.TxtDeactivateSerial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(359, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Agregar Numero Serial";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(693, 176);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(149, 73);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "Agregar";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(589, 501);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(31, 31);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "B";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDeactivate
            // 
            this.BtnDeactivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeactivate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDeactivate.Location = new System.Drawing.Point(693, 480);
            this.BtnDeactivate.Name = "BtnDeactivate";
            this.BtnDeactivate.Size = new System.Drawing.Size(149, 73);
            this.BtnDeactivate.TabIndex = 9;
            this.BtnDeactivate.Text = "Deshabilitar";
            this.BtnDeactivate.UseVisualStyleBackColor = true;
            this.BtnDeactivate.Click += new System.EventHandler(this.BtnDeactivate_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(100, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero de componente asociado:";
            // 
            // TxtPiecePartNumber
            // 
            this.TxtPiecePartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPiecePartNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPiecePartNumber.Location = new System.Drawing.Point(394, 252);
            this.TxtPiecePartNumber.Name = "TxtPiecePartNumber";
            this.TxtPiecePartNumber.Size = new System.Drawing.Size(200, 31);
            this.TxtPiecePartNumber.TabIndex = 10;
            // 
            // LblGuide
            // 
            this.LblGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGuide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGuide.Location = new System.Drawing.Point(145, 556);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(725, 84);
            this.LblGuide.TabIndex = 12;
            this.LblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(246, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Finished Good:";
            // 
            // TxtFinishedGood
            // 
            this.TxtFinishedGood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFinishedGood.Enabled = false;
            this.TxtFinishedGood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFinishedGood.Location = new System.Drawing.Point(394, 351);
            this.TxtFinishedGood.Name = "TxtFinishedGood";
            this.TxtFinishedGood.Size = new System.Drawing.Size(200, 31);
            this.TxtFinishedGood.TabIndex = 13;
            // 
            // ChkSecondGen
            // 
            this.ChkSecondGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChkSecondGen.AutoSize = true;
            this.ChkSecondGen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkSecondGen.Location = new System.Drawing.Point(394, 316);
            this.ChkSecondGen.Name = "ChkSecondGen";
            this.ChkSecondGen.Size = new System.Drawing.Size(232, 29);
            this.ChkSecondGen.TabIndex = 15;
            this.ChkSecondGen.Text = "¿Es segunda generacion?";
            this.ChkSecondGen.UseVisualStyleBackColor = true;
            this.ChkSecondGen.CheckedChanged += new System.EventHandler(this.ChkSecondGen_CheckedChanged);
            // 
            // AddSerialNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChkSecondGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFinishedGood);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPiecePartNumber);
            this.Controls.Add(this.BtnDeactivate);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDeactivateSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSerialNumber);
            this.Name = "AddSerialNumberForm";
            this.Size = new System.Drawing.Size(1017, 709);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDeactivateSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDeactivate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPiecePartNumber;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFinishedGood;
        private System.Windows.Forms.CheckBox ChkSecondGen;
    }
}
