using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CapaPresentacion.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void SetCulture()
        {
            CultureInfo culturePeru = GetCulture();
            Thread.CurrentThread.CurrentCulture = culturePeru;
            Thread.CurrentThread.CurrentUICulture = culturePeru;
        }

        public static CultureInfo GetCulture()
        {
            CultureInfo culturePeru = null;
            try
            {
                culturePeru = new CultureInfo("es-PE", false);
                culturePeru.NumberFormat.NumberGroupSeparator = ",";
                culturePeru.NumberFormat.NumberDecimalSeparator = ".";
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            return culturePeru;
        }
    }
}
