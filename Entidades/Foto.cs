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
    
    public partial class Foto
    {
        public int cod_unidad { get; set; }
        public string ruta_foto { get; set; }
        public int cod_foto { get; set; }
    
        public virtual Unidad Unidades { get; set; }
    }
}
