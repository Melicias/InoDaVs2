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
    public partial class FormVendaCasa : Form
    {

        private CasaVendavel casa;
        private FormCasa formcasa;
        private Model1Container mc;


        public FormVendaCasa(CasaVendavel casa,FormCasa formcasa, Model1Container mc)
        {
            InitializeComponent();
            this.casa = casa;
            this.formcasa = formcasa;
            this.mc = mc;

            this.lbProprietario.Text = casa.Proprietario.ToString();
            this.lbValor.Text = casa.ValorBaseVenda + "€";
            this.lbComissao.Text = casa.ValorComissao + "€";

            if (casa.Venda != null)
            {
                this.lbEstado.Text = "Vendido";
                this.nupValorNegociado.Value = Convert.ToDecimal(casa.Venda.ValorNegociado);
                this.nupValorComissao.Value = Convert.ToDecimal(casa.Venda.ComissaoNegociada);
                this.dateTimePicker1.Value = casa.Venda.DataVenda;
                this.cbComprador.Items.Add(casa.Venda.Comprador);
                this.cbComprador.SelectedItem = casa.Venda.Comprador;
                this.gbDadosVenda.Enabled = false;
            }
            else
            {
                this.lbEstado.Text = "Para venda";
                this.nupValorNegociado.Value = Convert.ToDecimal(casa.ValorBaseVenda);
                this.nupValorComissao.Value = Convert.ToDecimal(casa.ValorComissao);
                List<Cliente> l = mc.Clientes.ToList();
                l.Remove(casa.Proprietario);
                this.cbComprador.DataSource = l;
                if(this.cbComprador.Items.Count == 0)
                    this.btEfetivarVenda.Enabled = false;
            }
            
        }

        private void btEfetivarVenda_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Venda v = new Venda(this.dateTimePicker1.Value, Convert.ToDouble(this.nupValorNegociado.Value), Convert.ToDouble(this.nupValorComissao.Value),(Cliente)this.cbComprador.SelectedItem,casa);
                mc.Vendas.Add(v);
                this.casa.Proprietario = (Cliente)this.cbComprador.SelectedItem;
                mc.SaveChanges();
                this.gbDadosVenda.Enabled = false;
            }
        }

        public Boolean checkFields()
        {
            if(this.nupValorComissao.Value != 0)
            {
                if(this.nupValorNegociado.Value != 0)
                {
                    if(((Cliente)this.cbComprador.SelectedItem).IdCliente != casa.Proprietario.IdCliente)
                    {
                        return true;
                    }
                    else
                    {
                        //o cliente e o msm, tem de trocar
                        MessageBox.Show("O cliente a comprar não pode ser o mesmo que está a vender!", "ERRO", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    //valor negociado a 0
                    MessageBox.Show("O valor negociado tem de ser diferente de 0!", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                //valor da comissao 0
                MessageBox.Show("O valor de comissão tem de ser diferente 0!", "ERRO", MessageBoxButtons.OKCancel);
            }
            return false;
        }

        private void FormVendaCasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.formcasa.Show();
            this.formcasa.Enabled = true;
        }
    }
}
