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
    
    public partial class RESERVA
    {
        public decimal ID_RESERVA { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public decimal ID_USUARIO { get; set; }
        public decimal VAL_PRECO { get; set; }
        public decimal QTD_ASSENTO { get; set; }
        public decimal ID_VOO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual VOO VOO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}