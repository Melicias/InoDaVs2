namespace projeto_final_InoDa
{
    partial class FormDetalhesCasa
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
            this.gbDetalhesCasa = new System.Windows.Forms.GroupBox();
            this.tbAssoalhadas = new System.Windows.Forms.NumericUpDown();
            this.tbWc = new System.Windows.Forms.NumericUpDown();
            this.tbPisos = new System.Windows.Forms.NumericUpDown();
            this.tbArea = new System.Windows.Forms.NumericUpDown();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbAndar = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetalhesCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAssoalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalhesCasa
            // 
            this.gbDetalhesCasa.Controls.Add(this.tbAssoalhadas);
            this.gbDetalhesCasa.Controls.Add(this.tbWc);
            this.gbDetalhesCasa.Controls.Add(this.tbPisos);
            this.gbDetalhesCasa.Controls.Add(this.tbArea);
            this.gbDetalhesCasa.Controls.Add(this.cbTipo);
            this.gbDetalhesCasa.Controls.Add(this.label10);
            this.gbDetalhesCasa.Controls.Add(this.label2);
            this.gbDetalhesCasa.Controls.Add(this.label8);
            this.gbDetalhesCasa.Controls.Add(this.label9);
            this.gbDetalhesCasa.Controls.Add(this.label6);
            this.gbDetalhesCasa.Controls.Add(this.label7);
            this.gbDetalhesCasa.Controls.Add(this.label4);
            this.gbDetalhesCasa.Controls.Add(this.label5);
            this.gbDetalhesCasa.Controls.Add(this.label3);
            this.gbDetalhesCasa.Controls.Add(this.lb2);
            this.gbDetalhesCasa.Controls.Add(this.tbAndar);
            this.gbDetalhesCasa.Controls.Add(this.tbNumero);
            this.gbDetalhesCasa.Controls.Add(this.tbRua);
            this.gbDetalhesCasa.Controls.Add(this.tbLocalidade);
            this.gbDetalhesCasa.Controls.Add(this.tbId);
            this.gbDetalhesCasa.Controls.Add(this.label1);
            this.gbDetalhesCasa.Enabled = false;
            this.gbDetalhesCasa.Location = new System.Drawing.Point(12, 12);
            this.gbDetalhesCasa.Name = "gbDetalhesCasa";
            this.gbDetalhesCasa.Size = new System.Drawing.Size(324, 287);
            this.gbDetalhesCasa.TabIndex = 11;
            this.gbDetalhesCasa.TabStop = false;
            this.gbDetalhesCasa.Text = "Detalhes da casa";
            // 
            // tbAssoalhadas
            // 
            this.tbAssoalhadas.Location = new System.Drawing.Point(77, 185);
            this.tbAssoalhadas.Name = "tbAssoalhadas";
            this.tbAssoalhadas.Size = new System.Drawing.Size(120, 20);
            this.tbAssoalhadas.TabIndex = 40;
            // 
            // tbWc
            // 
            this.tbWc.Location = new System.Drawing.Point(77, 211);
            this.tbWc.Name = "tbWc";
            this.tbWc.Size = new System.Drawing.Size(120, 20);
            this.tbWc.TabIndex = 39;
            // 
            // tbPisos
            // 
            this.tbPisos.Location = new System.Drawing.Point(77, 233);
            this.tbPisos.Name = "tbPisos";
            this.tbPisos.Size = new System.Drawing.Size(120, 20);
            this.tbPisos.TabIndex = 38;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(77, 159);
            this.tbArea.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(120, 20);
            this.tbArea.TabIndex = 37;
            this.tbArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Moradia",
            "Moradia com jardin",
            "Moradia com piscina",
            "Moradia com piscina e jardim",
            "Apartamento",
            "Apartamento com piscina",
            "Apartamento com piscina e jardim"});
            this.cbTipo.Location = new System.Drawing.Point(77, 259);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(241, 21);
            this.cbTipo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "WC\'s:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pisos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Assoalhadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "M2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Andar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rua:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(16, 47);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(58, 13);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "localidade:";
            // 
            // tbAndar
            // 
            this.tbAndar.Location = new System.Drawing.Point(77, 129);
            this.tbAndar.Name = "tbAndar";
            this.tbAndar.Size = new System.Drawing.Size(241, 20);
            this.tbAndar.TabIndex = 5;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(77, 101);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(241, 20);
            this.tbNumero.TabIndex = 4;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(77, 73);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(241, 20);
            this.tbRua.TabIndex = 3;
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(77, 47);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(241, 20);
            this.tbLocalidade.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(31, 20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(26, 20);
            this.tbId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // FormDetalhesCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 307);
            this.Controls.Add(this.gbDetalhesCasa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetalhesCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalhesCasa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalhesCasa_FormClosing);
            this.gbDetalhesCasa.ResumeLayout(false);
            this.gbDetalhesCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAssoalhadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalhesCasa;
        private System.Windows.Forms.NumericUpDown tbAssoalhadas;
        private System.Windows.Forms.NumericUpDown tbWc;
        private System.Windows.Forms.NumericUpDown tbPisos;
        private System.Windows.Forms.NumericUpDown tbArea;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbAndar;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
    }
}