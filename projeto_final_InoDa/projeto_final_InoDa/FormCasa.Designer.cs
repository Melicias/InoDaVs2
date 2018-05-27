namespace projeto_final_InoDa
{
    partial class FormCasa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGVCasas = new System.Windows.Forms.DataGridView();
            this.idCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApagar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPesquisaCasas = new System.Windows.Forms.ComboBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.tbPesquisarCasas = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbAssoalhadas = new System.Windows.Forms.NumericUpDown();
            this.tbWc = new System.Windows.Forms.NumericUpDown();
            this.tbPisos = new System.Windows.Forms.NumericUpDown();
            this.tbArea = new System.Windows.Forms.NumericUpDown();
            this.btNova = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btGerarLimpezas = new System.Windows.Forms.Button();
            this.gbVendavel = new System.Windows.Forms.GroupBox();
            this.btVerVenda = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbComissaoBase = new System.Windows.Forms.TextBox();
            this.tbValorBaseNegocial = new System.Windows.Forms.TextBox();
            this.gbArrendamento = new System.Windows.Forms.GroupBox();
            this.btVerCriarArrendamento = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbComissao = new System.Windows.Forms.TextBox();
            this.tbValorBase = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbVendaArrenda = new System.Windows.Forms.GroupBox();
            this.rbVendavel = new System.Windows.Forms.RadioButton();
            this.rbArrendavel = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProprietario = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCasas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAssoalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea)).BeginInit();
            this.gbVendavel.SuspendLayout();
            this.gbArrendamento.SuspendLayout();
            this.gbVendaArrenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGVCasas);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casas";
            // 
            // dataGVCasas
            // 
            this.dataGVCasas.AllowUserToAddRows = false;
            this.dataGVCasas.AllowUserToDeleteRows = false;
            this.dataGVCasas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCasas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCasa,
            this.Localidade,
            this.Rua});
            this.dataGVCasas.Location = new System.Drawing.Point(6, 19);
            this.dataGVCasas.Name = "dataGVCasas";
            this.dataGVCasas.ReadOnly = true;
            this.dataGVCasas.Size = new System.Drawing.Size(348, 525);
            this.dataGVCasas.TabIndex = 0;
            this.dataGVCasas.Click += new System.EventHandler(this.dataGVCasas_Click);
            // 
            // idCasa
            // 
            this.idCasa.DataPropertyName = "idCasa";
            this.idCasa.HeaderText = "IdCasa";
            this.idCasa.Name = "idCasa";
            this.idCasa.ReadOnly = true;
            // 
            // Localidade
            // 
            this.Localidade.DataPropertyName = "localidade";
            this.Localidade.HeaderText = "Localidade";
            this.Localidade.Name = "Localidade";
            this.Localidade.ReadOnly = true;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(12, 656);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(364, 23);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPesquisaCasas);
            this.groupBox2.Controls.Add(this.btFiltrar);
            this.groupBox2.Controls.Add(this.tbPesquisarCasas);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 82);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar Casas";
            // 
            // cbPesquisaCasas
            // 
            this.cbPesquisaCasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaCasas.FormattingEnabled = true;
            this.cbPesquisaCasas.Items.AddRange(new object[] {
            "Id",
            "Localidade",
            "Rua",
            "Nome do proprietario",
            "Tipo"});
            this.cbPesquisaCasas.Location = new System.Drawing.Point(10, 46);
            this.cbPesquisaCasas.Name = "cbPesquisaCasas";
            this.cbPesquisaCasas.Size = new System.Drawing.Size(263, 21);
            this.cbPesquisaCasas.TabIndex = 4;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(279, 44);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(69, 23);
            this.btFiltrar.TabIndex = 3;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // tbPesquisarCasas
            // 
            this.tbPesquisarCasas.Location = new System.Drawing.Point(9, 19);
            this.tbPesquisarCasas.Name = "tbPesquisarCasas";
            this.tbPesquisarCasas.Size = new System.Drawing.Size(339, 20);
            this.tbPesquisarCasas.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbAssoalhadas);
            this.groupBox3.Controls.Add(this.tbWc);
            this.groupBox3.Controls.Add(this.tbPisos);
            this.groupBox3.Controls.Add(this.tbArea);
            this.groupBox3.Controls.Add(this.btNova);
            this.groupBox3.Controls.Add(this.btGuardar);
            this.groupBox3.Controls.Add(this.btGerarLimpezas);
            this.groupBox3.Controls.Add(this.gbVendavel);
            this.groupBox3.Controls.Add(this.gbArrendamento);
            this.groupBox3.Controls.Add(this.gbVendaArrenda);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbProprietario);
            this.groupBox3.Controls.Add(this.cbTipo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lb2);
            this.groupBox3.Controls.Add(this.tbAndar);
            this.groupBox3.Controls.Add(this.tbNumero);
            this.groupBox3.Controls.Add(this.tbRua);
            this.groupBox3.Controls.Add(this.tbLocalidade);
            this.groupBox3.Controls.Add(this.tbId);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(382, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 579);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhes";
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
            // btNova
            // 
            this.btNova.Location = new System.Drawing.Point(243, 550);
            this.btNova.Name = "btNova";
            this.btNova.Size = new System.Drawing.Size(75, 23);
            this.btNova.TabIndex = 36;
            this.btNova.Text = "Nova";
            this.btNova.UseVisualStyleBackColor = true;
            this.btNova.Click += new System.EventHandler(this.btNova_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(10, 550);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 35;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btGerarLimpezas
            // 
            this.btGerarLimpezas.Enabled = false;
            this.btGerarLimpezas.Location = new System.Drawing.Point(11, 516);
            this.btGerarLimpezas.Name = "btGerarLimpezas";
            this.btGerarLimpezas.Size = new System.Drawing.Size(298, 21);
            this.btGerarLimpezas.TabIndex = 34;
            this.btGerarLimpezas.Text = "Gerir Limpezas";
            this.btGerarLimpezas.UseVisualStyleBackColor = true;
            // 
            // gbVendavel
            // 
            this.gbVendavel.Controls.Add(this.btVerVenda);
            this.gbVendavel.Controls.Add(this.label18);
            this.gbVendavel.Controls.Add(this.label19);
            this.gbVendavel.Controls.Add(this.label17);
            this.gbVendavel.Controls.Add(this.label16);
            this.gbVendavel.Controls.Add(this.tbComissaoBase);
            this.gbVendavel.Controls.Add(this.tbValorBaseNegocial);
            this.gbVendavel.Enabled = false;
            this.gbVendavel.Location = new System.Drawing.Point(170, 372);
            this.gbVendavel.Name = "gbVendavel";
            this.gbVendavel.Size = new System.Drawing.Size(148, 138);
            this.gbVendavel.TabIndex = 33;
            this.gbVendavel.TabStop = false;
            this.gbVendavel.Text = "Dados de venda";
            // 
            // btVerVenda
            // 
            this.btVerVenda.Location = new System.Drawing.Point(36, 106);
            this.btVerVenda.Name = "btVerVenda";
            this.btVerVenda.Size = new System.Drawing.Size(75, 23);
            this.btVerVenda.TabIndex = 8;
            this.btVerVenda.Text = "Ver";
            this.btVerVenda.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(123, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "€";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(123, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "€";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Comissão base";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Valor base negocial:";
            // 
            // tbComissaoBase
            // 
            this.tbComissaoBase.Location = new System.Drawing.Point(17, 80);
            this.tbComissaoBase.Name = "tbComissaoBase";
            this.tbComissaoBase.Size = new System.Drawing.Size(100, 20);
            this.tbComissaoBase.TabIndex = 1;
            // 
            // tbValorBaseNegocial
            // 
            this.tbValorBaseNegocial.Location = new System.Drawing.Point(17, 32);
            this.tbValorBaseNegocial.Name = "tbValorBaseNegocial";
            this.tbValorBaseNegocial.Size = new System.Drawing.Size(100, 20);
            this.tbValorBaseNegocial.TabIndex = 0;
            // 
            // gbArrendamento
            // 
            this.gbArrendamento.Controls.Add(this.btVerCriarArrendamento);
            this.gbArrendamento.Controls.Add(this.label15);
            this.gbArrendamento.Controls.Add(this.label14);
            this.gbArrendamento.Controls.Add(this.tbComissao);
            this.gbArrendamento.Controls.Add(this.tbValorBase);
            this.gbArrendamento.Controls.Add(this.label13);
            this.gbArrendamento.Controls.Add(this.label12);
            this.gbArrendamento.Enabled = false;
            this.gbArrendamento.Location = new System.Drawing.Point(11, 372);
            this.gbArrendamento.Name = "gbArrendamento";
            this.gbArrendamento.Size = new System.Drawing.Size(138, 138);
            this.gbArrendamento.TabIndex = 32;
            this.gbArrendamento.TabStop = false;
            this.gbArrendamento.Text = "Dados de arrendamento";
            // 
            // btVerCriarArrendamento
            // 
            this.btVerCriarArrendamento.Location = new System.Drawing.Point(28, 106);
            this.btVerCriarArrendamento.Name = "btVerCriarArrendamento";
            this.btVerCriarArrendamento.Size = new System.Drawing.Size(75, 23);
            this.btVerCriarArrendamento.TabIndex = 6;
            this.btVerCriarArrendamento.Text = "Ver/Criar";
            this.btVerCriarArrendamento.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(117, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "€";
            // 
            // tbComissao
            // 
            this.tbComissao.Location = new System.Drawing.Point(11, 80);
            this.tbComissao.Name = "tbComissao";
            this.tbComissao.Size = new System.Drawing.Size(100, 20);
            this.tbComissao.TabIndex = 3;
            // 
            // tbValorBase
            // 
            this.tbValorBase.Location = new System.Drawing.Point(11, 36);
            this.tbValorBase.Name = "tbValorBase";
            this.tbValorBase.Size = new System.Drawing.Size(100, 20);
            this.tbValorBase.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Comissão";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Valor base (mês)";
            // 
            // gbVendaArrenda
            // 
            this.gbVendaArrenda.Controls.Add(this.rbVendavel);
            this.gbVendaArrenda.Controls.Add(this.rbArrendavel);
            this.gbVendaArrenda.Location = new System.Drawing.Point(77, 313);
            this.gbVendaArrenda.Name = "gbVendaArrenda";
            this.gbVendaArrenda.Size = new System.Drawing.Size(169, 44);
            this.gbVendaArrenda.TabIndex = 31;
            this.gbVendaArrenda.TabStop = false;
            // 
            // rbVendavel
            // 
            this.rbVendavel.AutoSize = true;
            this.rbVendavel.Location = new System.Drawing.Point(93, 19);
            this.rbVendavel.Name = "rbVendavel";
            this.rbVendavel.Size = new System.Drawing.Size(70, 17);
            this.rbVendavel.TabIndex = 30;
            this.rbVendavel.TabStop = true;
            this.rbVendavel.Text = "Vendavel";
            this.rbVendavel.UseVisualStyleBackColor = true;
            this.rbVendavel.CheckedChanged += new System.EventHandler(this.rbVendavel_CheckedChanged);
            // 
            // rbArrendavel
            // 
            this.rbArrendavel.AutoSize = true;
            this.rbArrendavel.Location = new System.Drawing.Point(10, 19);
            this.rbArrendavel.Name = "rbArrendavel";
            this.rbArrendavel.Size = new System.Drawing.Size(76, 17);
            this.rbArrendavel.TabIndex = 29;
            this.rbArrendavel.TabStop = true;
            this.rbArrendavel.Text = "Arrendavel";
            this.rbArrendavel.UseVisualStyleBackColor = true;
            this.rbArrendavel.CheckedChanged += new System.EventHandler(this.rbArrendavel_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Proprietario:";
            // 
            // cbProprietario
            // 
            this.cbProprietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProprietario.FormattingEnabled = true;
            this.cbProprietario.Location = new System.Drawing.Point(77, 286);
            this.cbProprietario.Name = "cbProprietario";
            this.cbProprietario.Size = new System.Drawing.Size(241, 21);
            this.cbProprietario.TabIndex = 25;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Moradia",
            "Moradia com jardim",
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
            // FormCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 691);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCasa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCasa_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCasas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAssoalhadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea)).EndInit();
            this.gbVendavel.ResumeLayout(false);
            this.gbVendavel.PerformLayout();
            this.gbArrendamento.ResumeLayout(false);
            this.gbArrendamento.PerformLayout();
            this.gbVendaArrenda.ResumeLayout(false);
            this.gbVendaArrenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGVCasas;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPesquisaCasas;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.TextBox tbPesquisarCasas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbAndar;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.GroupBox gbVendavel;
        private System.Windows.Forms.GroupBox gbArrendamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbVendaArrenda;
        private System.Windows.Forms.RadioButton rbVendavel;
        private System.Windows.Forms.RadioButton rbArrendavel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbProprietario;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbComissaoBase;
        private System.Windows.Forms.TextBox tbValorBaseNegocial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbComissao;
        private System.Windows.Forms.TextBox tbValorBase;
        private System.Windows.Forms.Button btNova;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btGerarLimpezas;
        private System.Windows.Forms.Button btVerVenda;
        private System.Windows.Forms.Button btVerCriarArrendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.NumericUpDown tbAssoalhadas;
        private System.Windows.Forms.NumericUpDown tbWc;
        private System.Windows.Forms.NumericUpDown tbPisos;
        private System.Windows.Forms.NumericUpDown tbArea;
        private System.Windows.Forms.TextBox tbNumero;
    }
}