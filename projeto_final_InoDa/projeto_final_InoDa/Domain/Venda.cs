using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Venda
    {
        public Venda(DateTime dataVenda, double valorNegociado, double comissaoNegociada, Cliente comprador, CasaVendavel casaVendavel)
        {
            DataVenda = dataVenda;
            ValorNegociado = valorNegociado;
            ComissaoNegociada = comissaoNegociada;
            Comprador = comprador ?? throw new ArgumentNullException(nameof(comprador));
            CasaVendavel = casaVendavel ?? throw new ArgumentNullException(nameof(casaVendavel));
        }

        public Venda()
        {

        }

        public override string ToString()
        {
            return CasaVendavel.Localidade + "(" + CasaVendavel.IdCasa + ") a " + DataVenda;
        }
    }
}
