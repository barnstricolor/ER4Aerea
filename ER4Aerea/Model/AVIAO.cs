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
    
    public partial class AVIAO
    {
        public AVIAO()
        {
            this.VOO = new HashSet<VOO>();
        }
    
        public decimal ID_AVIAO { get; set; }
        public decimal QTD_ASSENTO { get; set; }
        public string NOM_MODELO { get; set; }
    
        public virtual ICollection<VOO> VOO { get; set; }
    }
}