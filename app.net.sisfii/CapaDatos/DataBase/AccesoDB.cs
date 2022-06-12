using CapaDatos.EF;
using CapaDatos.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DataBase
{
    public class AccesoDB
    {

        protected bdgenericEntities e;

        public string Database { get; set; }

        public string user { get; set; }

        public string Pwd { get; set; }

        public string Server { get; set; }

        public string HostName { get; set; }

        public string ConexProvider { get; set; }

        public string cadenadesencriptada { get; set; }

        private EntityConnectionStringBuilder constconexion;


        public AccesoDB()
        {
            String hostName = Dns.GetHostName();
           
            constconexion = new EntityConnectionStringBuilder();
            
            constconexion.Provider = "System.Data.SqlClient";

            if (hostName == "DESKTOP-7POB2NJ")
            {
                //sql server
                constconexion.ProviderConnectionString = $"data source={hostName}\\SQLSERVER2019;initial catalog={Database};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            }
            else
            {
                //express
                constconexion.ProviderConnectionString = $"data source={hostName}\\SQLEXPRESS;initial catalog={Database};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            }
            
            constconexion.Metadata = "res://*/EF.Model1.csdl|res://*/EF.Model1.ssdl|res://*/EF.Model1.msl";
           
        }


        public Boolean conexion()
        {
            try
            {
                //conectar = new MySqlConnection(cadenadesencriptada);
                //System.Windows.Forms.MessageBox.Show("Conexion Establecida !!!");
                //conectar.Open();
                e = new bdgenericEntities(constconexion.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //System.Windows.Forms.MessageBox.Show("No se pudo conectar!!!");
            }
        }

        public void creararchivo()
        {
            string cadena;
            string filename = @"C:\datos\feedback.ini";
            FileStream Stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(Stream);
            cadena = "Server=" + Server + ";Database=" + Database + "; User Id=" + user + ";Password=" + Pwd;
            string cadenaencriptada = HelperDAO.Encriptar(cadena);  
            writer.WriteLine(cadenaencriptada);
            writer.Close();
        }
        //public static SqlConnection Conexion()
        //{
        //    //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bdgenericEntities"].ConnectionString);
        //    //return cn;
        //}
    }
}
