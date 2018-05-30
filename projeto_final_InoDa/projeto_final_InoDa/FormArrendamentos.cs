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
    public partial class FormArrendamentos : Form
    {
        private FormCasa formcasa;
        private CasaArrendavel casa;
        private Model1Container mc;

        public FormArrendamentos(CasaArrendavel casa, FormCasa formcasa, Model1Container mc)
        {
            InitializeComponent();
            this.formcasa = formcasa;
            this.casa = casa;
            this.labelID.Text = casa.IdCasa + "";
            this.labelLocalidade.Text = casa.Localidade;
            this.labelCliente.Text = casa.Proprietario.ToString();

            this.mc = mc;

            List<Cliente> l = mc.Clientes.ToList();
            l.Remove(casa.Proprietario);
            this.cbArrendatário.DataSource = l;
            if (this.cbArrendatário.Items.Count == 0)
                this.btnInserir.Enabled = false;

            this.lbArrendamentos.DataSource = casa.Arrendamento.ToList();

            this.lbArrendamentos.SelectedIndex = -1;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                Arrendamento a = new Arrendamento(this.dtpContrato.Value.Date, Convert.ToInt32(this.nupDuração.Value), this.cbRenovavel.Checked, casa, (Cliente)this.cbArrendatário.SelectedItem);
                this.mc.Arrendamentos.Add(a);
                this.mc.SaveChanges();
                this.lbArrendamentos.DataSource = casa.Arrendamento.ToList();
                this.casa = (CasaArrendavel)mc.Casas.Find(this.casa.IdCasa);
                this.lbArrendamentos.SelectedIndex = -1;
            }
        }

        private Boolean checkFields()
        {
            if (this.cbArrendatário.SelectedItem != null)
            {
                if(((Cliente)this.cbArrendatário.SelectedItem).IdCliente != this.casa.Proprietario.IdCliente)
                {
                    return true;
                }
                else
                {
                    //proprietario é o msm
                    MessageBox.Show("O cliente que irá arrendar a casa não devera ser o mesmo que o dono!!!", "ERRO", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                //lsita de proprietarios esta a null
                MessageBox.Show("Não ha proprietários para se poder concluir!", "ERRO", MessageBoxButtons.OKCancel);
            }
            return false;
        }

        private void FormArrendamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.formcasa.Enabled = true;
            //this.formcasa.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(this.lbArrendamentos.SelectedIndex != -1)
            {
                Arrendamento a = ((Arrendamento)this.lbArrendamentos.SelectedItem);
                this.mc.Arrendamentos.Remove(a);
                this.mc.SaveChanges();
                this.lbArrendamentos.DataSource = casa.Arrendamento.ToList();
                this.casa = (CasaArrendavel)mc.Casas.Find(this.casa.IdCasa);
                this.lbArrendamentos.SelectedIndex = -1;
            }
        }

        private void lbArrendamentos_Click(object sender, EventArgs e)
        {
            /*if(this.lbArrendamentos.SelectedIndex != -1)
            {
                Arrendamento a = ((Arrendamento)this.lbArrendamentos.SelectedItem);
            }*/
        }
    }
}
