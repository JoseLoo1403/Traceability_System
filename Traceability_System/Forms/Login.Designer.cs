
namespace Traceability_System.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LblInstrucctions = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.ValidatorTm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de trazabilidad APTIV";
            // 
            // LblInstrucctions
            // 
            this.LblInstrucctions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblInstrucctions.AutoSize = true;
            this.LblInstrucctions.Location = new System.Drawing.Point(389, 316);
            this.LblInstrucctions.Name = "LblInstrucctions";
            this.LblInstrucctions.Size = new System.Drawing.Size(131, 20);
            this.LblInstrucctions.TabIndex = 2;
            this.LblInstrucctions.Text = "Escanee su codigo";
            // 
            // TxtCode
            // 
            this.TxtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCode.Location = new System.Drawing.Point(348, 384);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(237, 27);
            this.TxtCode.TabIndex = 4;
            this.TxtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            // 
            // ValidatorTm
            // 
            this.ValidatorTm.Enabled = true;
            this.ValidatorTm.Interval = 500;
            this.ValidatorTm.Tick += new System.EventHandler(this.ValidatorTm_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblInstrucctions);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(939, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblInstrucctions;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Timer ValidatorTm;
    }
}
