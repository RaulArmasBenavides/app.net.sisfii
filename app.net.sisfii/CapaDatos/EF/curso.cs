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
    
    public partial class curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curso()
        {
            this.cursoProgramado = new HashSet<cursoProgramado>();
        }
    
        public int idcurso { get; set; }
        public int IdTarifa { get; set; }
        public string malla { get; set; }
        public string nombreCurso { get; set; }
        public string estado { get; set; }
        public Nullable<int> idCiclo { get; set; }
        public string tipo { get; set; }
    
        public virtual ciclo ciclo { get; set; }
        public virtual tarifa tarifa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cursoProgramado> cursoProgramado { get; set; }
    }
}
