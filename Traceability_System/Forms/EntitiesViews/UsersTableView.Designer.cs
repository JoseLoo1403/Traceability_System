
namespace Traceability_System.Forms.EntitiesViews
{
    partial class UsersTableView
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
            this.UsersGv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersGv
            // 
            this.UsersGv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.UsersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.UsersGv.Location = new System.Drawing.Point(0, 69);
            this.UsersGv.Name = "UsersGv";
            this.UsersGv.RowHeadersWidth = 51;
            this.UsersGv.RowTemplate.Height = 29;
            this.UsersGv.Size = new System.Drawing.Size(966, 592);
            this.UsersGv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla Usuarios";
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.Location = new System.Drawing.Point(728, 16);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(152, 40);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.Text = "Exportar";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 69);
            this.panel1.TabIndex = 3;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh.Location = new System.Drawing.Point(501, 16);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(164, 40);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Refrescar";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // UsersTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersGv);
            this.Controls.Add(this.panel1);
            this.Name = "UsersTableView";
            this.Size = new System.Drawing.Size(966, 661);
            this.Load += new System.EventHandler(this.UsersTableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersGv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefresh;
    }
}
