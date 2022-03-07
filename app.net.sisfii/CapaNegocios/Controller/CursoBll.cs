using appcongreso.EF;
using appcongreso.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaNegocios.Controller
{
    public class CursoBll
    {

        //variable de la clase CursoDAO
        CursoDAO dao;

        public CursoBll()
        {
            dao = new CursoDAO();
        }


        //metodos de persistencia de datos en sqlserver
        public void CursoAdicionar(usp_listar_curso_all_Result pro)
        {
            try
            {
                dao.create(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CursoActualizar(usp_listar_curso_all_Result pro)
        {
            try
            {
                dao.update(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CursoEliminar(usp_listar_curso_all_Result pro)
        {
            try
            {
                dao.delete(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public List<usp_listar_curso_all_Result> CursoListar(int cod)
        {
            try
            {
                return dao.readAll(cod.ToString());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        //public usp_equipo_listar_all_Result CursoBuscar_Nombre(usp_equipo_listar_all_Result pro)
        //{
        //    try
        //    {
        //        return dao.find_codigo(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
