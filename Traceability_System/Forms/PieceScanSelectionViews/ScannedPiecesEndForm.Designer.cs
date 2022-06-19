
namespace Traceability_System.Forms.PieceScanSelectionViews
{
    partial class ScannedPiecesEndForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblGeneration = new System.Windows.Forms.Label();
            this.PiecesGv = new System.Windows.Forms.DataGridView();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesGv)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGeneration
            // 
            this.LblGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGeneration.AutoSize = true;
            this.LblGeneration.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeneration.Location = new System.Drawing.Point(378, 81);
            this.LblGeneration.Name = "LblGeneration";
            this.LblGeneration.Size = new System.Drawing.Size(0, 46);
            this.LblGeneration.TabIndex = 1;
            // 
            // PiecesGv
            // 
            this.PiecesGv.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PiecesGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PiecesGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PiecesGv.DefaultCellStyle = dataGridViewCellStyle2;
            this.PiecesGv.Location = new System.Drawing.Point(110, 165);
            this.PiecesGv.Name = "PiecesGv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PiecesGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PiecesGv.RowHeadersWidth = 51;
            this.PiecesGv.RowTemplate.Height = 29;
            this.PiecesGv.Size = new System.Drawing.Size(792, 416);
            this.PiecesGv.TabIndex = 2;
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveUser.Location = new System.Drawing.Point(203, 610);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(173, 95);
            this.BtnSaveUser.TabIndex = 9;
            this.BtnSaveUser.Text = "Cambiar generacion";
            this.BtnSaveUser.UseVisualStyleBackColor = false;
            this.BtnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnContinue.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnContinue.Location = new System.Drawing.Point(433, 610);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(173, 95);
            this.BtnContinue.TabIndex = 10;
            this.BtnContinue.Text = "Continuar con esta generacion";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogout.Location = new System.Drawing.Point(663, 610);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(173, 95);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "Salir";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // ScannedPiecesEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.PiecesGv);
            this.Controls.Add(this.LblGeneration);
            this.Name = "ScannedPiecesEndForm";
            this.Size = new System.Drawing.Size(1014, 764);
            this.Load += new System.EventHandler(this.ScannedPiecesEndForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PiecesGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGeneration;
        private System.Windows.Forms.DataGridView PiecesGv;
        private System.Windows.Forms.Button BtnSaveUser;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnLogout;
    }
}
