//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ER4Aerea.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public string NOM_USUARIO { get; set; }
        public string NOM_SENHA { get; set; }
        public string NOM_LOGIN { get; set; }
        public decimal NUM_CPF { get; set; }
        public string NOM_ENDERECO { get; set; }
        public decimal NUM_ENDERE { get; set; }
        public decimal ID_CIDADE { get; set; }
    
        public virtual CIDADE CIDADE { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}