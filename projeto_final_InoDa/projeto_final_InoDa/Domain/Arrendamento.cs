using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Arrendamento
    {
        public Arrendamento( DateTime inicioContrato, int duracaoMeses, bool renovavel, CasaArrendavel casaArrendavel, Cliente cliente)
        {
            InicioContrato = inicioContrato;
            DuracaoMeses = duracaoMeses;
            Renovavel = renovavel;
            CasaArrendavel = casaArrendavel ?? throw new ArgumentNullException(nameof(casaArrendavel));
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }

        public Arrendamento()
        {

        }

        public override string ToString()
        {
            return "Inicio: " + InicioContrato + "  " + DuracaoMeses + "meses Renovável:" + ((Renovavel == false) ? "Não" : "Sim") + " a " + Cliente.ToString();
        }
    }
}
