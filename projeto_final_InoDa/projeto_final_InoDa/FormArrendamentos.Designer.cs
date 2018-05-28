namespace projeto_final_InoDa
{
    partial class FormArrendamentos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbArrendatário = new System.Windows.Forms.ComboBox();
            this.lbArrendatário = new System.Windows.Forms.Label();
            this.cbRenovavel = new System.Windows.Forms.CheckBox();
            this.nupDuração = new System.Windows.Forms.NumericUpDown();
            this.lbDuração = new System.Windows.Forms.Label();
            this.lbContrato = new System.Windows.Forms.Label();
            this.dtpContrato = new System.Windows.Forms.DateTimePicker();
            this.txtbCasa = new System.Windows.Forms.TextBox();
            this.lbCasa = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).BeginInit();
            this.SuspendLayout();
            // 
            // cbArrendatário
            // 
            this.cbArrendatário.FormattingEnabled = true;
            this.cbArrendatário.Location = new System.Drawing.Point(431, 249);
            this.cbArrendatário.Name = "cbArrendatário";
            this.cbArrendatário.Size = new System.Drawing.Size(200, 21);
            this.cbArrendatário.TabIndex = 22;
            // 
            // lbArrendatário
            // 
            this.lbArrendatário.AutoSize = true;
            this.lbArrendatário.Location = new System.Drawing.Point(428, 233);
            this.lbArrendatário.Name = "lbArrendatário";
            this.lbArrendatário.Size = new System.Drawing.Size(64, 13);
            this.lbArrendatário.TabIndex = 21;
            this.lbArrendatário.Text = "Arrendatário";
            // 
            // cbRenovavel
            // 
            this.cbRenovavel.AutoSize = true;
            this.cbRenovavel.Location = new System.Drawing.Point(431, 189);
            this.cbRenovavel.Name = "cbRenovavel";
            this.cbRenovavel.Size = new System.Drawing.Size(78, 17);
            this.cbRenovavel.TabIndex = 20;
            this.cbRenovavel.Text = "Renovavel";
            this.cbRenovavel.UseVisualStyleBackColor = true;
            // 
            // nupDuração
            // 
            this.nupDuração.Location = new System.Drawing.Point(431, 152);
            this.nupDuração.Name = "nupDuração";
            this.nupDuração.Size = new System.Drawing.Size(200, 20);
            this.nupDuração.TabIndex = 19;
            // 
            // lbDuração
            // 
            this.lbDuração.AutoSize = true;
            this.lbDuração.Location = new System.Drawing.Point(428, 136);
            this.lbDuração.Name = "lbDuração";
            this.lbDuração.Size = new System.Drawing.Size(48, 13);
            this.lbDuração.TabIndex = 18;
            this.lbDuração.Text = "Duração";
            // 
            // lbContrato
            // 
            this.lbContrato.AutoSize = true;
            this.lbContrato.Location = new System.Drawing.Point(428, 88);
            this.lbContrato.Name = "lbContrato";
            this.lbContrato.Size = new System.Drawing.Size(90, 13);
            this.lbContrato.TabIndex = 17;
            this.lbContrato.Text = "Inicio do Contrato";
            // 
            // dtpContrato
            // 
            this.dtpContrato.Location = new System.Drawing.Point(431, 104);
            this.dtpContrato.Name = "dtpContrato";
            this.dtpContrato.Size = new System.Drawing.Size(200, 20);
            this.dtpContrato.TabIndex = 16;
            // 
            // txtbCasa
            // 
            this.txtbCasa.Location = new System.Drawing.Point(12, 63);
            this.txtbCasa.Multiline = true;
            this.txtbCasa.Name = "txtbCasa";
            this.txtbCasa.Size = new System.Drawing.Size(304, 265);
            this.txtbCasa.TabIndex = 15;
            // 
            // lbCasa
            // 
            this.lbCasa.AutoSize = true;
            this.lbCasa.Location = new System.Drawing.Point(9, 11);
            this.lbCasa.Name = "lbCasa";
            this.lbCasa.Size = new System.Drawing.Size(37, 13);
            this.lbCasa.TabIndex = 14;
            this.lbCasa.Text = "Casa: ";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(431, 305);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(200, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(12, 334);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(304, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 367);
            this.Controls.Add(this.cbArrendatário);
            this.Controls.Add(this.lbArrendatário);
            this.Controls.Add(this.cbRenovavel);
            this.Controls.Add(this.nupDuração);
            this.Controls.Add(this.lbDuração);
            this.Controls.Add(this.lbContrato);
            this.Controls.Add(this.dtpContrato);
            this.Controls.Add(this.txtbCasa);
            this.Controls.Add(this.lbCasa);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnRemover);
            this.Name = "FormArrendamentos";
            this.Text = "FormArrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArrendatário;
        private System.Windows.Forms.Label lbArrendatário;
        private System.Windows.Forms.CheckBox cbRenovavel;
        private System.Windows.Forms.NumericUpDown nupDuração;
        private System.Windows.Forms.Label lbDuração;
        private System.Windows.Forms.Label lbContrato;
        private System.Windows.Forms.DateTimePicker dtpContrato;
        private System.Windows.Forms.TextBox txtbCasa;
        private System.Windows.Forms.Label lbCasa;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
    }
}