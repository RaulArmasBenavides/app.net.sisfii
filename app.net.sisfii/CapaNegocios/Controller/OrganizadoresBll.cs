using appcongreso.EF;
using appcongreso.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Controller
{
    public class OrganizadoresBll
    {

        OrganizadoresDAO dao;

        //variable de la clase usuarioeDAO
        //OrganizadoresDAO dao;
        ////constructor
        public OrganizadoresBll()
        {
            dao = new OrganizadoresDAO();
        }

        public List<usp_organizadores_oficial_Result> ListaOrganizadoresCodigo(usp_organizadores_oficial_Result pro)
        {
            try
            {
                return dao.find(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public List<usp_asistencias_oficial_Result> ListaAsistenciaOficial(usp_asistencias_oficial_Result pro)
        //{
        //    try
        //    {
        //        return dao.find2(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public usp_asistencias_datos_codigo_Result Leer_asistencia_cabecera(usp_asistencias_Result pro)
        //{
        //    try
        //    {
        //        return dao.Leer_asistencia_cabecera(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}




        public List<usp_organizadores_oficial_all_Result> ListarAll2()
        {
            try
            {
                return dao.readAll2();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public int RegistrarListaOrganizadores(string codigo, List<usp_organizadores_oficial_Result> pro, bool Esnuevo)
        {
            try
            {
                return dao.RegistrarListaAsistentes(codigo,12, pro, Esnuevo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_listar_tipoeventos_Result> TipoEventosListar()
        {
            try
            {
                return dao.readAllEventType();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
