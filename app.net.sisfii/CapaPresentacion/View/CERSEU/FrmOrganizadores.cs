using CapaDatos.EF;
using appcongreso.Utils;
using CapaDatos.Clases;
using CapaNegocios.Controller;
using CapaPresentacion.Util;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.View.CERSEU
{
    public partial class FrmOrganizadores : Form
    {

        private DataSet Ds = new DataSet();
        private DataTable dtDetalle;
        private DataRow drw;
        public int lista_organizadores = 0;
        // INSTANCIAR OBJETO DE LA CLASE ProductoBll capa de negocio 
        OrganizadoresBll obj = new OrganizadoresBll();
        AlumnoBll partici = new AlumnoBll();

        public FrmOrganizadores()
        {
            InitializeComponent();

        }


        #region Eventos 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarRegistroCelda())
            {
                AgregarFila();
                if (dgvOrganizadores.Rows.Count > 0)
                    btnEliminar.Enabled = true;
                else
                    btnEliminar.Enabled = false;
                //LimpiaControles();
            }
            else
            {
                MessageBox.Show("Este organizador ya ha sido registrado en la grilla");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFila();
            dgvOrganizadores.DataSource = dtDetalle;
            if (dgvOrganizadores.Rows.Count > 0)
                btnEliminar.Enabled = true;
            else
                btnEliminar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error al registrar la lista de organizadores " + ex.Message, "error");
            }

        }



        private bool Validaciones(string tipo_accion)
        {
            // string mensaje = "";
            //// Calculate the interval between the two dates.
            //TimeSpan interval = dtpicker2.Value.Date- dtpicker1.Value.Date;


            if (tipo_accion.Equals("C"))
            {
               
                if (dgvOrganizadores.Rows.Count <= 0)
                {
                    MessageBox.Show("Esta actividad no tiene organizadores, por favor ingrese al menos un organizador para poder grabar el evento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            if (tipo_accion.Equals("U"))
            {
                
            }

            else
            if (tipo_accion.Equals("D"))
            {
     
            }

            return true;
        }


        private void cboDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboAlumno(cboDNI.Text);
        }


        private void LlenarComboAlumno( string dni)
        {
            usp_listar_alumnos_all_Result lista = partici.ParticipanteBuscar(new usp_listar_alumnos_all_Result() { DNI = dni });
            if (lista != null)
            {
                txtnombre.Text = lista.nombre;
                txtapmaterno.Text = lista.ap_materno;
                txtappaterno.Text = lista.ap_paterno;
            }
            else { }
        }


        private void cboDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LlenarComboAlumno(cboDNI.Text);
            }
        }

        #endregion



      

        public bool validarRegistroCelda()
        {
            if(dgvOrganizadores.Rows.Count>0)
            {
                foreach (DataGridViewRow Row in dgvOrganizadores.Rows)
                {
                    string Valor = Convert.ToString(Row.Cells["DNI"].Value);

                    if (Valor == cboDNI.Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ConfigurarTabla()
        {
            dtDetalle = Ds.Tables.Add();
            dtDetalle.Columns.Add("DNI");
            dtDetalle.Columns.Add("ap_paterno");
            dtDetalle.Columns.Add("ap_materno");
            dtDetalle.Columns.Add("codigo");
            //dtDetalle.Columns.Add("SubTotal");
            dgvOrganizadores.DataSource = dtDetalle;
        }
        private void AgregarFila()
        {
            drw = dtDetalle.NewRow();
            drw["DNI"] = cboDNI.Text;
            drw["ap_paterno"] = txtappaterno.Text;
            drw["ap_materno"] = txtapmaterno.Text;
            drw["codigo"] = txtCodigo.Text;
            dtDetalle.Rows.Add(drw);
            //drw["SubTotal"] = txtSubTotal.Text;
            //total += decimal.Parse(txtSubTotal.Text);
            //txtTotal.Text = total.ToString();
            dgvOrganizadores.DataSource = dtDetalle;
        }



        private void EliminarFila()
        {

            if (dtDetalle.Rows.Count > 0)
            {
               // total -= decimal.Parse((string)dgvAsistencias.Rows[dgvAsistencias.CurrentCell.RowIndex].Cells[4].Value);
                //txtTotal.Text = total.ToString("N2");
                dtDetalle.Rows.RemoveAt(dgvOrganizadores.CurrentCell.RowIndex);
            }
            else
            {
                MessageBox.Show("Usted debe seleccionar una fila");
            }
        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {

            procesar(4);
            foreach (DataGridViewRow rowGrid in dgvOrganizadores.Rows)
            {
                DataRow row = dtDetalle.NewRow();
                //row["NombreCol"] = Convert.ToDouble(rowGrid.Cells[0].Value);
                row["DNI"] = rowGrid.Cells[0].Value.ToString();
                row["ap_paterno"] = rowGrid.Cells[1].Value.ToString();
                row["ap_materno"] = rowGrid.Cells[2].Value.ToString();
                row["codigo"] = txtCodigo.Text;
                dtDetalle.Rows.Add(row);
            }
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();

        }

        private void LimpiaControles()
        {
            txtCodigo.Text = "";
            txtnombre.Text = "";
            txtEstado.Text = "";
            txtapmaterno.Text = "";
            txtappaterno.Text = "";
            dgvOrganizadores.DataSource = null;
            dgvOrganizadores.Refresh();
            if(dtDetalle!= null)
            dtDetalle.Clear();

            btnGrabar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void procesar(int opcion)
        {
            string msg = "";
            List<usp_organizadores_oficial_Result> items = new List<usp_organizadores_oficial_Result>();
            try
            {
                int idgenerado = 0;
                switch (opcion)
                {
                    case 1:
                        // obj.AsistenciaAdicionar(leerAsistencia());
                        foreach (DataGridViewRow dr in dgvOrganizadores.Rows)
                        {
                            usp_organizadores_oficial_Result res = new usp_organizadores_oficial_Result();
                            res.DNI = Convert.ToString(dr.Cells["DNI"].Value);
                            res.ap_paterno = Convert.ToString(dr.Cells["ap_paterno"].Value);
                            res.ap_materno = Convert.ToString(dr.Cells["ap_materno"].Value);
                            res.codigo = txtCodigo.Text.Trim();
                            items.Add(res);
                        }
                        idgenerado = obj.RegistrarListaOrganizadores(txtCodigo.Text.Trim(), items, true);
                        txtidListaAsistencias.Text = idgenerado.ToString();
                        msg = "Lista de organizadores registrado con éxito";
                        break;
                    case 2:
                        // obj.AsistenciaActualizar(leerAsistencia());
                        // ACTUALIZAR
                        foreach (DataGridViewRow dr in dgvOrganizadores.Rows)
                        {
                            usp_organizadores_oficial_Result res = new usp_organizadores_oficial_Result();
                            res.DNI = Convert.ToString(dr.Cells["DNI"].Value);
                            res.ap_paterno = Convert.ToString(dr.Cells["ap_paterno"].Value);
                            res.ap_materno = Convert.ToString(dr.Cells["ap_materno"].Value);
                            res.codigo = txtCodigo.Text.Trim();
                            items.Add(res);
                        }
                        obj.RegistrarListaOrganizadores(txtCodigo.Text.Trim(), items, false);
                        msg = "Lista de organizadores actualizado con éxito";
                        break;
                    case 3:
                      //  obj.AsistenciaEliminar(leerAsistencia());
                        msg = "Lista de organizadores anulada con éxito";
                        break;
                    case 4:
                        consultarAsistencia();
                        return;
                }
                MessageBox.Show(msg, "Éxito");
                //listaAsistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }


        private void consultarAsistencia()
        {

            //cabecera 
            //txtidListaEquipo.Text = pro.ElementAt(0).idEquipo.ToString();

          

            //detalle 
            List<usp_organizadores_oficial_Result> pro = obj.ListaOrganizadoresCodigo(leerListaAsistencia());
            txtidListaAsistencias.Text = pro[0].idorganiz.ToString();
            if (pro != null)
            {

           
                dgvOrganizadores.DataSource = pro;
                //txtPrecio.Text = pro.PrecioUnidad.ToString();
                //cboProveedor.SelectedValue = pro.IdProveedor;
                //cboCategoria.SelectedValue = pro.IdCategoría;
                //numCantidad.Value = (int)pro.UnidadesEnExistencia;

                btnGrabar.Enabled = false;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Esta lista de asistencia no se encuentra registrada o no existe. Por favor ingrese un código válido", "Aviso");
                txtCodigo.SelectAll();
                txtCodigo.Focus();
            }
        }

        private usp_organizadores_oficial_Result leerListaAsistencia()
        {
            var pro = new usp_organizadores_oficial_Result();
            pro.codigo = txtCodigo.Text.Trim();
            //if (!txtidAsistencia.Text.Equals(""))
            //    pro.idAsistencia = Convert.ToInt32(txtidAsistencia.Text.ToString());
            //pro.nombre = txtdescrip.Text;
            //pro.ubicacion = txtubi.Text;
            //pro.tipo_Asistencia = cboTipoAsistencia.Text;
            //pro.capacidad = (int)npdCapacidad.Value;
            //pro.IdCategoría = (int)cboCategoria.SelectedValue;
            //pro.rol_creacion = "SGIT";
            return pro;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImpresionListaOrganizadores l = new ImpresionListaOrganizadores();
            ImprimirActividadGeneral(l);
        }

        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            //txtidListaAsistencias.Text = "1";
            LimpiaControles();
            ConfigurarTabla();
            CargarCombos();
        }

        void CargarCombos()
        {
            List<usp_listar_alumnos_all_Result> lista = partici.AlumnoListar();
            cboDNI.DataSource = lista;//oVenta.ClienteListar();
            cboDNI.DisplayMember = "DNI";
            cboDNI.ValueMember = "DNI";

            //foreach(usp_participantes_listar_all_Result item in lista)
            //{

            //}
            // cboEmpleado.DataSource = oVenta.EmpleadoListar();
            //cboEmpleado.DisplayMember = "Empleado";
            //cboEmpleado.ValueMember = "IdEmpleado";

            //cboProducto.DataSource = oVenta.ProductoListar();
            //cboProducto.DisplayMember = "NombreProducto";
            //cboProducto.ValueMember = "IdProducto";
        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvOrganizadores.Rows.Count > 0)
                {
                    //ImpresionExcel();
                    Helper.PrintToExcel(dgvOrganizadores);
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

        private void ImpresionExcel()
        {
            dgvOrganizadores.SelectAll();
            DataObject copydata = dgvOrganizadores.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            procesar(2);
        }


        private void ImprimirActividadGeneral(ImpresionListaOrganizadores l)
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

        public DocumentoElectronico Imprimir(ImpresionListaOrganizadores l)
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                DocumentoElectronico newdoc = new DocumentoElectronico();
                string etapa = "INICIAL";
                byte[] archivoFisivo = null;

                pdf = ImprimirContenido(l);
                string nombre = "LISTAEQ" + l.codigo + ".pdf";
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
                throw ex; //LogOC.LogErrorEx(ex.Message + "[Business][" + MethodBase.GetCurrentMethod().Name + "]", Tipos.TipoErrorControlado.Grave);
            }

            finally
            {

            }
        }

        private PdfDocument ImprimirContenido(ImpresionListaOrganizadores l)
        {

            #region Declaración de variables

            //Documento a imprimir
            PdfDocument Documento = new PdfDocument();
            Image logoUNMSM = null;
            Image logoIcacit = null;
            Image logoFII = null;
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
            #endregion

            //configuración de la página 
            page = Documento.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Landscape;
            Gfx = XGraphics.FromPdfPage(page);
            page.Size = PdfSharp.PageSize.A4; // tamaño del papel
            format.LineAlignment = XLineAlignment.Center;

            //ancholinea = 46;//MS021020_20200812_RMAB
            ancholinea = 44;
            ancholineaMotivo = 60; //MS021020_20200502_RMAB
            int posIni = 0, posFin = 0;
            Double TotalGeneral = 0;
            int lineaRegistros = 0;
            margenIzquierdo = 40;
            margenSuperior = 40;
            margenSuperiorCabeceraDetalle = 120;
            margenSuperiorPie = 480;
            espaciohorizontal = 30;
            altura = 22; //MS021020_20200619_RMA


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
            Gfx.DrawString("REPORTE DE LISTA DE ORGANIZADORES N° " + l.codigo, xfonttitulo, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior));
            Gfx.DrawString("Facultad de Ingeniería Industrial CERSEU", xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 180, margenSuperior + altura));
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

            //foreach (DataRow dr in l.dtListaEquipos.Rows)
            //{
            //    Gfx.DrawString(Convert.ToString(dr["Nombre"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 5, margenSuperiorCabeceraDetalle + altura));


            //    Gfx.DrawString(Convert.ToString(dr["SO"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + espaciohorizontal, margenSuperiorCabeceraDetalle + altura));
            //    Gfx.DrawString(Convert.ToString(dr["Procesador"]), xfontregular2, XBrushes.Black, new XPoint(margenIzquierdo + 3 * espaciohorizontal, margenSuperiorCabeceraDetalle + altura));

            //    altura = altura + 10;

            //}

            return Documento;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

   
    }
}
