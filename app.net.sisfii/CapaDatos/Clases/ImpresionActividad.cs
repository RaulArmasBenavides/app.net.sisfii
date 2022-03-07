using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Clases
{
    public class ImpresionActividad
    {
        public ImpresionActividad()
        {
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
            this.fecha_inicio = string.Empty;
            this.fecha_fin = string.Empty;
            this.Justificacion = string.Empty;
            this.Objetivos = string.Empty;
            this.Resposable = string.Empty;
        }

        public string Nombre { get; set; }

        public string fecha_inicio { get; set; }

        public string fecha_fin { get; set; }

        public string cant_efectivas { get; set; }

        public string Resposable { get; set; }

        public string Descripcion { get; set; }

        public string Objetivos  { get; set; }

        public string Justificacion { get; set; }

    }
}
