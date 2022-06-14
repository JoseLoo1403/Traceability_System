
namespace Traceability_System.Forms
{
    partial class AddPiecesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGeneration = new System.Windows.Forms.ComboBox();
            this.TxtPartNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnViewPieces = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtFinishGood = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDeletePartNumber = new System.Windows.Forms.TextBox();
            this.LblMainGuide = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtDays = new System.Windows.Forms.NumericUpDown();
            this.TxtName = new System.Windows.Forms.ComboBox();
            this.BtnSerialNumbersView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(224, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de parte:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(266, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dias habiles:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(272, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Generacion:";
            // 
            // TxtGeneration
            // 
            this.TxtGeneration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtGeneration.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtGeneration.FormattingEnabled = true;
            this.TxtGeneration.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TxtGeneration.Location = new System.Drawing.Point(389, 290);
            this.TxtGeneration.Name = "TxtGeneration";
            this.TxtGeneration.Size = new System.Drawing.Size(70, 33);
            this.TxtGeneration.TabIndex = 10;
            this.TxtGeneration.SelectedIndexChanged += new System.EventHandler(this.TxtGeneration_SelectedIndexChanged);
            // 
            // TxtPartNumber
            // 
            this.TxtPartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPartNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPartNumber.Location = new System.Drawing.Point(389, 217);
            this.TxtPartNumber.Name = "TxtPartNumber";
            this.TxtPartNumber.Size = new System.Drawing.Size(197, 31);
            this.TxtPartNumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(482, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agregar pieza";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAdd.Location = new System.Drawing.Point(709, 106);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(250, 85);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnViewPieces
            // 
            this.BtnViewPieces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnViewPieces.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnViewPieces.Location = new System.Drawing.Point(709, 233);
            this.BtnViewPieces.Name = "BtnViewPieces";
            this.BtnViewPieces.Size = new System.Drawing.Size(250, 85);
            this.BtnViewPieces.TabIndex = 15;
            this.BtnViewPieces.Text = "Ver tabla";
            this.BtnViewPieces.UseVisualStyleBackColor = true;
            this.BtnViewPieces.Click += new System.EventHandler(this.BtnViewPieces_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(265, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Finish Good:";
            // 
            // TxtFinishGood
            // 
            this.TxtFinishGood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFinishGood.Enabled = false;
            this.TxtFinishGood.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFinishGood.Location = new System.Drawing.Point(389, 364);
            this.TxtFinishGood.Name = "TxtFinishGood";
            this.TxtFinishGood.Size = new System.Drawing.Size(197, 31);
            this.TxtFinishGood.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(224, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Numero de parte:";
            // 
            // TxtDeletePartNumber
            // 
            this.TxtDeletePartNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDeletePartNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDeletePartNumber.Location = new System.Drawing.Point(382, 590);
            this.TxtDeletePartNumber.Name = "TxtDeletePartNumber";
            this.TxtDeletePartNumber.Size = new System.Drawing.Size(197, 31);
            this.TxtDeletePartNumber.TabIndex = 18;
            // 
            // LblMainGuide
            // 
            this.LblMainGuide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMainGuide.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMainGuide.Location = new System.Drawing.Point(238, 763);
            this.LblMainGuide.Name = "LblMainGuide";
            this.LblMainGuide.Size = new System.Drawing.Size(736, 25);
            this.LblMainGuide.TabIndex = 20;
            this.LblMainGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDelete.BackColor = System.Drawing.Color.Tomato;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(709, 563);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(250, 85);
            this.BtnDelete.TabIndex = 21;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtDays
            // 
            this.TxtDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDays.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDays.Location = new System.Drawing.Point(389, 433);
            this.TxtDays.Name = "TxtDays";
            this.TxtDays.Size = new System.Drawing.Size(70, 31);
            this.TxtDays.TabIndex = 22;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.FormattingEnabled = true;
            this.TxtName.Items.AddRange(new object[] {
            "Housing",
            "CPA",
            "Cover"});
            this.TxtName.Location = new System.Drawing.Point(389, 127);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(151, 33);
            this.TxtName.TabIndex = 23;
            // 
            // BtnSerialNumbersView
            // 
            this.BtnSerialNumbersView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSerialNumbersView.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSerialNumbersView.Location = new System.Drawing.Point(709, 353);
            this.BtnSerialNumbersView.Name = "BtnSerialNumbersView";
            this.BtnSerialNumbersView.Size = new System.Drawing.Size(250, 85);
            this.BtnSerialNumbersView.TabIndex = 24;
            this.BtnSerialNumbersView.Text = "Numeros Seriales";
            this.BtnSerialNumbersView.UseVisualStyleBackColor = true;
            this.BtnSerialNumbersView.Click += new System.EventHandler(this.BtnSerialNumbersView_Click);
            // 
            // AddPiecesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.BtnSerialNumbersView);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtDays);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblMainGuide);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDeletePartNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFinishGood);
            this.Controls.Add(this.BtnViewPieces);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtGeneration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPartNumber);
            this.Controls.Add(this.label1);
            this.Name = "AddPiecesForm";
            this.Size = new System.Drawing.Size(1185, 818);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TxtGeneration;
        private System.Windows.Forms.TextBox TxtPartNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnViewPieces;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtFinishGood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDeletePartNumber;
        private System.Windows.Forms.Label LblMainGuide;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.NumericUpDown TxtDays;
        private System.Windows.Forms.ComboBox TxtName;
        private System.Windows.Forms.Button BtnSerialNumbersView;
    }
}
