using CapaDatos.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DataBase
{
    public class AccesoDB
    {

        protected bdgenericEntities e;
        public AccesoDB()
        {
            String hostName = Dns.GetHostName();

     
            EntityConnectionStringBuilder constconexion = new EntityConnectionStringBuilder();
            constconexion.Provider = "System.Data.SqlClient";

            if (hostName == "DESKTOP-7POB2NJ")
            {
                //sql server
                constconexion.ProviderConnectionString = $"data source={hostName}\\SQLSERVER2019;initial catalog=bdgeneric;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            }
            else
            {
                //express
                constconexion.ProviderConnectionString = $"data source={hostName}\\SQLEXPRESS;initial catalog=bdgeneric;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            }
            
            constconexion.Metadata = "res://*/EF.Model1.csdl|res://*/EF.Model1.ssdl|res://*/EF.Model1.msl";
            e = new bdgenericEntities(constconexion.ToString());
        }

        //public static SqlConnection Conexion()
        //{
        //    //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bdgenericEntities"].ConnectionString);
        //    //return cn;
        //}
    }
}
