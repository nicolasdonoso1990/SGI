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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Administrador
    {
        public int IDadmin { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su nombre de usuario", AllowEmptyStrings = false)]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Por favor ingrese su contraseņa", AllowEmptyStrings = false)]
        public string contrasena { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
    }
}
