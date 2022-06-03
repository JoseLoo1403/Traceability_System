
namespace Traceability_System.Forms
{
    partial class PieceScanForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPartNumber = new System.Windows.Forms.TextBox();
            this.TxtSerialNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblComponent = new System.Windows.Forms.Label();
            this.LblGeneration = new System.Windows.Forms.Label();
            this.TimerScan = new System.Windows.Forms.Timer(this.components);
            this.LblMainGuide = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escaneo de piezas";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESCANEE EL NUMERO DE PARTE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(546, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "ESCANEE EL SERIALIZADO";
            // 
            // TxtPartNumber
            // 
            this.TxtPartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPartNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPartNumber.Location = new System.Drawing.Point(58, 331);
            this.TxtPartNumber.Name = "TxtPartNumber";
            this.TxtPartNumber.Size = new System.Drawing.Size(267, 34);
            this.TxtPartNumber.TabIndex = 3;
            // 
            // TxtSerialNumber
            // 
            this.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSerialNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSerialNumber.Location = new System.Drawing.Point(529, 331);
            this.TxtSerialNumber.Name = "TxtSerialNumber";
            this.TxtSerialNumber.Size = new System.Drawing.Size(267, 34);
            this.TxtSerialNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(315, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Generacion detectada:";
            // 
            // LblComponent
            // 
            this.LblComponent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblComponent.AutoSize = true;
            this.LblComponent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblComponent.Location = new System.Drawing.Point(343, 152);
            this.LblComponent.Name = "LblComponent";
            this.LblComponent.Size = new System.Drawing.Size(178, 31);
            this.LblComponent.TabIndex = 6;
            this.LblComponent.Text = "Componente #1";
            // 
            // LblGeneration
            // 
            this.LblGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGeneration.AutoSize = true;
            this.LblGeneration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGeneration.Location = new System.Drawing.Point(372, 531);
            this.LblGeneration.Name = "LblGeneration";
            this.LblGeneration.Size = new System.Drawing.Size(119, 28);
            this.LblGeneration.TabIndex = 7;
            this.LblGeneration.Text = "Generacion";
            // 
            // TimerScan
            // 
            this.TimerScan.Enabled = true;
            this.TimerScan.Interval = 700;
            this.TimerScan.Tick += new System.EventHandler(this.TimerScan_Tick);
            // 
            // LblMainGuide
            // 
            this.LblMainGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMainGuide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMainGuide.Location = new System.Drawing.Point(135, 403);
            this.LblMainGuide.Name = "LblMainGuide";
            this.LblMainGuide.Size = new System.Drawing.Size(586, 28);
            this.LblMainGuide.TabIndex = 8;
            this.LblMainGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PieceScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblMainGuide);
            this.Controls.Add(this.LblGeneration);
            this.Controls.Add(this.LblComponent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSerialNumber);
            this.Controls.Add(this.TxtPartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PieceScanForm";
            this.Size = new System.Drawing.Size(885, 669);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPartNumber;
        private System.Windows.Forms.TextBox TxtSerialNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblComponent;
        private System.Windows.Forms.Label LblGeneration;
        private System.Windows.Forms.Timer TimerScan;
        private System.Windows.Forms.Label LblMainGuide;
    }
}
