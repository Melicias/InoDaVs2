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
    public partial class FormCasa : Form
    {
        private FormInicial formInicial;
        private Model1Container mc;

        public FormCasa(FormInicial formInicial)
        {
            InitializeComponent();
            this.cbPesquisaCasas.SelectedIndex = 0;
            this.formInicial = formInicial;
            mc = new Model1Container();

            dataGVCasas.AutoGenerateColumns = false;
            dataGVCasas.DataSource = mc.Casas.ToList();

            List<Casa> m = mc.Casas.ToList();

            this.cbTipo.SelectedIndex = 0;
            this.cbProprietario.DataSource = mc.Clientes.ToArray();

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (this.tbPesquisarCasas.Text.Length > 0)
            {
                try
                {
                    Model1Container myMoc = new Model1Container();
                    switch (cbPesquisaCasas.SelectedIndex)
                    {
                        case 0:
                            //Id
                            (from casa in myMoc.Casas
                             where casa.IdCasa.ToString().Contains(tbPesquisarCasas.Text.ToUpper())
                             orderby casa.IdCasa
                             select casa
                            ).ToList();
                            break;
                        case 1:
                            //Localidade
                            (from casa in myMoc.Casas
                             where casa.Localidade.ToUpper().Contains(tbPesquisarCasas.Text.ToUpper())
                             orderby casa.IdCasa
                             select casa
                            ).ToList();
                            break;
                        case 2:
                            //Rua
                            (from casa in myMoc.Casas
                             where casa.Rua.ToUpper().Contains(tbPesquisarCasas.Text.ToUpper())
                             orderby casa.IdCasa
                             select casa
                            ).ToList();
                            break;
                        case 3:
                            //Nome do proprietario
                            (from casa in myMoc.Casas
                             where casa.Proprietario.Nome.ToUpper().Contains(tbPesquisarCasas.Text.ToUpper())
                             orderby casa.IdCasa
                             select casa
                            ).ToList();
                            break;
                        case 4:
                            //Tipo
                            (from casa in myMoc.Casas
                             where casa.Tipo.ToUpper().Contains(tbPesquisarCasas.Text.ToUpper())
                             orderby casa.IdCasa
                             select casa
                            ).ToList();
                            break;
                    }

                    dataGVCasas.DataSource = myMoc.Clientes.Local.ToList();

                }
                catch (FormatException)
                {
                    //contacto tem letras
                    MessageBox.Show("Erro na conversão de algo!", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                dataGVCasas.DataSource = mc.Clientes.ToList();
            }
        }

        private void btNova_Click(object sender, EventArgs e)
        {
            cleanTB();
            this.btGuardar.Text = "Guardar";
            this.btGuardar.Enabled = true;

        }

        private void cleanTB()
        {
            this.btGuardar.Text = "Guardar";
            this.tbId.Text = "";
            this.tbLocalidade.Text = "";
            this.tbRua.Text = "";
            this.tbNumero.Text = "";
            this.tbAndar.Text = "";
            this.tbArea.Value = 1;
            this.tbAssoalhadas.Value = 0;
            this.tbWc.Value = 0;
            this.tbPisos.Value = 0;
            this.cbTipo.SelectedIndex = 0;
            if(this.cbProprietario.Items.Count > 0)
                this.cbProprietario.SelectedIndex = 0;
            this.tbValorBase.Text = "";
            this.tbComissao.Text = "";
            this.tbValorBaseNegocial.Text = "";
            this.tbComissaoBase.Text = "";
            this.btGerarLimpezas.Text = "Gerir Limpezas";
            this.btGerarLimpezas.Enabled = false;
            this.rbArrendavel.Checked = false;
            this.rbVendavel.Checked = false;
            this.gbVendaArrenda.Enabled = true;
            this.cbProprietario.Enabled = true;
        }

        private void rbArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbArrendavel.Checked)
            {
                this.gbArrendamento.Enabled = true;
            }
            else
            {
                this.gbArrendamento.Enabled = false;
            }
        }

        private void rbVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbVendavel.Checked)
            {
                this.gbVendavel.Enabled = true;
            }
            else
            {
                this.gbVendavel.Enabled = false;
            }
        }

        private void FormCasa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formInicial.Show();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(this.btGuardar.Text == "Guardar")
            {
                //guardar nova casa
                if (checkCasa())
                {
                    if (this.rbVendavel.Checked)
                    {
                        CasaVendavel c = new CasaVendavel(Convert.ToDouble(this.tbValorBaseNegocial.Text), Convert.ToDouble(this.tbComissaoBase.Text), this.tbLocalidade.Text, this.tbRua.Text, this.tbNumero.Text, this.tbAndar.Text, this.tbArea.Text, Convert.ToInt32(this.tbAssoalhadas.Value), Convert.ToInt32(this.tbWc.Value), Convert.ToInt32(this.tbPisos.Value), (String)this.cbTipo.SelectedItem, ((Cliente)this.cbProprietario.SelectedItem));
                        mc.Casas.Add(c);
                    }
                    else
                    {
                        //if (this.rbArrendavel.Checked)
                        //{
                            CasaArrendavel c = new CasaArrendavel(Convert.ToDouble(this.tbValorBase.Text), Convert.ToDouble(this.tbComissao.Text), this.tbLocalidade.Text, this.tbRua.Text, this.tbNumero.Text, this.tbAndar.Text, this.tbArea.Text, Convert.ToInt32(this.tbAssoalhadas.Value), Convert.ToInt32(this.tbWc.Value), Convert.ToInt32(this.tbPisos.Value), (String)this.cbTipo.SelectedItem, ((Cliente)this.cbProprietario.SelectedItem));
                            mc.Casas.Add(c);
                        //}
                    }

                    mc.SaveChanges();
                    dataGVCasas.DataSource = mc.Casas.ToList();
                    cleanTB();
                }
            }
            else
            {
                //editar a casa
                if (checkCasa())
                {
                    //CODIGO PARA 
                    if (this.rbVendavel.Checked)
                    {
                        //CasaVendavel c = (CasaVendavel)Convert.ChangeType(dataGVCasas.CurrentRow.DataBoundItem, typeof(CasaVendavel));
                        CasaVendavel c = (CasaVendavel)dataGVCasas.CurrentRow.DataBoundItem;

                        c.Localidade = this.tbLocalidade.Text;
                        c.Rua = this.tbRua.Text;
                        c.Numero = this.tbNumero.Text;
                        c.Andar = this.tbAndar.Text;
                        c.Area = this.tbArea.Text;
                        c.NumeroAssoalhada = Convert.ToInt32(this.tbAssoalhadas.Value);
                        c.NumeroWC = Convert.ToInt32(this.tbWc.Value);
                        c.NumeroPisos = Convert.ToInt32(this.tbPisos.Value);
                        c.Tipo = (String)this.cbTipo.SelectedItem;
                        c.ValorBaseVenda = Convert.ToDouble(this.tbValorBaseNegocial.Text);
                        c.ValorComissao = Convert.ToDouble(this.tbComissaoBase.Text);
                    }
                    else
                    {
                        CasaArrendavel c = (CasaArrendavel)dataGVCasas.CurrentRow.DataBoundItem;

                        c.Localidade = this.tbLocalidade.Text;
                        c.Rua = this.tbRua.Text;
                        c.Numero = this.tbNumero.Text;
                        c.Andar = this.tbAndar.Text;
                        c.Area = this.tbArea.Text;
                        c.NumeroAssoalhada = Convert.ToInt32(this.tbAssoalhadas.Value);
                        c.NumeroWC = Convert.ToInt32(this.tbWc.Value);
                        c.NumeroPisos = Convert.ToInt32(this.tbPisos.Value);
                        c.Tipo = (String)this.cbTipo.SelectedItem;
                        c.ValorBaseMes = Convert.ToDouble(this.tbValorBase.Text);
                        c.Comissao = Convert.ToDouble(this.tbComissao.Text);
                    }

                    mc.SaveChanges();
                    dataGVCasas.DataSource = mc.Casas.ToList();
                    cleanTB();
                }
            }
        }

        private Boolean checkCasa()
        {
            if(this.tbLocalidade.Text.Length >= 4)
            {
                if(this.tbRua.Text.Length >= 3)
                {
                    if (!this.tbNumero.Text.Equals(""))
                    {
                        if (!this.tbAndar.Text.Equals(""))
                        {
                            if (this.cbProprietario.Items.Count > 0) 
                            {
                                if (this.rbVendavel.Checked)
                                {
                                    if (!this.tbValorBaseNegocial.Text.Equals(""))
                                    {
                                        if (!this.tbComissaoBase.Text.Equals(""))
                                        {
                                            try
                                            {
                                                double valorbasenegocial = Convert.ToDouble(this.tbValorBaseNegocial.Text);
                                                double comissaoBase = Convert.ToDouble(this.tbComissaoBase.Text);
                                                return true;
                                            }
                                            catch (FormatException)
                                            {
                                                //erro de formatacao
                                                MessageBox.Show("Erro na formatacao dos numeros", "ERRO", MessageBoxButtons.OKCancel);
                                            }
                                        }
                                        else
                                        {
                                            //comissao base null
                                            MessageBox.Show("O campo comissao base esta null", "ERRO", MessageBoxButtons.OKCancel);
                                        }
                                    }
                                    else
                                    {
                                        //valor base negocial null
                                        MessageBox.Show("O campo base negocial esta null", "ERRO", MessageBoxButtons.OKCancel);
                                    }
                                }
                                else
                                {
                                    if (this.rbArrendavel.Checked)
                                    {
                                        if (!this.tbValorBase.Text.Equals(""))
                                        {
                                            if (!this.tbComissao.Text.Equals(""))
                                            {
                                                try
                                                {
                                                    double valorbase = Convert.ToDouble(this.tbValorBase.Text);
                                                    double comissao = Convert.ToDouble(this.tbComissao.Text);
                                                    return true;
                                                }
                                                catch (FormatException)
                                                {
                                                    //erro de formatacao
                                                    MessageBox.Show("Houve um erro a formatar os numeros", "ERRO", MessageBoxButtons.OKCancel);
                                                }
                                            }
                                            else
                                            {
                                                //comissao base null
                                                MessageBox.Show("A campo comissao esta null", "ERRO", MessageBoxButtons.OKCancel);
                                            }
                                        }
                                        else
                                        {
                                            //valor base negocial null
                                            MessageBox.Show("O valor base negocial esta null", "ERRO", MessageBoxButtons.OKCancel);
                                        }
                                    }
                                    else
                                    {
                                        //valor base negocial null
                                        MessageBox.Show("Tem de selecionar se a casa esta a venda ou a arrendar", "ERRO", MessageBoxButtons.OKCancel);
                                    }
                                }
                            }
                            else
                            {
                                //cb de proprietarios vazio
                                MessageBox.Show("O contacto tem letras", "ERRO", MessageBoxButtons.OKCancel);
                            }
                        }
                        else
                        {
                            //andar vazio
                            MessageBox.Show("O campo andar não pode estar vazio", "ERRO", MessageBoxButtons.OKCancel);
                        }
                    }
                    else {
                        //Numero vazio
                        MessageBox.Show("O campo Numero não pode estar vazio", "ERRO", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    //rua com menos de 3 carateres
                    MessageBox.Show("O campo rua tem de ter no minimo 3 carateres", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                //localidade com menos de 4 carateres
                MessageBox.Show("O campo localidade tem de ter no minimo 4 carateres", "ERRO", MessageBoxButtons.OKCancel);
            }
            return false;
        }

        private void dataGVCasas_Click(object sender, EventArgs e)
        {
            if (dataGVCasas.SelectedRows.Count > 0)
            {
                cleanTB();

                Object obj = dataGVCasas.CurrentRow.DataBoundItem;

                Type tipo = obj.GetType();
                if (tipo.BaseType.Equals(typeof(CasaVendavel)))
                {
                    CasaVendavel c = (CasaVendavel)dataGVCasas.CurrentRow.DataBoundItem;

                    this.rbVendavel.Checked = true;
                    this.tbValorBaseNegocial.Text = c.ValorBaseVenda + "";
                    this.tbComissaoBase.Text = c.ValorComissao + "";

                    this.btGuardar.Text = "Editar";
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
                    this.cbProprietario.SelectedItem = c.Proprietario;
                }
                else
                {
                    CasaArrendavel c = (CasaArrendavel)dataGVCasas.CurrentRow.DataBoundItem;

                    this.rbArrendavel.Checked = true;
                    this.tbValorBase.Text = c.ValorBaseMes + "";
                    this.tbComissao.Text = c.Comissao + "";

                    this.btGuardar.Text = "Editar";
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
                    this.cbProprietario.SelectedItem = c.Proprietario;
                }
                this.gbVendaArrenda.Enabled = false;
                this.cbProprietario.Enabled = false;

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGVCasas.SelectedRows.Count > 0)
            {
                Object obj = dataGVCasas.CurrentRow.DataBoundItem;

                Type tipo = obj.GetType();
                if (tipo.BaseType.Equals(typeof(CasaVendavel)))
                {
                    CasaVendavel c = (CasaVendavel)dataGVCasas.CurrentRow.DataBoundItem;
                    mc.Casas.Remove(c);
                }
                else
                {
                    CasaArrendavel c = (CasaArrendavel)dataGVCasas.CurrentRow.DataBoundItem;
                    mc.Casas.Remove(c);
                }
                mc.SaveChanges();
                dataGVCasas.DataSource = mc.Casas.ToList();
                cleanTB();
            }
        }
    }
}
