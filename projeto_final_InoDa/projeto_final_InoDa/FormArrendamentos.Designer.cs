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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArrendamentos));
            this.cbArrendatário = new System.Windows.Forms.ComboBox();
            this.lbArrendatário = new System.Windows.Forms.Label();
            this.cbRenovavel = new System.Windows.Forms.CheckBox();
            this.nupDuração = new System.Windows.Forms.NumericUpDown();
            this.lbDuração = new System.Windows.Forms.Label();
            this.lbContrato = new System.Windows.Forms.Label();
            this.dtpContrato = new System.Windows.Forms.DateTimePicker();
            this.lbCasa = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lbArrendamentos = new System.Windows.Forms.ListBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbArrendatário
            // 
            this.cbArrendatário.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArrendatário.FormattingEnabled = true;
            this.cbArrendatário.Location = new System.Drawing.Point(342, 220);
            this.cbArrendatário.Name = "cbArrendatário";
            this.cbArrendatário.Size = new System.Drawing.Size(200, 21);
            this.cbArrendatário.TabIndex = 22;
            // 
            // lbArrendatário
            // 
            this.lbArrendatário.AutoSize = true;
            this.lbArrendatário.Location = new System.Drawing.Point(339, 204);
            this.lbArrendatário.Name = "lbArrendatário";
            this.lbArrendatário.Size = new System.Drawing.Size(64, 13);
            this.lbArrendatário.TabIndex = 21;
            this.lbArrendatário.Text = "Arrendatário";
            // 
            // cbRenovavel
            // 
            this.cbRenovavel.AutoSize = true;
            this.cbRenovavel.Location = new System.Drawing.Point(342, 184);
            this.cbRenovavel.Name = "cbRenovavel";
            this.cbRenovavel.Size = new System.Drawing.Size(78, 17);
            this.cbRenovavel.TabIndex = 20;
            this.cbRenovavel.Text = "Renovavel";
            this.cbRenovavel.UseVisualStyleBackColor = true;
            // 
            // nupDuração
            // 
            this.nupDuração.Location = new System.Drawing.Point(342, 158);
            this.nupDuração.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nupDuração.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDuração.Name = "nupDuração";
            this.nupDuração.Size = new System.Drawing.Size(200, 20);
            this.nupDuração.TabIndex = 19;
            this.nupDuração.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDuração
            // 
            this.lbDuração.AutoSize = true;
            this.lbDuração.Location = new System.Drawing.Point(339, 142);
            this.lbDuração.Name = "lbDuração";
            this.lbDuração.Size = new System.Drawing.Size(48, 13);
            this.lbDuração.TabIndex = 18;
            this.lbDuração.Text = "Duração";
            // 
            // lbContrato
            // 
            this.lbContrato.AutoSize = true;
            this.lbContrato.Location = new System.Drawing.Point(339, 103);
            this.lbContrato.Name = "lbContrato";
            this.lbContrato.Size = new System.Drawing.Size(90, 13);
            this.lbContrato.TabIndex = 17;
            this.lbContrato.Text = "Inicio do Contrato";
            // 
            // dtpContrato
            // 
            this.dtpContrato.Location = new System.Drawing.Point(342, 119);
            this.dtpContrato.Name = "dtpContrato";
            this.dtpContrato.Size = new System.Drawing.Size(200, 20);
            this.dtpContrato.TabIndex = 16;
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
            this.btnInserir.Location = new System.Drawing.Point(342, 247);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(200, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(12, 301);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(304, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lbArrendamentos
            // 
            this.lbArrendamentos.FormattingEnabled = true;
            this.lbArrendamentos.Location = new System.Drawing.Point(13, 75);
            this.lbArrendamentos.Name = "lbArrendamentos";
            this.lbArrendamentos.Size = new System.Drawing.Size(303, 212);
            this.lbArrendamentos.TabIndex = 23;
            this.lbArrendamentos.Click += new System.EventHandler(this.lbArrendamentos_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 11);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(13, 13);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "1";
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Location = new System.Drawing.Point(56, 28);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(13, 13);
            this.labelLocalidade.TabIndex = 25;
            this.labelLocalidade.Text = "2";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(56, 45);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(13, 13);
            this.labelCliente.TabIndex = 26;
            this.labelCliente.Text = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto_final_InoDa.Properties.Resources.family_in__house_icon_70516;
            this.pictureBox1.Location = new System.Drawing.Point(460, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(556, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelLocalidade);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.lbArrendamentos);
            this.Controls.Add(this.cbArrendatário);
            this.Controls.Add(this.lbArrendatário);
            this.Controls.Add(this.cbRenovavel);
            this.Controls.Add(this.nupDuração);
            this.Controls.Add(this.lbDuração);
            this.Controls.Add(this.lbContrato);
            this.Controls.Add(this.dtpContrato);
            this.Controls.Add(this.lbCasa);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnRemover);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArrendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrendamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormArrendamentos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nupDuração)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lbCasa;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lbArrendamentos;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}