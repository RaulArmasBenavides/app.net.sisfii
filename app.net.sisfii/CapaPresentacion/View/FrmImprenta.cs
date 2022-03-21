using CapaDatos.EF;
using CapaNegocios.Controller;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    public partial class FrmImprenta : Form
    {
        bdgenericEntities c = new bdgenericEntities();

        // INSTANCIAR OBJETO DE LA CLASE CostosImprentaBll capa de negocio 
        CostosImprentaBll obj = new CostosImprentaBll();
        DataTable dt; 
        public FrmImprenta()
        {
            InitializeComponent();
        }

        #region Events 

        private void FrmImprenta_Load(object sender, EventArgs e)
        {
            LimpiaControles();
            BloquearCampos();
            ConfigurarColumnas();
        }

        private void BloquearCampos()
        {
            try
            {
                txtAlce.Enabled = false;
                txtBestColor.Enabled = false;
                txtCIF.Enabled = false;
                txtCoreRefi.Enabled = false;
                txtDoblez.Enabled = false;
                txtEncolado.Enabled = false;
                txtManejoarchiv.Enabled = false;
                txtTinta.Enabled = false;
                txtMovilidad.Enabled = false;

                txtNroPlacas.Enabled = false;
                txtNroPliegos.Enabled = false;
                txtNroResmas.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar estos costos ?", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                if (Validaciones("C"))
                {
                    procesar(1);
                    LimpiaControles();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea eliminar estos costos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quiere actualizar estos costos ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void LblBuscar_Click(object sender, EventArgs e)
        {
            procesar(4);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCostos.SelectAll();
                DataObject copydata = dgvCostos.GetClipboardContent();
                if (copydata != null) Clipboard.SetDataObject(copydata);
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object miseddata = System.Reflection.Missing.Value;
                xlWbook = xlapp.Workbooks.Add(miseddata);
                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);

                xlsheet.Name = "COSTOS DE IMPRENTA";

                xlsheet.Cells[2,3].Value = "Reporte";
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[4,3];
                xlr.Select();
                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al exportar a Excel " + ex.Message, "error");
            }
        }

        private void LblLimpiar_Click(object sender, EventArgs e)
        {
            LimpiaControles();
        }

        #endregion


        private bool Validaciones(string tipo_accion)
        {
            //string mensaje = "";

            if (tipo_accion.Equals("C"))
            {
                if (txtfiltro.Text.Equals(""))
                {
                    MessageBox.Show("El campo código es obligatorio para ingresar los costos de producción del lote", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //if (txtubi.Text.Equals(""))
                //{
                //    MessageBox.Show("El campo Ubicación es obligatorio", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return false;
                //}
            }
            else
            if (tipo_accion.Equals("U"))
            {
                if (txtfiltro.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el lote que desea actualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            else
            if (tipo_accion.Equals("D"))
            {
                if (txtfiltro.Text.Equals(""))
                {
                    MessageBox.Show("Primero debe consultar el lote que desea anular", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        obj.CostosImprentaAdicionar(leerCostosImprenta(), chkColor.Checked);
                        msg = "Costos registrados con éxito";
                        break;
                    case 2:
                        obj.CostosImprentaActualizar(leerCostosImprenta(), chkColor.Checked);
                        msg = "Costos actualizados con éxito";
                        break;
                    case 3:
                        obj.CostosImprentaEliminar(leerCostosImprenta());
                        msg = "Costos anulados con éxito";
                        break;
                    case 4:
                        consultarCostosImprenta();
                        return;
                }
                MessageBox.Show(msg, "Proceso realizado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private usp_costos_prod_imprenta_datos_Result leerCostosImprenta()
        {
            var pro = new usp_costos_prod_imprenta_datos_Result();
            //if(!txtidsala.Text.Equals(""))
            //pro.idsala = Convert.ToInt32(txtidsala.Text.ToString());
            pro.titulo = txtNombreLibro.Text;
            pro.codigo = txtfiltro.Text.Trim();
            pro.nro_libros = (int)npdLIbros.Value;
            pro.nro_paginas = (int)npdPaginas.Value;
            pro.nro_placas = 100;
            pro.ancho = Convert.ToDecimal(txtAncho.Text);
            pro.largo = Convert.ToDecimal(txtLargo.Text);

            return pro;
        }

        private usp_costos_prod_imprenta_datos_Result leerCostosImprenta2()
        {
            var pro = new usp_costos_prod_imprenta_datos_Result();
            pro.codigo = txtfiltro.Text.Trim();
            return pro;
        }
 
        private usp_costos_prod_imprenta_datos_Result consultarCostosImprenta()
        {
            var pro = obj.CostosImprentaBuscar_Codigo(leerCostosImprenta2());
 
            if (pro != null)
            {
                txtfiltro.Text = pro.codigo;
                txtNombreLibro.Text = pro.titulo;
                txtAlce.Text = pro.alce.ToString();
                txtAncho.Text = pro.ancho.ToString();
                txtLargo.Text = pro.largo.ToString();
                txtManejoarchiv.Text = pro.manejo_archivo.ToString();
                txtTinta.Text = pro.tinta.ToString();
                txtBestColor.Text = pro.best_color.ToString();
                txtDoblez.Text = pro.doblez.ToString();
                txtNroPlacas.Text = pro.nro_placas.ToString();
                txtNroPliegos.Text = pro.nro_pliegos.ToString();
                txtNroResmas.Text = pro.nro_resmas.ToString();
                txtMovilidad.Text = pro.movilidad.ToString();
                txtCoreRefi.Text = pro.corte_refilado.ToString();
                txtEncolado.Text = pro.encolado.ToString();
                npdLIbros.Value = Convert.ToInt32(pro.nro_libros);
                npdPaginas.Value = Convert.ToInt32(pro.nro_paginas);
                txtNombreLibro.Text = pro.titulo.ToString().ToUpper();
                txtTinta.Text = pro.tinta.ToString();
                txtCIF.Text = pro.cif.ToString();
                LblTotal.Text = pro.total.ToString();
                ConfigurarBotones(2);

                SetearDatosGrilla();
            }
            else
            {
                MessageBox.Show("Estos registros de costos no se encuentras activos o no existen.Por favor consultar con el responsable del sistema", "Aviso");
                txtfiltro.SelectAll();
                txtfiltro.Focus();
            }
    
            return pro;
        }

        private void dgvSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiaControles()
        {
            txtfiltro.Text = string.Empty;
            txtNroPlacas.Text = string.Empty;
            txtNroPliegos.Text = string.Empty;
            txtNroResmas.Text = string.Empty;
            txtCIF.Text = string.Empty;
            txtAlce.Text = string.Empty;
            txtBestColor.Text = string.Empty;
            txtCoreRefi.Text = string.Empty;
            txtDoblez.Text = string.Empty;
            txtEncolado.Text = string.Empty;
            txtMovilidad.Text = string.Empty;
            txtManejoarchiv.Text = string.Empty;
            txtTinta.Text = string.Empty;
            txtLargo.Text = string.Empty;
            txtAncho.Text = string.Empty;
            txtNombreLibro.Text = string.Empty;
            txtTinta.Text = string.Empty;
            npdLIbros.Value = 0;
            npdPaginas.Value = 0;
            ConfigurarBotones(1);
            dgvCostos.DataSource = null;
            LblTotal.Text = "0.00";
            ConfigurarColumnas();
            chkColor.Checked = false;

        }

        private void  ConfigurarBotones(int opcion)
        {
            if (opcion ==1 )
            {
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
                btnExcel.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else if (opcion ==2)
            {
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnExcel.Enabled = true;
                btnImprimir.Enabled = true;
            }
          
        }

        private void ConfigurarColumnas()
        {
            dt = new DataTable();
            dt.Columns.Add("concepto");
            dt.Columns.Add("valor");
            dgvCostos.DataSource = dt;
        }
        
        private void SetearDatosGrilla()
        {
            DataRow row = dt.NewRow();
            row["concepto"]= "ALCE";
            row["valor"] = txtAlce.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "DOBLEZ";
            row["valor"] = txtDoblez.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "ENCOLADO";
            row["valor"] = txtEncolado.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "CORTE Y REFINADO";
            row["valor"] = txtCoreRefi.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "MOVILIDAD";
            row["valor"] = txtMovilidad.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "BEST COLOR";
            row["valor"] = txtBestColor.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "MANEJO DE ARCHIVO";
            row["valor"] = txtManejoarchiv.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "CIF";
            row["valor"] = txtCIF.Text;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["concepto"] = "TOTAL";
            row["valor"] = LblTotal.Text;  
            dt.Rows.Add(row);
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            FrmPrecios fr = new FrmPrecios(obj);
            Application.OpenForms.Cast<Form>();
            Form fm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmPrecios);

            if (fm != null)
            {
                //si la instancia existe la pongo en primer plano
                fm.BringToFront();
                return;
            }

            //fr.MdiParent = this;
            fr.Show();
        }
    }
}
