using CapaDatos.EF;
using appcongreso.Utils;
using CapaDatos.Clases;
using CapaNegocios.Controller;
using CapaPresentacion.Util;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmCursosCERSEU : Form
    {
        bdgenericEntities c = new bdgenericEntities();
        CursoBll obj = new CursoBll();
        public FrmCursosCERSEU()
        {
            InitializeComponent();
        }

        #region Events 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar este Curso ?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                    listaCursos(0);
                }
            }
        }

        private void FrmCursosCERSEU_Load(object sender, EventArgs e)
        {
            LimpiaControles();

            cboProgramas.SelectedIndex = 0;

            listaCursos(0);
        }

        private void LblBuscar_Click_1(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void LblLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
        #endregion



        private void listaCursos(int cod)
        {
            dgvCursos.DataSource = obj.CursoListar(cod);
        }

        private bool Validaciones(string tipo_accion)
        {
           // string mensaje = "";

            if (tipo_accion.Equals("C"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("El campo Nombre del Curso es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            if (tipo_accion.Equals("U"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el Curso que desea actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else
            if (tipo_accion.Equals("D"))
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el Curso que desea desactivar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }


        private void procesar(int opcion)
        {
            string msg = "";
            try
            {
                switch (opcion)
                {
                    case 1:
                        obj.CursoAdicionar(leerCurso());
                        msg = "Curso registrado con éxito";
                        break;
                    case 2:
                        obj.CursoActualizar(leerCurso());
                        msg = "Curso actualizado con éxito";
                        break;
                    case 3:
                        obj.CursoEliminar(leerCurso());
                        msg = "Curso eliminado con éxito";
                        break;
                    case 4:
                        consultarCurso();
                        return;
                }
                MessageBox.Show(msg, "exito");
                listaCursos(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }


        private usp_listar_curso_all_Result leerCurso()
        {
            
            var pro = new usp_listar_curso_all_Result();

            pro.nombreCurso = txtNombre.Text;
            pro.tipo = cboTipo.SelectedIndex.ToString();
            //if (!txtidCurso.Text.Equals(""))
            //    pro.idCurso = Convert.ToInt32(txtidCurso.Text.ToString());
            //pro.Nombre = txtNombre.Text.Trim();
            //pro.Procesador = txtProcesador.Text.Trim();
            //pro.RAM = txtRAM.Text.Trim();//cboTipoSala.Text;
            //pro.SO = txtSO.Text.Trim();//(int)npdCapacidad.Value;
            ////pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //pro.TarjetaMadre = txtTM.Text.Trim();// "SGIT";

            return pro;
        }

        private void consultarCurso()
        {
            // var pro = obj.CursoBuscar(leerNombreCursoBuscar());
            //var pro = obj.CursoBuscar_Nombre(leerNombreCursoBuscar());
            //if (pro != null)
            //{
                
            //    txtidCurso.Text = pro.idCurso.ToString();
            //    txtNombre.Text = pro.Nombre;
            //    txtProcesador.Text = pro.Procesador;
            //    txtSO.Text = pro.SO;
            //    txtTM.Text = pro.TarjetaMadre;
            //    txtRAM.Text = pro.RAM;
            //    //txtPrecio.Text = pro.PrecioUnidad.ToString();
            //    //cboProveedor.SelectedValue = pro.IdProveedor;
            //    //cboCategoria.SelectedValue = pro.IdCategoría;
            //    //numCantidad.Value = (int)pro.UnidadesEnExistencia;

            //    //activan los botones 
            //    btnAgregar.Enabled = false;
            //    btnActualizar.Enabled = true;
            //    btnEliminar.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("Este Curso no se encuentra registrada o no existe", "Aviso");
            //    txtNombre.SelectAll();
            //    txtNombre.Focus();
            //}
        }

        usp_listar_curso_all_Result leerNombreCursoBuscar()
        {
            usp_listar_curso_all_Result pro = new usp_listar_curso_all_Result();
            
            pro.nombreCurso = txtNombre.Text.Trim();
           // pro.idCurso = Convert.ToInt32(txtidCurso.Text);
            return pro;
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        private void LimpiaControles()
        {
            txtidCurso.Clear();
            txtNombre.Clear();
            //txtProcesador.Clear();
            //txtRAM.Clear();
            //txtSO.Clear();
            //txtTM.Clear();

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;    
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar este Curso?", "",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("U"))
                {
                    procesar(2);
                    LimpiaControles();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea desactivar este Curso?", "",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("D"))
                {
                    procesar(3);
                    LimpiaControles();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvCursos.Rows.Count > 0)
                {
                    Helper.PrintToExcel(dgvCursos);
                }
                else
                {
                    MessageBox.Show("No existen detalles para exportar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel " + ex.Message, "error");
            }
        }


        private void ImprimirActividadGeneral(ImpresionCurso l)
        {

            DocumentoElectronico pdf = Imprimir(l);
            string ruta;
            //openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;
            //saveFileDialog1.
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    txtRuta.Text = openFileDialog.FileName;
            //}
            Stream myStream;
            //StreamWriter writer; 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = pdf.nombreArchivo;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllBytes(saveFileDialog1.FileName, pdf.archivoFisico);
                // Code to write the stream goes here.
                //myStream.Close();
                MessageBox.Show("Se imprimió el documento en pdf");
                Process.Start(saveFileDialog1.FileName);

            }
        }

        public DocumentoElectronico Imprimir(ImpresionCurso l)
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                DocumentoElectronico newdoc = new DocumentoElectronico();
                byte[] archivoFisivo = null;

                pdf = ImprimirContenido(l);
               string nombre = "Curso" + l.Nombre + ".pdf";
                string rutaArchivoMuestra = Path.GetTempPath() + nombre;

                pdf.Save(rutaArchivoMuestra);
                archivoFisivo = File.ReadAllBytes(rutaArchivoMuestra);

                //if (File.Exists(rutaArchivoMuestra))
                //{
                //    File.Delete(rutaArchivoMuestra);

                //}
                newdoc.nombreArchivo = nombre;
                newdoc.archivoFisico = archivoFisivo;
                return newdoc;
            }
            catch (Exception ex)
            {
                throw ex; 
            }

            finally
            {

            }
        }

        private PdfDocument ImprimirContenido(ImpresionCurso l)
        {

            #region Declaración de variables

            //Documento a imprimir
            PdfDocument Documento = new PdfDocument();

            //tipo de fuentes 
            XFont xfontregular2 = new XFont("Arial", 11, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularVerdana = new XFont("Arial", 6, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularTahoma = new XFont("Tahoma", 6, XFontStyle.Regular); /*MS021020_20200521_KAB*/
            XFont xfontregularTimes = new XFont("Times New Roman", 6, XFontStyle.Regular);
            XFont xfontregular = new XFont("Arial", 6.5, XFontStyle.Regular);  /*MS021020_20200521_KAB*/
            XFont xfontCuadroTitulo = new XFont("Tahoma", 8, XFontStyle.BoldItalic);
            XFont xfonttitulo = new XFont("Arial", 14, XFontStyle.Bold); //negrita 
            XFont xfontcabecera = new XFont("Arial", 11, XFontStyle.Bold); //negrita 
            XStringFormat format = new XStringFormat();

            //marco 
            XRect rect = new XRect(40, 120 - 10, 790, 310);

            PdfPage page = new PdfPage();
            PdfPage page2 = new PdfPage();
            XGraphics Gfx;
            XGraphics GfxPiePagina;
            int margenIzquierdo;
            Double ImporteTotal;
            int margenSuperior;
            int margenSuperiorCabeceraDetalle;
            int espaciohorizontal;
            int margenSuperiorPie;
            int ancholineaMotivo;
            int ancholinea;
            int altura;
            double cantidadLineaDetalle;
            string Motivo = string.Empty;
            bool salto = false;
            #endregion

            //configuración de la página 
            page = Documento.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Landscape;
            Gfx = XGraphics.FromPdfPage(page);
            page.Size = PdfSharp.PageSize.A4; // tamaño del papel
            format.LineAlignment = XLineAlignment.Center;
            ancholinea = 44;
            ancholineaMotivo = 60; //MS021020_20200502_RMAB
            margenIzquierdo = 40;
            margenSuperior = 40;
            margenSuperiorCabeceraDetalle = 120;
            margenSuperiorPie = 480;
            espaciohorizontal = 30;
            altura = 22;

            //logo1
            //logoUNMSM = CapaPresentacion.Properties.Resources.UNMSM;
            //logoIcacit= CapaPresentacion.Properties.Resources.icacit;
            //logoFII = CapaPresentacion.Properties.Resources.fii;
            //MemoryStream strm = new MemoryStream();
            //logoFII.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);

            //XImage xlogo = XImage.FromStream(strm);
            //double x = (250 - xlogo.PixelWidth * 72 / xlogo.HorizontalResolution) / 2;

            //Gfx.DrawImage(xlogo, x, 40);

            //logoFII.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            //xlogo = XImage.FromStream(strm);
            //Gfx.DrawImage(xlogo, x + 40, 40);

            //logoIcacit.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            //xlogo = XImage.FromStream(strm);
            //Gfx.DrawImage(xlogo, x + 40, 40);


            //Gfx.DrawRectangle(XPens.Gray, rect);
            Gfx.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 24 * espaciohorizontal - 40, margenSuperior - 25));
            Gfx.DrawString("REPORTE DE LISTA DE CursoS N° " + l.Nombre, xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior));
            Gfx.DrawString("Facultad de Ingeniería Industrial ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura));
            Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura));
            //Gfx.DrawString("Descripción de la actividad ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 2));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 2));
            //Gfx.DrawString("Fecha de inicio ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 3));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 3));
            //Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 4));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 4));
            //Gfx.DrawString("Fecha de fin ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 5));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 5));
            //Gfx.DrawString("Responsable ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura * 6));
            //Gfx.DrawString(" : ", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 270, margenSuperior + altura * 6));

            //foreach (DataRow dr in l.dtListaCursos.Rows)
            //{
            //    Gfx.DrawString(Convert.ToString(dr["Nombre"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 5, margenSuperiorCabeceraDetalle + altura));


            //    Gfx.DrawString(Convert.ToString(dr["SO"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + espaciohorizontal, margenSuperiorCabeceraDetalle + altura));
            //    Gfx.DrawString(Convert.ToString(dr["Procesador"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 3 * espaciohorizontal, margenSuperiorCabeceraDetalle + altura));

            //    altura = altura + 10;

            //}

            return Documento;
        }

        private void cboProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiaControles();
            listaCursos(Convert.ToInt32(cboProgramas.SelectedIndex));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
