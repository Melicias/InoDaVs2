using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_final_InoDa
{
    public partial class FormLimpezas : Form
    {
        CasaArrendavel casaArrendavel;
        CasaVendavel casaVendavel;
        FormCasa formcasa;
        Model1Container mc;

        public FormLimpezas(CasaVendavel casa, FormCasa fc, Model1Container mc)
        {
            InitializeComponent();
            this.casaVendavel = casa;
            this.formcasa = fc;
            this.lbLimpezas.DataSource = casa.Limpeza.ToList();
            this.mc = mc;
            this.cbServico.SelectedIndex = 0;
            this.lbIdLocalidadeRua.Text = "Id: " + casa.IdCasa + " - " + casa.Localidade + ", " + casa.Rua;
        }

        public FormLimpezas(CasaArrendavel casa, FormCasa fc, Model1Container mc)
        {
            InitializeComponent();
            this.casaArrendavel = casa;
            this.formcasa = fc;
            this.lbLimpezas.DataSource = casa.Limpeza.ToList();
            this.mc = mc;
            this.cbServico.SelectedIndex = 0;
            this.lbIdLocalidadeRua.Text = "Id: " + casa.IdCasa + " - " + casa.Localidade + ", " + casa.Rua;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(this.casaVendavel != null)
            {
                Limpeza l = new Limpeza(this.dtpFatura.Value, this.casaVendavel);
                this.mc.Limpezas.Add(l);
                mc.SaveChanges();
                this.casaVendavel = (CasaVendavel)this.mc.Casas.Find(this.casaVendavel.IdCasa);
                this.lbLimpezas.DataSource = this.casaVendavel.Limpeza.ToList();
            }
            else
            {
                Limpeza l = new Limpeza(this.dtpFatura.Value, this.casaArrendavel);
                this.mc.Limpezas.Add(l);
                mc.SaveChanges();
                this.casaArrendavel = (CasaArrendavel)this.mc.Casas.Find(this.casaArrendavel.IdCasa);
                this.lbLimpezas.DataSource = this.casaArrendavel.Limpeza.ToList();
            }
        }

        private void cbServiço_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbServico.SelectedIndex)
            {
                case 0:
                    this.lbValorUnitario.Text = "10";
                    break;
                case 1:
                    this.lbValorUnitario.Text = "15";
                    break;
                case 2:
                    this.lbValorUnitario.Text = "25";
                    break;
                case 3:
                    this.lbValorUnitario.Text = "30";
                    break;
                case 4:
                    this.lbValorUnitario.Text = "55";
                    break;
                case 5:
                    this.lbValorUnitario.Text = "70";
                    break;
                case 6:
                    this.lbValorUnitario.Text = "100";
                    break;
                case 7:
                    this.lbValorUnitario.Text = "130";
                    break;

            }
        }

        private void FormLimpezas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formcasa.Enabled = true;
            this.formcasa.loadGerirLimpezasButton();
        }

        private void lbLimpezas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lbLimpezas.SelectedIndex != -1)
            {
                this.lbServicos.DataSource = ((Limpeza)this.lbLimpezas.SelectedItem).Servico.ToList();
                this.btnInserir.Enabled = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (this.lbLimpezas.SelectedIndex != -1)
            {
                Servico s = new Servico((String)this.cbServico.SelectedItem, Convert.ToDouble(this.lbValorUnitario.Text), Convert.ToDouble(this.nupQuantidade.Value), ((Limpeza)this.lbLimpezas.SelectedItem));
                this.mc.Servicos.Add(s);
                this.mc.SaveChanges();
                this.lbServicos.DataSource = ((Limpeza)this.lbLimpezas.SelectedItem).Servico.ToList();
                this.nupQuantidade.Value = 1;
                int index = this.lbLimpezas.SelectedIndex;
                if (this.casaVendavel != null)
                {
                    this.casaVendavel = (CasaVendavel)this.mc.Casas.Find(this.casaVendavel.IdCasa);
                    this.lbLimpezas.DataSource = this.casaVendavel.Limpeza.ToList();
                }
                else
                {
                    this.casaArrendavel = (CasaArrendavel)this.mc.Casas.Find(this.casaArrendavel.IdCasa);
                    this.lbLimpezas.DataSource = this.casaArrendavel.Limpeza.ToList();
                }
                this.lbLimpezas.SelectedIndex = index;
            }
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            if (this.lbLimpezas.SelectedIndex != -1)
            {
                Limpeza limpeza = (Limpeza)this.lbLimpezas.SelectedItem;
                if (limpeza.Servico.Count != 0)
                {
                    saveFileDialog1.FileName = "fatura_" + limpeza.Casa.Proprietario.NIF + "_" + limpeza.Casa.Proprietario.Nome + ".txt";
                    if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                        return;
                    StreamWriter ficheiro = new StreamWriter(saveFileDialog1.FileName, false);
                    String fatura = limpeza.getFatura();
                    ficheiro.Write(fatura);
                    ficheiro.Close();
                }
                else
                {
                    //nao existe servicoes, nao vale a pena passar fatura
                    MessageBox.Show("Antes de emitir uma fatura, deverá ter adquirido algum serviço.", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
