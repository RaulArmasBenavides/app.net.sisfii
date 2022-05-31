using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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


        public static bool KeySoloAlfabeto(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char)Keys.Back == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool KeySoloAlfabetoDivision(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Divide == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool KeySoloAlfabetoEspacio(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Space == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool KeySoloNumerico(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (Char)Keys.Back == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool KeySoloNumericoDecimal(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Back == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool txtNumerico(KeyPressEventArgs e, string txtControl, bool Condecimales)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((Char)e.KeyChar == (Char)Keys.Back)
                return false;

            if (Char.IsNumber(e.KeyChar) || Char.IsDigit(e.KeyChar) || (Char)e.KeyChar == (Char)wDecimal || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
            {
                if (Condecimales == true && (Char)e.KeyChar == (Char)wDecimal)
                {
                    if (txtControl.ToString().Trim().IndexOf(wDecimal.ToString()) != -1)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
                return true;
        }

        public static bool KeyAlfaNumerico(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Space == e.KeyChar || (Char)(22) == e.KeyChar || e.KeyChar == (Char)22 || e.KeyChar == (Char)24 || e.KeyChar == (Char)3)
                return false;
            else
                return true;
        }

        public static bool KeyAlfaNumericoGuion(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Space == e.KeyChar || (Char)(45) == e.KeyChar || (Char)(95) == e.KeyChar)
                return false;
            else
                return true;
        }

        public static bool KeyAlfaNumericoGuionPunto(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsNumber(e.KeyChar) || (Char)Keys.Back == e.KeyChar || (Char)Keys.Space == e.KeyChar || (Char)(45) == e.KeyChar || (Char)(95) == e.KeyChar || (Char)('.') == e.KeyChar)
                return false;
            else
                return true;
        }


        public static string ObtenerExtensionArchivo(string nombre)
        {
            string ext = "";

            //Si no tiene extensión, regresar NULL
            if (nombre.IndexOf('.') == -1) return null;

            for (int i = nombre.Length - 1, f = 0; i >= f; i--)
            {
                if (nombre[i] != '.')
                    ext = nombre[i] + ext;
                else
                    break;
            }

            return ext.Trim().ToUpper();
        }

        public static DateTime? ConvertirFecha(string fecha)
        {
            DateTime aux;

            if (DateTime.TryParse(fecha, out aux))
                return aux;
            else
                return null;
        }

        public static string CapitalizarTexto(string cadena)
        {
            if (String.IsNullOrEmpty(cadena)) return "";

            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(cadena.ToLower());
        }

        public static DateTime? ParsearFecha(string fecha)
        {
            DateTime aux;

            if (DateTime.TryParse(fecha, out aux)) return aux;

            return null;
        }

        public static int? DifDiasFechas(string fechaIni, string fechaFin)
        {
            int? days_diff = 0;
            if (!String.IsNullOrEmpty(fechaIni) && !String.IsNullOrEmpty(fechaFin))
            {
                DateTime? dt1 = ParsearFecha(fechaIni);
                DateTime? dt2 = ParsearFecha(fechaFin);

                if (dt1 == null) return days_diff;
                if (dt2 == null) return days_diff;

                TimeSpan? ts = (ParsearFecha(fechaFin) - ParsearFecha(fechaIni));

                if (ts == null) return days_diff;

                days_diff = ts.Value.Days;
            }
            return days_diff;
        }

        public static decimal TruncarDigitos(decimal numero, int cantDigitos)
        {
            byte potencia = Convert.ToByte(Math.Pow(10, cantDigitos));
            return (Math.Truncate(numero * potencia) / potencia);
        }

        public static string TruncarDigitosString(decimal numero, int cantDigitos)
        {
            return TruncarDigitos(numero, cantDigitos).ToString("0." + new string('0', cantDigitos));
        }

        public static bool ValidarCorreo(string correo)
        {
            correo = correo.Trim();

            if (!String.IsNullOrEmpty(correo))
            {
                int largo = correo.Length,
                    posArroba = correo.IndexOf('@'),
                    posPunto = 0,
                    longitud = 0;

                string host = null;

                if (posArroba <= 1 || posArroba == largo) return false;

                host = correo.Substring(posArroba);

                posPunto = host.IndexOf('.');
                longitud = host.Length;

                if (posArroba <= 1 || posPunto == longitud) return false;

                return true;
            }

            return false;
        }

        public static string ConvertFormatDateToString(string fechaCadena)
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

        public static byte[] FileToBytes(string nombreArchivo, Boolean Eliminar)
        {
            try
            {
                byte[] bytesArchivo;
                if (System.IO.File.Exists(nombreArchivo))
                {
                    FileStream fileStream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                    BinaryReader readerBinario = new BinaryReader(fileStream);
                    long totalBytes = new FileInfo(nombreArchivo).Length;
                    bytesArchivo = readerBinario.ReadBytes(Convert.ToInt32(totalBytes));
                    fileStream.Close();
                    fileStream.Dispose();
                    readerBinario.Close();
                    //Borramos archivo del temporal          
                    if (Eliminar == true)
                        File.Delete(nombreArchivo);
                }
                else
                    throw new Exception("Archivo " + nombreArchivo + " no existe, no se pudo convertir a bytes.");

                return bytesArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear convertir archivo a bytes.", ex);
            }
        }

        public static string Right(string str, int Lenght)
        {
            string retorno = string.Empty;
            if (Lenght <= str.Length)
                retorno = str.Substring(str.Length - Lenght, Lenght);
            return retorno;
        }

        public static string Left(string str, int Lenght)
        {
            string retorno = string.Empty;
            if (Lenght <= str.Length)
                retorno = str.Substring(0, Lenght);
            return retorno;
        }

        public static string Mid(string str, int start, int lenght)
        {
            string retorno = string.Empty;
            retorno = str.Substring(start - 1, lenght);
            return retorno;
        }

        public static string Mid(string str, int start)
        {
            string retorno = string.Empty;
            retorno = str.Substring(start - 1, str.Length - (start - 1));
            return retorno;
        }

        public static string LimpiarCadena(string cad)
        {
            if (cad != null)
            {
                cad = cad.Trim();

                if (cad == "") cad = null;
            }

            return cad;
        }

        public static char? ToChar(object obj)
        {
            return ToChar(obj, null);
        }

        public static char? ToChar(object obj, char? def)
        {
            if (obj != DBNull.Value)
            {
                string aux = Convert.ToString(obj).Trim();

                return aux != "" ? aux[0] : def;
            }
            else
            {
                return def;
            }
        }

        public static string ToDateTimeString(object obj, string formato)
        {
            return ToDateTimeString(obj, formato, null);
        }

        public static string ToDateTimeString(object obj, string formato, string def)
        {
            if (obj != DBNull.Value)
            {
                DateTime dt = DateTime.Now;

                if (DateTime.TryParse(Convert.ToString(obj), out dt))
                {
                    return dt.ToString(formato);
                }
                else
                {
                    return def;
                }
            }
            else
            {
                return def;
            }
        }

        public static decimal ToDecimal(object obj)
        {
            return ToDecimal(obj, 0M);
        }

        public static decimal ToDecimal(object obj, decimal def)
        {
            return obj != DBNull.Value ? Convert.ToDecimal(obj) : def;
        }

        public static int ToInt32(object obj)
        {
            return ToInt32(obj, 0);
        }

        public static int ToInt32(object obj, int def)
        {
            return obj != DBNull.Value ? Convert.ToInt32(obj) : def;
        }

        public static short ToInt16(object obj)
        {
            return ToInt16(obj, 0);
        }

        public static short ToInt16(object obj, short def)
        {
            return obj != DBNull.Value ? Convert.ToInt16(obj) : def;
        }

        public static string ToString(object obj)
        {
            return ToString(obj, null);
        }

        public static string ToString(object obj, string def)
        {
            return obj != DBNull.Value ? Convert.ToString(obj).Trim() : def;
        }

        public static uint ToUInt32(object obj)
        {
            return ToUInt32(obj, 0);
        }

        public static uint ToUInt32(object obj, uint def)
        {
            return obj != DBNull.Value ? Convert.ToUInt32(obj) : def;
        }

        public static ushort ToUInt16(object obj)
        {
            return ToUInt16(obj, 0);
        }

        public static ushort ToUInt16(object obj, ushort def)
        {
            return obj != DBNull.Value ? Convert.ToUInt16(obj) : def;
        }

        public static string GetListaString(string cad)
        {
            if (cad != null && !cad.Contains("'"))
            {
                cad = "'" + cad + "'";
            }

            return cad;
        }

        public static DateTime? ToDateTime(object obj)
        {
            if (obj != DBNull.Value)
            {
                DateTime dt = DateTime.Now;

                if (DateTime.TryParse(Convert.ToString(obj), out dt))
                {
                    return dt;
                }
            }
            else
            {
                return null;
            }

            return null;
        }

        public static DateTime? ToDateTime(object obj, DateTime? def)
        {
            if (obj != DBNull.Value)
            {
                DateTime dt = DateTime.Now;

                if (DateTime.TryParse(Convert.ToString(obj), out dt))
                {
                    return dt;
                }
                else
                {

                    return def;
                }
            }
            else
            {
                return def;
            }
        }
    }
}
