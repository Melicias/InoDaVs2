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
    
    public partial class CasaVendavel : Casa
    {
        public double ValorBaseVenda { get; set; }
        public double ValorComissao { get; set; }
    
        public virtual Venda Venda { get; set; }
    }
}