using appcongreso.EF;
using CapaDatos.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaNegocios.Controller
{
    public class AmbienteBll
    {

        //variable de la clase AmbienteDAO
        AmbienteDAO dao;

        public AmbienteBll()
        {
            dao = new AmbienteDAO();
        }


        //metodos de persistencia de datos en sqlserver
        //public void AmbienteAdicionar(usp_ambiente_listar_all_Result pro)
        //{
        //    try
        //    {
        //        dao.create(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void AmbienteActualizar(usp_Ambiente_listar_all_Result pro)
        //{
        //    try
        //    {
        //        dao.update(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void AmbienteEliminar(usp_Ambiente_listar_all_Result pro)
        //{
        //    try
        //    {
        //        dao.delete(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public usp_Ambiente_listar_all_Result AmbienteBuscar(usp_Ambiente_listar_all_Result pro)
        //{
        //    try
        //    {
        //        return dao.find(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}



        public List<usp_listar_ambientes_all_Result> AmbienteListar()
        {
            try
            {
                return dao.readAll();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
