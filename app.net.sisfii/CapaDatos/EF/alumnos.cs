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
    
    public partial class alumnos
    {
        public int idalumno { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre { get; set; }
        public string DNI { get; set; }
        public string codigo { get; set; }
        public string telefono { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string carrera { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }
        public string tipo_alumno { get; set; }
        public Nullable<int> idusuario { get; set; }
        public Nullable<System.DateTime> fec_nac { get; set; }
        public string correo_2 { get; set; }
    
        public virtual usuarios usuarios { get; set; }
    }
}
