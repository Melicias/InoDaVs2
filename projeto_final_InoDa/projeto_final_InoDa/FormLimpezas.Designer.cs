namespace projeto_final_InoDa
{
    partial class FormLimpezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLimpezas));
            this.dtpFatura = new System.Windows.Forms.DateTimePicker();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnEmitir = new System.Windows.Forms.Button();
            this.gbDetalhes = new System.Windows.Forms.GroupBox();
            this.lbServicos = new System.Windows.Forms.ListBox();
            this.lbValorUnitario = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.nupQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cbServico = new System.Windows.Forms.ComboBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbasdafa = new System.Windows.Forms.Label();
            this.lbServiço = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbLimpezas = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIdLocalidadeRua = new System.Windows.Forms.Label();
            this.gbDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFatura
            // 
            this.dtpFatura.Location = new System.Drawing.Point(8, 462);
            this.dtpFatura.Name = "dtpFatura";
            this.dtpFatura.Size = new System.Drawing.Size(223, 20);
            this.dtpFatura.TabIndex = 22;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(237, 462);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 21;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnEmitir
            // 
            this.btnEmitir.Location = new System.Drawing.Point(10, 433);
            this.btnEmitir.Name = "btnEmitir";
            this.btnEmitir.Size = new System.Drawing.Size(302, 23);
            this.btnEmitir.TabIndex = 20;
            this.btnEmitir.Text = "Emitir Fatura";
            this.btnEmitir.UseVisualStyleBackColor = true;
            this.btnEmitir.Click += new System.EventHandler(this.btnEmitir_Click);
            // 
            // gbDetalhes
            // 
            this.gbDetalhes.Controls.Add(this.lbServicos);
            this.gbDetalhes.Controls.Add(this.lbValorUnitario);
            this.gbDetalhes.Controls.Add(this.btnInserir);
            this.gbDetalhes.Controls.Add(this.nupQuantidade);
            this.gbDetalhes.Controls.Add(this.cbServico);
            this.gbDetalhes.Controls.Add(this.lbQuantidade);
            this.gbDetalhes.Controls.Add(this.lbasdafa);
            this.gbDetalhes.Controls.Add(this.lbServiço);
            this.gbDetalhes.Location = new System.Drawing.Point(346, 93);
            this.gbDetalhes.Name = "gbDetalhes";
            this.gbDetalhes.Size = new System.Drawing.Size(556, 392);
            this.gbDetalhes.TabIndex = 18;
            this.gbDetalhes.TabStop = false;
            this.gbDetalhes.Text = "Detalhes da Limpeza";
            // 
            // lbServicos
            // 
            this.lbServicos.FormattingEnabled = true;
            this.lbServicos.Location = new System.Drawing.Point(17, 83);
            this.lbServicos.Name = "lbServicos";
            this.lbServicos.Size = new System.Drawing.Size(533, 303);
            this.lbServicos.TabIndex = 11;
            // 
            // lbValorUnitario
            // 
            this.lbValorUnitario.AutoSize = true;
            this.lbValorUnitario.Location = new System.Drawing.Point(89, 59);
            this.lbValorUnitario.Name = "lbValorUnitario";
            this.lbValorUnitario.Size = new System.Drawing.Size(0, 13);
            this.lbValorUnitario.TabIndex = 10;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(455, 17);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // nupQuantidade
            // 
            this.nupQuantidade.Location = new System.Drawing.Point(319, 20);
            this.nupQuantidade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupQuantidade.Name = "nupQuantidade";
            this.nupQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nupQuantidade.TabIndex = 8;
            this.nupQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbServico
            // 
            this.cbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServico.FormattingEnabled = true;
            this.cbServico.Items.AddRange(new object[] {
            "Área até 20m2 1h",
            "Área até 20m2 2h",
            "Área até 40m2 1h",
            "Área até 40m2 2h",
            "Área até 80m2 1h",
            "Área até 80m2 2h",
            "Área até 100m2 1h",
            "Área até 100m2 2h"});
            this.cbServico.Location = new System.Drawing.Point(61, 19);
            this.cbServico.Name = "cbServico";
            this.cbServico.Size = new System.Drawing.Size(164, 21);
            this.cbServico.TabIndex = 7;
            this.cbServico.SelectedIndexChanged += new System.EventHandler(this.cbServiço_SelectedIndexChanged);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(248, 22);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 6;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbasdafa
            // 
            this.lbasdafa.AutoSize = true;
            this.lbasdafa.Location = new System.Drawing.Point(9, 59);
            this.lbasdafa.Name = "lbasdafa";
            this.lbasdafa.Size = new System.Drawing.Size(85, 13);
            this.lbasdafa.TabIndex = 5;
            this.lbasdafa.Text = "Valor Unitário(€):";
            // 
            // lbServiço
            // 
            this.lbServiço.AutoSize = true;
            this.lbServiço.Location = new System.Drawing.Point(9, 19);
            this.lbServiço.Name = "lbServiço";
            this.lbServiço.Size = new System.Drawing.Size(46, 13);
            this.lbServiço.TabIndex = 4;
            this.lbServiço.Text = "Serviço:";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(-50, -42);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(31, 13);
            this.lbBase.TabIndex = 17;
            this.lbBase.Text = "Base";
            // 
            // lbLimpezas
            // 
            this.lbLimpezas.FormattingEnabled = true;
            this.lbLimpezas.Location = new System.Drawing.Point(13, 93);
            this.lbLimpezas.Name = "lbLimpezas";
            this.lbLimpezas.Size = new System.Drawing.Size(299, 329);
            this.lbLimpezas.TabIndex = 23;
            this.lbLimpezas.SelectedIndexChanged += new System.EventHandler(this.lbLimpezas_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto_final_InoDa.Properties.Resources._687474703a2f2f692e696d6775722e636f6d2f48656c687441782e706e67;
            this.pictureBox1.Location = new System.Drawing.Point(823, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbIdLocalidadeRua
            // 
            this.lbIdLocalidadeRua.AutoSize = true;
            this.lbIdLocalidadeRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdLocalidadeRua.Location = new System.Drawing.Point(13, 12);
            this.lbIdLocalidadeRua.Name = "lbIdLocalidadeRua";
            this.lbIdLocalidadeRua.Size = new System.Drawing.Size(0, 20);
            this.lbIdLocalidadeRua.TabIndex = 25;
            // 
            // FormLimpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(915, 494);
            this.Controls.Add(this.lbIdLocalidadeRua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbLimpezas);
            this.Controls.Add(this.dtpFatura);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnEmitir);
            this.Controls.Add(this.gbDetalhes);
            this.Controls.Add(this.lbBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLimpezas";
            this.Text = "FormLimpezas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLimpezas_FormClosing);
            this.gbDetalhes.ResumeLayout(false);
            this.gbDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFatura;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.GroupBox gbDetalhes;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.NumericUpDown nupQuantidade;
        private System.Windows.Forms.ComboBox cbServico;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbasdafa;
        private System.Windows.Forms.Label lbServiço;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.ListBox lbLimpezas;
        private System.Windows.Forms.Label lbValorUnitario;
        private System.Windows.Forms.ListBox lbServicos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbIdLocalidadeRua;
    }
}