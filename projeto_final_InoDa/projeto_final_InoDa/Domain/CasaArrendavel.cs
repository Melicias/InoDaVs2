using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class CasaArrendavel : Casa
    {
        public CasaArrendavel(double valorBaseMes, double comissao, string localidade, string rua, string numero, string andar, string area, int numeroAssoalhada, int numeroWC, int numeroPisos, string tipo, Cliente proprietario) : base(localidade, rua, numero, andar, area, numeroAssoalhada, numeroWC, numeroPisos, tipo, proprietario)
        {
            ValorBaseMes = valorBaseMes;
            Comissao = comissao;
            this.Arrendamento = new HashSet<Arrendamento>();
        }

    }
}
