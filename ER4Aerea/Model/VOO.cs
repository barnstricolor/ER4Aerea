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
    
    public partial class VOO
    {
        public VOO()
        {
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public System.DateTime DAT_PARTIDA { get; set; }
        public System.DateTime DAT_CHEGADA { get; set; }
        public decimal ID_AVIAO { get; set; }
        public decimal ID_VOO { get; set; }
        public decimal VAL_PRECO { get; set; }
        public decimal ID_ORIGEM { get; set; }
        public decimal ID_DESTINO { get; set; }
        public string FLG_PROMOCAO { get; set; }
    
        public virtual AVIAO AVIAO { get; set; }
        public virtual CIDADE CIDADE { get; set; }
        public virtual CIDADE CIDADE1 { get; set; }
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}