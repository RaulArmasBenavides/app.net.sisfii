using CapaDatos.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DataBase
{
    public class AccesoDB
    {

        protected bdgenericEntities e;
        public AccesoDB()
        {
            EntityConnectionStringBuilder constconexion = new EntityConnectionStringBuilder();
            constconexion.Provider = "System.Data.SqlClient";
            constconexion.ProviderConnectionString = "data source=.;initial catalog=bdgeneric;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
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
