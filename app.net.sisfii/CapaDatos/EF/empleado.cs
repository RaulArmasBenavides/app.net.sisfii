//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appcongreso.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        public string IdEmpleado { get; set; }
        public string Rol { get; set; }
        public string ApePatEmpleado { get; set; }
        public string ApeMatEmpleado { get; set; }
        public string NomEmpleado { get; set; }
        public string Cargo { get; set; }
        public string DirEmpleado { get; set; }
        public string TelEmpleado { get; set; }
        public string EmailEmpleado { get; set; }
        public System.DateTime Fecha_ini { get; set; }
        public string Estado { get; set; }
        public Nullable<int> idusuario { get; set; }
    
        public virtual usuarios usuarios { get; set; }
    }
}
