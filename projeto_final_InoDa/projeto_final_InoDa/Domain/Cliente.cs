using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Cliente
    {
        public Cliente(string nome, long nif, string morada, long contacto)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            NIF = nif;
            Morada = morada ?? throw new ArgumentNullException(nameof(morada));
            Contacto = contacto;
            this.Casas = new HashSet<Casa>();
            this.Venda = new HashSet<Venda>();
            this.Arrendamento = new HashSet<Arrendamento>();
        }

        public override string ToString()
        {
            return Nome + " (" + NIF + ")";
        }
    }
}
