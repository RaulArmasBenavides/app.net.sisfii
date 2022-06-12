using CapaNegocios.Controller;
using System;
using System.Windows.Forms;

namespace CapaDatos.View
{
    public partial class FrmListaCursos : Form
    {   //variables globales 
        int x;
        // INSTANCIAR OBJETO DE LA CLASE ProductoBll
        CursoBll obj = new CursoBll();
        public FrmListaCursos(int i)
        {
            InitializeComponent();
            x = i;        
        }

        private void FrmListaCursos_Load(object sender, EventArgs e)
        {
            ReporteListaCursos(x);
        }

        private void ReporteListaCursos(int x)
        {

            dgvListaCursos.DataSource = obj.CursoListar(x);
        }


    }
}
