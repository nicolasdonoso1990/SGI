//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pago_seguro
    {
        public int cod_seguro { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> monto { get; set; }
    
        public virtual Seguro Seguros { get; set; }
    }
}
