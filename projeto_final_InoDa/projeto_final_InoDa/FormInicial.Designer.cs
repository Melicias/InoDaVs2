namespace projeto_final_InoDa
{
    partial class FormInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.btGerirCasas = new System.Windows.Forms.Button();
            this.btGerirClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btGerirCasas
            // 
            this.btGerirCasas.BackgroundImage = global::projeto_final_InoDa.Properties.Resources.house_icon;
            this.btGerirCasas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGerirCasas.Location = new System.Drawing.Point(290, 241);
            this.btGerirCasas.Name = "btGerirCasas";
            this.btGerirCasas.Size = new System.Drawing.Size(234, 229);
            this.btGerirCasas.TabIndex = 0;
            this.btGerirCasas.Text = "Gerir Casas";
            this.btGerirCasas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerirCasas.UseVisualStyleBackColor = true;
            this.btGerirCasas.Click += new System.EventHandler(this.btGerirCasas_Click);
            // 
            // btGerirClientes
            // 
            this.btGerirClientes.Image = ((System.Drawing.Image)(resources.GetObject("btGerirClientes.Image")));
            this.btGerirClientes.Location = new System.Drawing.Point(12, 242);
            this.btGerirClientes.Name = "btGerirClientes";
            this.btGerirClientes.Size = new System.Drawing.Size(230, 229);
            this.btGerirClientes.TabIndex = 1;
            this.btGerirClientes.Text = "Gerir clientes";
            this.btGerirClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerirClientes.UseVisualStyleBackColor = true;
            this.btGerirClientes.Click += new System.EventHandler(this.btGerirClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imo DA";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGerirClientes);
            this.Controls.Add(this.btGerirCasas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImoDa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGerirCasas;
        private System.Windows.Forms.Button btGerirClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

