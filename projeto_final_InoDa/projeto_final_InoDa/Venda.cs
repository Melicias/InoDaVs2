//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projeto_final_InoDa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venda
    {
        public int IdVenda { get; set; }
        public System.DateTime DataVenda { get; set; }
        public double ValorNegociado { get; set; }
        public double ComissaoNegociada { get; set; }
    
        public virtual Cliente Comprador { get; set; }
        public virtual CasaVendavel CasaVendavel { get; set; }
    }
}
