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
    public partial class FormDetalhesCasa : Form
    {
        FormClientes formClientes;

        public FormDetalhesCasa(CasaArrendavel casaArrendavel, FormClientes formClientes)
        {
            InitializeComponent();
            this.formClientes = formClientes;
            initComponents(casaArrendavel);
        }

        public FormDetalhesCasa(CasaVendavel casaVendavel, FormClientes formClientes)
        {
            InitializeComponent();
            this.formClientes = formClientes; 
            initComponents(casaVendavel);
        }

        private void FormDetalhesCasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formClientes.Show();
        }

        public void initComponents(CasaArrendavel c)
        {
            this.tbId.Text = c.IdCasa + "";
            this.tbLocalidade.Text = c.Localidade;
            this.tbRua.Text = c.Rua;
            this.tbNumero.Text = c.Numero;
            this.tbAndar.Text = c.Andar;
            this.tbArea.Value = Convert.ToInt32(c.Area);
            this.tbAssoalhadas.Value = c.NumeroAssoalhada;
            this.tbWc.Value = c.NumeroWC;
            this.tbPisos.Value = c.NumeroPisos;
            this.cbTipo.SelectedItem = c.Tipo;
        }

        public void initComponents(CasaVendavel c)
        {
            this.tbId.Text = c.IdCasa + "";
            this.tbLocalidade.Text = c.Localidade;
            this.tbRua.Text = c.Rua;
            this.tbNumero.Text = c.Numero;
            this.tbAndar.Text = c.Andar;
            this.tbArea.Value = Convert.ToInt32(c.Area);
            this.tbAssoalhadas.Value = c.NumeroAssoalhada;
            this.tbWc.Value = c.NumeroWC;
            this.tbPisos.Value = c.NumeroPisos;
            this.cbTipo.SelectedItem = c.Tipo;
        }
    }
}
