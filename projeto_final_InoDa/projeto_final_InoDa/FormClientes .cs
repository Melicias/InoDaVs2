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
    public partial class FormClientes : Form
    {
        private FormInicial formInicial;
        private Model1Container mc;

        public FormClientes(FormInicial formInicial)
        {
            InitializeComponent();
            this.formInicial = formInicial;
            this.cbPesquisaClientes.SelectedIndex = 0;
            mc = new Model1Container();

            dataGVClientes.AutoGenerateColumns = false;
            dataGVClientes.DataSource = mc.Clientes.ToList();
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formInicial.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            putTBEnabled(true);
            clearTB();
            this.btnGuardar.Text = "Guardar";
        }

        private void putTBEnabled(Boolean b)
        {
            this.tbNome.Enabled = b;
            this.tbNIF.Enabled = b;
            this.tbMorada.Enabled = b;
            this.tbContacto.Enabled = b;
            this.btnGuardar.Enabled = b;
        }

        private void clearTB()
        {
            this.tbNome.Text = "";
            this.tbNIF.Text = "";
            this.tbMorada.Text = "";
            this.tbContacto.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar novo cliente
            if (this.btnGuardar.Text.Equals("Guardar"))
            {
                if (checkClient())
                {
                    Cliente cliente = new Cliente(this.tbNome.Text, Convert.ToInt64(this.tbNIF.Text), this.tbMorada.Text, Convert.ToInt64(this.tbContacto.Text));
                    mc.Clientes.Add(cliente);
                    mc.SaveChanges();
                    dataGVClientes.AutoGenerateColumns = false;
                    dataGVClientes.DataSource = mc.Clientes.ToList();
                    clearTB();
                    putTBEnabled(false);
                }
                
            }
            //Editar cliente selecionado
            else
            {
                if (checkClient())
                {
                    
                    Cliente c = (Cliente)dataGVClientes.CurrentRow.DataBoundItem;
                    c.Nome = this.tbNome.Text;
                    c.NIF = Convert.ToInt64(this.tbNIF.Text);
                    c.Morada = this.tbMorada.Text;
                    c.Contacto = Convert.ToInt64(this.tbContacto.Text);
                    mc.SaveChanges();
                    dataGVClientes.AutoGenerateColumns = false;
                    dataGVClientes.DataSource = mc.Clientes.ToList();
                    clearTB();
                    putTBEnabled(false);
                    this.btnGuardar.Text = "Guardar";
                }
            }
        }

        private Boolean checkClient()
        {
            if (this.tbNome.Text.Length >= 3)
            {
                if (this.tbNIF.Text.Length == 9)
                {
                    try
                    {
                        long nif = Convert.ToInt64(this.tbNIF.Text);
                        if (this.tbMorada.Text.Length >= 10)
                        {
                            if (this.tbContacto.Text.Length == 9)
                            {
                                try
                                {
                                    long contacto = Convert.ToInt64(this.tbContacto.Text);

                                    return true;
                                }
                                catch (FormatException)
                                {
                                    //contacto tem letras
                                    MessageBox.Show("O contacto tem letras", "ERRO", MessageBoxButtons.OKCancel);
                                }
                                catch (ArgumentNullException)
                                {
                                    //Algum campo esta a null | impossivel de acontecer
                                    MessageBox.Show("Campos null", "ERRO", MessageBoxButtons.OKCancel);
                                }
                            }
                            else
                            {
                                //contacto com mais ou menos de 9 digitos
                                MessageBox.Show("O contacto deve ser escrito desta maneira: 91XXXXXXX", "ERRO", MessageBoxButtons.OKCancel);
                            }
                        }
                        else
                        {
                            //Morada n tem tamanho suficiente
                            MessageBox.Show("A morada teve ter no minimo 10 digitos", "ERRO", MessageBoxButtons.OKCancel);
                        }
                    }
                    catch (FormatException)
                    {
                        //NIF tem letras
                        MessageBox.Show("O NIF não está correto, o NIF só têm letras!", "ERRO", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    //NIF pequeno
                    MessageBox.Show("O NIF é demasiado pequeno, deverá ter 9 digitos", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                //nome pequeno
                MessageBox.Show("O nome deverá ter no minimo 3 letras", "My Application", MessageBoxButtons.OKCancel);
            }

            return false;
        }

        private void dataGVClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGVClientes.SelectedRows.Count > 0)
            {
                Cliente c = (Cliente)dataGVClientes.CurrentRow.DataBoundItem;
                putTBEnabled(true);
                this.btnGuardar.Text = "Editar";
                this.tbNome.Text = c.Nome;
                this.tbNIF.Text = c.NIF + "";
                this.tbContacto.Text = c.Contacto + "";
                this.tbMorada.Text = c.Morada;

                this.lbCasas.DataSource = c.Casas.ToList();
                this.lbArrendamentos.DataSource = c.Arrendamento.ToList();
                this.lbVendas.DataSource = c.Venda.ToList();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGVClientes.SelectedRows.Count > 0)
            {
                Cliente c = (Cliente)dataGVClientes.CurrentRow.DataBoundItem;
                mc.Clientes.Remove(c);
                mc.SaveChanges();
                dataGVClientes.AutoGenerateColumns = false;
                dataGVClientes.DataSource = mc.Clientes.ToList();
                clearTB();
                putTBEnabled(false);
                this.btnGuardar.Text = "Guardar";
            }
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (this.tbPesquisarClientes.Text.Length > 0) {
                try
                {
                    Model1Container myMoc = new Model1Container();
                    switch (cbPesquisaClientes.SelectedIndex)
                    {
                        case 0:
                            //nome
                            (from cliente in myMoc.Clientes
                             where cliente.Nome.ToUpper().Contains(tbPesquisarClientes.Text.ToUpper())
                             orderby cliente.Nome
                             select cliente
                            ).ToList();
                            break;
                        case 1:
                            //NIF
                            (from cliente in myMoc.Clientes
                             where cliente.NIF.ToString().Contains(tbPesquisarClientes.Text)
                             orderby cliente.Nome
                             select cliente
                            ).ToList();
                            break;
                        case 2:
                            //Contacto
                            (from cliente in myMoc.Clientes
                             where cliente.Contacto.ToString().Contains(tbPesquisarClientes.Text)
                             orderby cliente.Nome
                             select cliente
                            ).ToList();
                            break;
                    }

                    dataGVClientes.DataSource = myMoc.Clientes.Local.ToList();

                }
                catch (FormatException)
                {
                    //contacto tem letras
                    MessageBox.Show("NIF/Contacto com letras", "ERRO", MessageBoxButtons.OKCancel);
                }
            } else {
                dataGVClientes.AutoGenerateColumns = false;
                dataGVClientes.DataSource = mc.Clientes.ToList();
            }
        }

        private void lbCasas_DoubleClick(object sender, EventArgs e)
        {
            if(this.lbCasas.SelectedIndex != -1)
            {
                Object obj = this.lbCasas.SelectedItem;

                Type tipo = obj.GetType();
                if (tipo.BaseType.Equals(typeof(CasaVendavel)))
                {
                    FormDetalhesCasa form = new FormDetalhesCasa((CasaVendavel)obj,this);
                    form.Show(); // Show FormClientes
                    this.Hide();
                }
                else
                {
                    FormDetalhesCasa form = new FormDetalhesCasa((CasaArrendavel)obj, this);
                    form.Show(); // Show FormClientes
                    this.Hide();
                }
            }
        }
    }
}
