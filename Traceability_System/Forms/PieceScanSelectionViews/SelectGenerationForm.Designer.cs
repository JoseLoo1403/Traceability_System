
namespace Traceability_System.Forms.PieceScanSelectionViews
{
    partial class SelectGenerationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGen1 = new System.Windows.Forms.Button();
            this.BtnGen2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generacion a escanear";
            // 
            // BtnGen1
            // 
            this.BtnGen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGen1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGen1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGen1.Location = new System.Drawing.Point(115, 280);
            this.BtnGen1.Name = "BtnGen1";
            this.BtnGen1.Size = new System.Drawing.Size(186, 110);
            this.BtnGen1.TabIndex = 1;
            this.BtnGen1.Text = "Generacion 1";
            this.BtnGen1.UseVisualStyleBackColor = false;
            this.BtnGen1.Click += new System.EventHandler(this.BtnGen1_Click);
            // 
            // BtnGen2
            // 
            this.BtnGen2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGen2.BackColor = System.Drawing.Color.LightGreen;
            this.BtnGen2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGen2.Location = new System.Drawing.Point(412, 280);
            this.BtnGen2.Name = "BtnGen2";
            this.BtnGen2.Size = new System.Drawing.Size(186, 110);
            this.BtnGen2.TabIndex = 2;
            this.BtnGen2.Text = "Generacion 2";
            this.BtnGen2.UseVisualStyleBackColor = false;
            this.BtnGen2.Click += new System.EventHandler(this.BtnGen2_Click);
            // 
            // SelectGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.BtnGen2);
            this.Controls.Add(this.BtnGen1);
            this.Controls.Add(this.label1);
            this.Name = "SelectGenerationForm";
            this.Size = new System.Drawing.Size(741, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGen1;
        private System.Windows.Forms.Button BtnGen2;
    }
}
