using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Limpeza
    {
        public Limpeza(DateTime data, CasaVendavel casa)
        {
            Data = data;
            Casa = casa ?? throw new ArgumentNullException(nameof(casa));
            this.Servico = new HashSet<Servico>();
        }

        public Limpeza(DateTime data, CasaArrendavel casa)
        {
            Data = data;
            Casa = casa ?? throw new ArgumentNullException(nameof(casa));
            this.Servico = new HashSet<Servico>();
        }

        public double getTotalValue()
        {
            double valor = 0;
            for(int i = 0; i < this.Servico.Count; i++)
            {
                valor += this.Servico.ToList()[i].Valor * this.Servico.ToList()[i].Unidades;
            }
            return valor;
        }

        public override string ToString()
        {
            return this.getTotalValue() + "€ a" + this.Data + ")";
        }

        public String getFatura()
        {
            String fatura = "Nome: " + this.Casa.Proprietario.Nome + "\r\n" +
                            "NIF: " + this.Casa.Proprietario.NIF + "\r\n\r\n" +
                            "Dados sobre a casa: \r\n" +
                            "\tLocalidade: " + this.Casa.Localidade + "\r\n" +
                            "\tRua: " + this.Casa.Rua + "\r\n" +
                            "\tNumero: " + this.Casa.Numero + "\r\n" +
                            "\tAndar: " + this.Casa.Andar + "\r\n\r\n" +
                            "Serviçoes de limpeza: \r\n";
            List<Servico> servicos = Servico.ToList();
            for (int i = 0; i < servicos.Count; i++)
            {
                fatura += "\t" + servicos[i].ToString() + "\r\n";
            }

            fatura += "Total: " + getTotalValue() + "€";

            return fatura;
        }

    }
}
