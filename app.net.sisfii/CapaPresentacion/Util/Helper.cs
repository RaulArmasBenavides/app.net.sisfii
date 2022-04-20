using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Util
{
    public class Helper
    {

        public static string CompletarCeros(string psTexto, int piLong)
        {
            int iLongTexto = psTexto.ToString().Trim().Length;

            if ((iLongTexto > 0) && (iLongTexto < piLong))
                return psTexto.PadLeft(piLong, '0');
            else
                return psTexto.ToString().Trim();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static string ObtenerRutaTemporalUsuario()
        {
            return Environment.ExpandEnvironmentVariables("%temp%\\");
        }

        public static string ObtenerRutaTemporalWindows()
        {
            return Environment.ExpandEnvironmentVariables("%systemroot%\\TEMP\\");
        }


        public static string FormatoFecha(string psFecha_mdy)
        {   // OBJETIVO : Modificar el formato de una fecha de MM/DD/YYYY a DD/MM/YYYY o viceversa
            //SOLICITA  : psFecha_mdy = Fecha a formatear
            //RETORNA   : Fecha formateada

            if (psFecha_mdy.Equals(""))
            {
                return "";
            }
            else
            {
                return psFecha_mdy.Substring(3, 2) + "/" + psFecha_mdy.Substring(0, 2) + "/" + psFecha_mdy.Substring(6, 4);
            }
        }

        public static string FormatoFecha2(string psFecha_mdy)
        {   // OBJETIVO : Modificar el formato de una fecha de MM/DD/YYYY a DD/MM/YYYY o viceversa
            //SOLICITA  : psFecha_mdy = Fecha a formatear
            //RETORNA   : Fecha formateada

            if (psFecha_mdy.Equals(""))
            {
                return "";
            }
            else
            {
                return psFecha_mdy.Substring(3, 2) + "-" + psFecha_mdy.Substring(0, 2) + "-" + psFecha_mdy.Substring(6, 4);
            }
        }


        public static string convertFormatDateToStringTiempo(string fechaCadena)
        {
            try
            {
                DateTime fechaDate = DateTime.Parse(fechaCadena);
                return fechaDate.ToString("dd/MM/yyyy HH:mm");
            }
            catch (Exception)
            {
                return "Error al convertir fecha";
            }
        }

        public static string convertFormatDateToString(string fechaCadena)
        {
            try
            {
                DateTime fechaDate = DateTime.Parse(fechaCadena);
                return fechaDate.ToString("dd/MM/yyyy");
            }
            catch (Exception)
            {
                return "Error al convertir fecha";
            }
        }

        public static string ObtenerDireccionIP()
        {
            string sHost = Dns.GetHostName();

            IPHostEntry IPs = Dns.GetHostEntry(sHost);
            IPAddress[] Direcciones = IPs.AddressList;

            return Direcciones[0].ToString();
        }

        public static void PosicionarCombo(ComboBox pcCombo, string psValor)
        {
            bool bExisteItem = false;
            if (psValor.Trim().Equals(""))
            {
                pcCombo.SelectedValue = "";
                return;
            }
            for (int iIndex = 0; iIndex < pcCombo.Items.Count; iIndex++)
            {
                pcCombo.SelectedIndex = iIndex;
                if (pcCombo.SelectedValue.ToString().Trim() == psValor.Trim())
                {
                    bExisteItem = true;
                    break;
                }
            }
            if (!bExisteItem)
            {
                pcCombo.SelectedValue = "";
            }
        }

        public static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static int GetIDProcces(string nameProcces)
        {
            try
            {
                Process[] asProccess = Process.GetProcessesByName(nameProcces);
                foreach (Process pProccess in asProccess)
                {
                    if (pProccess.MainWindowTitle == "") { return pProccess.Id; }
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }

        public static void PrintToExcel(DataGridView dgv )
        {
            dgv.SelectAll();
            DataObject copydata = dgv.GetClipboardContent();
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
    }
}
