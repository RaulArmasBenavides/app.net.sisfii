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
    
    public partial class organizadores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public organizadores()
        {
            this.actividades = new HashSet<actividades>();
        }
    
        public int idorganiz { get; set; }
        public string codigo { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fec_registro { get; set; }
        public Nullable<int> iddetorg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actividades> actividades { get; set; }
        public virtual detalle_organizadores detalle_organizadores { get; set; }
    }
}
