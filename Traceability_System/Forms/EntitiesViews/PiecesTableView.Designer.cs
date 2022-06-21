
namespace Traceability_System.Forms.EntitiesViews
{
    partial class PiecesTableView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.PiecesGv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 98);
            this.panel1.TabIndex = 0;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh.Location = new System.Drawing.Point(714, 30);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(164, 40);
            this.BtnRefresh.TabIndex = 6;
            this.BtnRefresh.Text = "Refrescar";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla Piezas";
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExport.Location = new System.Drawing.Point(941, 30);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(152, 40);
            this.BtnExport.TabIndex = 5;
            this.BtnExport.Text = "Exportar";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // PiecesGv
            // 
            this.PiecesGv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PiecesGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiecesGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PiecesGv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.PiecesGv.Location = new System.Drawing.Point(0, 98);
            this.PiecesGv.Name = "PiecesGv";
            this.PiecesGv.ReadOnly = true;
            this.PiecesGv.RowHeadersWidth = 51;
            this.PiecesGv.RowTemplate.Height = 29;
            this.PiecesGv.Size = new System.Drawing.Size(1139, 633);
            this.PiecesGv.TabIndex = 1;
            // 
            // PiecesTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PiecesGv);
            this.Controls.Add(this.panel1);
            this.Name = "PiecesTableView";
            this.Size = new System.Drawing.Size(1139, 731);
            this.Load += new System.EventHandler(this.PiecesTableView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataGridView PiecesGv;
    }
}
