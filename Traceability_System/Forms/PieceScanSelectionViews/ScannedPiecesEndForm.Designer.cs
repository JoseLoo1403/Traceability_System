
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
            this.LblGeneration = new System.Windows.Forms.Label();
            this.PiecesGv = new System.Windows.Forms.DataGridView();
            this.BtnSaveUser = new System.Windows.Forms.Button();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PiecesGv)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGeneration
            // 
            this.LblGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGeneration.AutoSize = true;
            this.LblGeneration.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblGeneration.Location = new System.Drawing.Point(316, 49);
            this.LblGeneration.Name = "LblGeneration";
            this.LblGeneration.Size = new System.Drawing.Size(0, 41);
            this.LblGeneration.TabIndex = 1;
            // 
            // PiecesGv
            // 
            this.PiecesGv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PiecesGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiecesGv.Location = new System.Drawing.Point(142, 104);
            this.PiecesGv.Name = "PiecesGv";
            this.PiecesGv.RowHeadersWidth = 51;
            this.PiecesGv.RowTemplate.Height = 29;
            this.PiecesGv.Size = new System.Drawing.Size(606, 430);
            this.PiecesGv.TabIndex = 2;
            // 
            // BtnSaveUser
            // 
            this.BtnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSaveUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveUser.Location = new System.Drawing.Point(142, 555);
            this.BtnSaveUser.Name = "BtnSaveUser";
            this.BtnSaveUser.Size = new System.Drawing.Size(173, 95);
            this.BtnSaveUser.TabIndex = 9;
            this.BtnSaveUser.Text = "Cambiar generacion";
            this.BtnSaveUser.UseVisualStyleBackColor = false;
            // 
            // BtnContinue
            // 
            this.BtnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnContinue.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinue.Location = new System.Drawing.Point(361, 555);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(173, 95);
            this.BtnContinue.TabIndex = 10;
            this.BtnContinue.Text = "Continuar con esta generacion";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(575, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 95);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ScannedPiecesEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.BtnSaveUser);
            this.Controls.Add(this.PiecesGv);
            this.Controls.Add(this.LblGeneration);
            this.Name = "ScannedPiecesEndForm";
            this.Size = new System.Drawing.Size(891, 700);
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
        private System.Windows.Forms.Button button2;
    }
}
