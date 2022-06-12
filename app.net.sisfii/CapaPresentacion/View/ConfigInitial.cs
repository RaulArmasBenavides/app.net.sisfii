using CapaDatos.DataBase;
using CapaPresentacion.View.Configuracion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.View
{
    public class ConfigInitial
    {
        public ConfigInitial()
        {
 
            ClsInicio inicio = new ClsInicio();
            AccesoDB conexion = new AccesoDB();

            string sFileName = @"C:\datos\feedback.ini";


            if (File.Exists(sFileName))
            {
                FileStream fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader sr = new StreamReader(fs);

                string sContent;
                sContent = sr.ReadLine();

                conexion.cadenadesencriptada = datos.Desencriptar(sContent);
                String cad = conexion.cadenadesencriptada;
                fs.Close();
                sr.Close();
                string[] cadenas = { };

                cadenas = cad.Split('=', ';');

                conexion.Database = cadenas[3];
                conexion.Pwd = cadenas[7];
                conexion.Server = cadenas[1];
                conexion.user = cadenas[5];
                string cadena = "Server=" + conexion.Server + ";Database=" + conexion.Database + "; User Id=" + conexion.user + ";Password=" + conexion.Pwd;

                conexion.cadenadesencriptada = cadena;
                if (conexion.conexion())
                {
                    //frmsplash splash = new frmsplash();
                    //splash.Show();
                    frmLogin log = new frmLogin();
                    log.Show();

                    conexion.conectar.Close();
                }
                else if (conexion.conexion() == false)
                {
                    frmConfiguracion s = new frmConfiguracion();
                    s.Show();
                    conexion.conectar.Close();
                }

            }
            else
            {
                frmConfiguracion confi = new frmConfiguracion();
                confi.Show();
                conexion.conectar.Close();
            }
        }

    }
}
