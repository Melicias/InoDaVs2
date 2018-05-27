using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Casa
    {
        public Casa(string localidade, string rua, string numero, string andar, string area, int numeroAssoalhada, int numeroWC, int numeroPisos, string tipo, Cliente proprietario)
        {
            Localidade = localidade ?? throw new ArgumentNullException(nameof(localidade));
            Rua = rua ?? throw new ArgumentNullException(nameof(rua));
            Numero = numero;
            Andar = andar ?? throw new ArgumentNullException(nameof(andar));
            Area = area ?? throw new ArgumentNullException(nameof(area));
            NumeroAssoalhada = numeroAssoalhada;
            NumeroWC = numeroWC;
            NumeroPisos = numeroPisos;
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Proprietario = proprietario ?? throw new ArgumentNullException(nameof(proprietario));

            this.Limpeza = new HashSet<Limpeza>();
        }

        public override string ToString()
        {
            return Localidade + ", Nr." + Numero + "";
        }
    }
}
