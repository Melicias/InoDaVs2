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
            this.btGerirCasas = new System.Windows.Forms.Button();
            this.btGerirClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerirCasas
            // 
            this.btGerirCasas.Location = new System.Drawing.Point(436, 236);
            this.btGerirCasas.Name = "btGerirCasas";
            this.btGerirCasas.Size = new System.Drawing.Size(104, 23);
            this.btGerirCasas.TabIndex = 0;
            this.btGerirCasas.Text = "Gerir Casas";
            this.btGerirCasas.UseVisualStyleBackColor = true;
            this.btGerirCasas.Click += new System.EventHandler(this.btGerirCasas_Click);
            // 
            // btGerirClientes
            // 
            this.btGerirClientes.Location = new System.Drawing.Point(76, 253);
            this.btGerirClientes.Name = "btGerirClientes";
            this.btGerirClientes.Size = new System.Drawing.Size(118, 23);
            this.btGerirClientes.TabIndex = 1;
            this.btGerirClientes.Text = "Gerir clientes";
            this.btGerirClientes.UseVisualStyleBackColor = true;
            this.btGerirClientes.Click += new System.EventHandler(this.btGerirClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGerirClientes);
            this.Controls.Add(this.btGerirCasas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerirCasas;
        private System.Windows.Forms.Button btGerirClientes;
    }
}

