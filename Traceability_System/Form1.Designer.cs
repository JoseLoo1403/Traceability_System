
namespace Traceability_System
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnConfiguration = new System.Windows.Forms.Button();
            this.BtnLogRecords = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnScanPiece = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnPieces = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopPanel.BackgroundImage = global::Traceability_System.Properties.Resources.DegradadoTraza;
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.Controls.Add(this.BtnPieces);
            this.TopPanel.Controls.Add(this.BtnLogout);
            this.TopPanel.Controls.Add(this.BtnClose);
            this.TopPanel.Controls.Add(this.LblUser);
            this.TopPanel.Controls.Add(this.BtnConfiguration);
            this.TopPanel.Controls.Add(this.BtnLogRecords);
            this.TopPanel.Controls.Add(this.BtnUsers);
            this.TopPanel.Controls.Add(this.BtnScanPiece);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1164, 113);
            this.TopPanel.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogout.Location = new System.Drawing.Point(1031, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(97, 37);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClose.Location = new System.Drawing.Point(1127, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 37);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUser.Location = new System.Drawing.Point(12, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(54, 28);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "User";
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfiguration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConfiguration.Location = new System.Drawing.Point(855, 60);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(188, 47);
            this.BtnConfiguration.TabIndex = 3;
            this.BtnConfiguration.Text = "Configuraciones";
            this.BtnConfiguration.UseVisualStyleBackColor = false;
            // 
            // BtnLogRecords
            // 
            this.BtnLogRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLogRecords.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogRecords.Location = new System.Drawing.Point(463, 60);
            this.BtnLogRecords.Name = "BtnLogRecords";
            this.BtnLogRecords.Size = new System.Drawing.Size(188, 47);
            this.BtnLogRecords.TabIndex = 2;
            this.BtnLogRecords.Text = "Historicos";
            this.BtnLogRecords.UseVisualStyleBackColor = false;
            this.BtnLogRecords.Click += new System.EventHandler(this.BtnLogRecords_Click);
            // 
            // BtnUsers
            // 
            this.BtnUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUsers.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsers.Location = new System.Drawing.Point(267, 60);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(188, 47);
            this.BtnUsers.TabIndex = 1;
            this.BtnUsers.Text = "Usuarios";
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnScanPiece
            // 
            this.BtnScanPiece.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnScanPiece.BackColor = System.Drawing.Color.Transparent;
            this.BtnScanPiece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScanPiece.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScanPiece.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnScanPiece.Location = new System.Drawing.Point(71, 60);
            this.BtnScanPiece.Name = "BtnScanPiece";
            this.BtnScanPiece.Size = new System.Drawing.Size(188, 47);
            this.BtnScanPiece.TabIndex = 0;
            this.BtnScanPiece.Text = "Principal";
            this.BtnScanPiece.UseVisualStyleBackColor = false;
            this.BtnScanPiece.Click += new System.EventHandler(this.BtnScanPiece_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 113);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1164, 582);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnPieces
            // 
            this.BtnPieces.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPieces.BackColor = System.Drawing.Color.Transparent;
            this.BtnPieces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPieces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPieces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPieces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPieces.Location = new System.Drawing.Point(659, 60);
            this.BtnPieces.Name = "BtnPieces";
            this.BtnPieces.Size = new System.Drawing.Size(188, 47);
            this.BtnPieces.TabIndex = 7;
            this.BtnPieces.Text = "Piezas";
            this.BtnPieces.UseVisualStyleBackColor = false;
            this.BtnPieces.Click += new System.EventHandler(this.BtnPieces_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1164, 695);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button BtnConfiguration;
        private System.Windows.Forms.Button BtnLogRecords;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnScanPiece;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnPieces;
    }
}

