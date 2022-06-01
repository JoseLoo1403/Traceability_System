
namespace Traceability_System.Forms
{
    partial class UsersControlForm
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUserCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.BtnViewUserTable = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSaveGuide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(110, 191);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(232, 31);
            this.TxtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(110, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSurname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSurname.Location = new System.Drawing.Point(110, 295);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(232, 31);
            this.TxtSurname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo de usuario";
            // 
            // TxtUserCode
            // 
            this.TxtUserCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUserCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUserCode.Location = new System.Drawing.Point(110, 404);
            this.TxtUserCode.Name = "TxtUserCode";
            this.TxtUserCode.Size = new System.Drawing.Size(232, 31);
            this.TxtUserCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo";
            // 
            // TxtPosition
            // 
            this.TxtPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPosition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPosition.Location = new System.Drawing.Point(110, 505);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(232, 31);
            this.TxtPosition.TabIndex = 6;
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveUser.Location = new System.Drawing.Point(491, 219);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(230, 63);
            this.BtnSaveUser.TabIndex = 8;
            this.BtnSaveUser.Text = "Guardar";
            this.BtnSaveUser.UseVisualStyleBackColor = false;
            this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // BtnViewUserTable
            // 
            this.BtnViewUserTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnViewUserTable.BackColor = System.Drawing.Color.Transparent;
            this.BtnViewUserTable.Location = new System.Drawing.Point(491, 370);
            this.BtnViewUserTable.Name = "BtnViewUserTable";
            this.BtnViewUserTable.Size = new System.Drawing.Size(230, 65);
            this.BtnViewUserTable.TabIndex = 9;
            this.BtnViewUserTable.Text = "Ver Tabla";
            this.BtnViewUserTable.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(85, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingreso de Usuario ( Operadores )";
            // 
            // LblSaveGuide
            // 
            this.LblSaveGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSaveGuide.AutoSize = true;
            this.LblSaveGuide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSaveGuide.Location = new System.Drawing.Point(491, 285);
            this.LblSaveGuide.Name = "LblSaveGuide";
            this.LblSaveGuide.Size = new System.Drawing.Size(0, 25);
            this.LblSaveGuide.TabIndex = 11;
            // 
            // UsersControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LblSaveGuide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnViewUserTable);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUserCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "UsersControlForm";
            this.Size = new System.Drawing.Size(865, 752);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUserCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.Button BtnSaveUser;
        private System.Windows.Forms.Button BtnViewUserTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSaveGuide;
    }
}
