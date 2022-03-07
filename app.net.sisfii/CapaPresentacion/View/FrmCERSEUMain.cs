using CapaDatos.View;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmCERSEUMain : Form
    {
        public FrmCERSEUMain()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmListaCursos f = new FrmListaCursos(2);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaCursos);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.Close();
            }

            //f.MdiParent = this;
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmListaCursos f = new FrmListaCursos(3);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaCursos);

            if (fm != null)
            {

                //si la instancia existe la pongo en primer plano
                fm.Close();
            }

            //f.MdiParent = this;
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmListaCursos f = new FrmListaCursos(1);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaCursos);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.Close();
            }

            //f.MdiParent = this;
            f.Show();
        }
    }
}
