﻿using CapaDatos.View;
using CapaDatos.View.CERSEU;
using CapaPresentacion.View.CERSEU;
using CapaPresentacion.View.ERP;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class Inicio : Form
    {

        public string _user = string.Empty;
        public Inicio(string user)
        {
            _user = user;
            InitializeComponent();
            SetCulture();
        }

        static void SetCulture()
        {
            CultureInfo culturePeru = GetCulture();
            Thread.CurrentThread.CurrentCulture = culturePeru;
            Thread.CurrentThread.CurrentUICulture = culturePeru;
        }

        public static CultureInfo GetCulture()
        {
            CultureInfo culturePeru = new CultureInfo("es-PE", false);
            //culturePeru.NumberFormat.NumberGroupSeparator = ".";
            //culturePeru.NumberFormat.NumberDecimalSeparator = ",";

            //culturePeru = new CultureInfo("es-PE", false);en-US
            //culturePeru.NumberFormat.NumberGroupSeparator = ",";
            //culturePeru.NumberFormat.NumberDecimalSeparator = ".";
            //culturePeru.DateTimeFormat.LongDatePattern = "dd-MM-yyyy hh:mm:ss";
            return culturePeru;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditarUsuario exd = new EditarUsuario(_user);
            exd.MdiParent = this;
            exd.Show();
            /*  Clientes f = new Clientes();
            f.MdiParent = this;
            f.Show();*/
        }

        //private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //   //   Clientes f = new Clientes();
        //   // DataCliente dc = new DataCliente();
        //   // dc.MdiParent = this;
        //   // f.Dispose();
        //   // dc.Show();


        //}

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  Image Foto;
            Candidato cand = new Candidato();
            Camara cam = new Camara("", "" , "", "", "", "", "", 0, "", "", "", "", "", cand);
            
            Foto = cam.Captura.Image;
            Candidato c = new Candidato(Foto, cam, "", "", "", "", "", "", "", -1, "radio4", "", "", "", "");
            c.MdiParent = this;
            c.Show();*/ 
        }

        private void castingToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //  if (Application.Current.Windows.OfType<FrmPonencias>().Count() == 0)
            //  {
            //    Agregar_Vendedor ventana_agregar_vendedor = new Agregar_Vendedor();
            //     ventana_agregar_vendedor.Show();
            //  }

            //EditUsuarioView exd = new EditUsuarioView();
            //exd.MdiParent = this;
            //exd.Show();
        }

        private void verTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //VerCandidatos v = new VerCandidatos();
           // v.MdiParent = this;
           // v.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VerPerfiles vp = new VerPerfiles();
            //vp.MdiParent = this;
            //vp.Show();
        }



        //Mantenedor de Salas
        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSala fr = new FrmSala();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmSala);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
    
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void contratarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ContratarCasting c = new ContratarCasting();
            c.MdiParent = this;
            c.Show();*/
        }

        private void agenteDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Agente a = new Agente();
           // a.MdiParent = this;
           // a.Show();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
            //verCastings v = new verCastings();
           // v.MdiParent = this;
           // v.Show();
        }

        private void agentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRegistroParticipante f = new FrmRegistroParticipante();
            //Application.OpenForms.Cast<Form>();
            //Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmRegistroParticipante);

            //if (fm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    fm.BringToFront();
            //    return;
            //}

            //f.MdiParent = this;
            //f.Show();
        }

        private void clientesActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesActivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
//MostrarClienteReport m = new MostrarClienteReport();
  //          m.MdiParent = this;
    //        m.Show();
        }

        private void clientesInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MostrarClienteInactivoRep m = new MostrarClienteInactivoRep();
           // m.MdiParent = this;
           // m.Show();

        }

        private void candidatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // MostrarCandidatosRep m = new MostrarCandidatosRep();
           // m.MdiParent = this;
           // m.Show();
        }

        private void helpCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, "C://Users//Blutharsch//Documents//Visual Studio 2013//Projects//Casting//AyudaCasting.chm");
            Help.ShowHelp(this, "https://www.icacit.org.pe/web/es/");


        }

        private void agentesDeCastingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ReporteAgente r = new ReporteAgente();
            r.MdiParent = this;
            r.Show();*/
        }

        private void castingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          // CastingRepViewer crv = new CastingRepViewer();
          //  crv.MdiParent = this;
          //  crv.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades f = new FrmActividades();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmActividades);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();

        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stpVer_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(1);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void ponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(2);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void invitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParticipantes f = new FrmParticipantes(3);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmParticipantes);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void visitaNuestraWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "https://campusindustrial.unmsm.edu.pe/moodle/login/index.php");
     
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator6_Click(object sender, EventArgs e)
        {

        }

        private void mantenedorDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo fr = new FrmEquipo();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmEquipo);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrganizadores fr = new FrmOrganizadores();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmOrganizadores);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaEquipos fr = new FrmListaEquipos();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaEquipos);
            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }
            fr.MdiParent = this;
            fr.Show();

        }

        private void editorialEImprentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmImprenta fr = new FrmImprenta();
            //Application.OpenForms.Cast<Form>();
            //Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmImprenta);

            //if (fm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    fm.BringToFront();
            //    return;
            //}

            //fr.MdiParent = this;
            //fr.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSala fr = new FrmSala();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmSala);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo fr = new FrmEquipo();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmEquipo);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void listaDeEquiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaEquipos fr = new FrmListaEquipos();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaEquipos);
            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }
            fr.MdiParent = this;
            fr.Show();
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroParticipante f = new FrmRegistroParticipante();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmRegistroParticipante);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void consultaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActividades f = new FrmActividades();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmActividades);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void reporteActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrganizadores fr = new FrmOrganizadores();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmOrganizadores);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImprenta fr = new FrmImprenta();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmImprenta);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void rectificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectificacion fr = new FrmRectificacion();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmRectificacion);

            if (fm != null)
            {
                fm.BringToFront();
                return;
            }

            fr.MdiParent = this;
            fr.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenedorDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursosCERSEU f = new FrmCursosCERSEU();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCursosCERSEU);

            if (fm != null)
            {
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCERSEUMain f = new FrmCERSEUMain();
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCERSEUMain);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            f.MdiParent = this;
            f.Show();
        }
    }
}
