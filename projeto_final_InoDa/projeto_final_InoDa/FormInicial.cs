using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_final_InoDa
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btGerirClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes(this); // Instantiate a FormClientes object.
            formClientes.Show(); // Show FormClientes
            this.Hide();// Hides the FormInicial instance.
        }

        private void btGerirCasas_Click(object sender, EventArgs e)
        {
            FormCasa formCasa = new FormCasa(this); // Instantiate a FormClientes object.
            formCasa.Show(); // Show FormClientes
            this.Hide();// Hides the FormInicial instance.
        }
    }
}
