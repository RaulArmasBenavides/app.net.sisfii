//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipo()
        {
            this.detalle_list_equipos = new HashSet<detalle_list_equipos>();
        }
    
        public int idEquipo { get; set; }
        public string Nombre { get; set; }
        public string SO { get; set; }
        public string Procesador { get; set; }
        public string RAM { get; set; }
        public string TarjetaMadre { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_list_equipos> detalle_list_equipos { get; set; }
    }
}
