using CapaNegocios.Controller;
using System;
using System.Windows.Forms;

namespace CapaDatos.View
{
    public partial class FrmParticipantes : Form
    {   //variables globales 
        int x;
        // INSTANCIAR OBJETO DE LA CLASE ProductoBll
        AlumnoBll obj = new AlumnoBll();
        public FrmParticipantes(int i)
        {
            InitializeComponent();
            x = i;
                     
        }

   

        private void FrmParticipantes_Load(object sender, EventArgs e)
        {
            listaParticipantes(x);
        }

        private void listaParticipantes(int x)
        {
            if(x==1)
            {
                dgvParticipantes.DataSource = obj.AlumnoListar();
            }
            else
            if(x==2)
            {
                //dgvParticipantes.DataSource = obj.ParticipantePonenteListar();
            }
            else
            if(x==3)
            {
               // dgvParticipantes.DataSource = obj.ParticipanteProfesionalListar();
            }
            
        }

        private void dgvParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
