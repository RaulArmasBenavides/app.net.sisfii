using CapaNegocios.Controller;
using System;
using System.Windows.Forms;

namespace CapaPresentacion.View.ERP
{
    public partial class FrmPrecios : Form
    {
        CostosImprentaBll _imprenta;
        public FrmPrecios(CostosImprentaBll c )
        {
            InitializeComponent();
            _imprenta = c;
        }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {
            BloquearCampos();
            LeerValoresPrecios();
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizarPrecios_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea actualizar los precios ? (Nota: Solo se actualizarán los precios modificados)", "",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                actualizaCampos();
            }
        }


        private void actualizaCampos()
        {
            try
            {
                if (!txtAlceN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_ALCE, txtAlceN.Text);
                if (!txtBestColorN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_BESTCOLOR , txtBestColorN.Text);
                if (!txtCoreRefiN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_CORTEREFILADO, txtCoreRefiN.Text);
                if (!txtDoblezN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_DOBLEZ, txtDoblezN.Text);
                if (!txtEncoladoN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_ENCOLADO, txtEncoladoN.Text);
                if (!txtManejoarchivN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_MANEJOARCHIVO, txtManejoarchivN.Text);
                if (!txtMovilidadN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_MOVILIDAD , txtMovilidadN.Text);
                if (!txtTintaN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_TINTA, txtTintaN.Text);
                if (!txtCIFN.Text.Equals("")) _imprenta.PrecioActualizar(Constantes.Constantes.CTE_CIF , txtCIFN.Text);
                MessageBox.Show("Se actualizaron los precios fijos con éxito", "Éxito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }


        private void LeerValoresPrecios()
        {
            try
            {
                txtAlce.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_ALCE).ToString();
                txtBestColor.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_BESTCOLOR).ToString();
                txtCoreRefi.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_CORTEREFILADO).ToString();
                txtDoblez.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_DOBLEZ).ToString();
                txtEncolado.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_ENCOLADO).ToString();
                txtManejoarchiv.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_MANEJOARCHIVO).ToString();
                txtMovilidad.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_MOVILIDAD).ToString();
                txtTinta.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_TINTA).ToString();
                txtCIF.Text = _imprenta.getValorParametro(Constantes.Constantes.CTE_CIF).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }

        private void txtCoreRefi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
