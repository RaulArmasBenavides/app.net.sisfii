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
    
    public partial class usp_listar_actividades_all_Result
    {
        public int idactividad { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string rol_creacion { get; set; }
        public string estado { get; set; }
        public Nullable<int> idlistaeq { get; set; }
        public Nullable<int> idorganiz { get; set; }
        public Nullable<int> idsala { get; set; }
        public Nullable<System.DateTime> fec_inicio { get; set; }
        public Nullable<System.DateTime> fec_fin { get; set; }
        public string responsable { get; set; }
        public string lugar { get; set; }
        public string justificacion { get; set; }
        public string objetivos { get; set; }
        public Nullable<int> horas { get; set; }
        public Nullable<int> idambiente { get; set; }
        public Nullable<int> idsede { get; set; }
        public string inscripcion { get; set; }
        public string certificado { get; set; }
        public string tipoevento { get; set; }
    }
}
