
namespace Traceability_System.Forms
{
    partial class ConfigurationsForm
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
            this.BtnShifts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShifts
            // 
            this.BtnShifts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnShifts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnShifts.Location = new System.Drawing.Point(650, 137);
            this.BtnShifts.Name = "BtnShifts";
            this.BtnShifts.Size = new System.Drawing.Size(199, 85);
            this.BtnShifts.TabIndex = 25;
            this.BtnShifts.Text = "Turnos";
            this.BtnShifts.UseVisualStyleBackColor = true;
            this.BtnShifts.Click += new System.EventHandler(this.BtnShifts_Click);
            // 
            // ConfigurationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnShifts);
            this.Name = "ConfigurationsForm";
            this.Size = new System.Drawing.Size(931, 755);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShifts;
    }
}
