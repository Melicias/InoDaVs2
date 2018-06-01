using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Servico
    {
        public Servico(string descricao, double valor, double unidades, Limpeza limpeza)
        {
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Valor = valor;
            Unidades = unidades;
            Limpeza = limpeza ?? throw new ArgumentNullException(nameof(limpeza));
        }

        public Servico()
        {

        }


        public override string ToString()
        {
            return (Valor*Unidades) + "€ " + Unidades + "x[" + Valor + "€ -" + Descricao + "]";
        }

    }
}
