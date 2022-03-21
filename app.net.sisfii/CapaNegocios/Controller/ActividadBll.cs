using CapaDatos.EF;
using CapaDatos.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaNegocios.Controller
{
    public class ActividadBll
    {
        //variable de la clase actividadeDAO
        ActividadDAO dao;
        //constructor
        public ActividadBll()
        {
            dao = new ActividadDAO();
        }

        //metodos de persistencia de datos en sqlserver
        public void actividadeAdicionar(usp_listar_actividades_all_Result pro)
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

        public void actividadeEliminar(usp_buscar_actividad_codigo_Result pro)
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

        public void actividadeActualizar(usp_listar_actividades_all_Result pro)
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
        public int actividadGenerarCodigo()
        {
            try
            {
                return dao.CodeGenereActivity();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public usp_buscar_actividad_codigo_Result ActividadBuscar(usp_buscar_actividad_codigo_Result pro)
        {
            try
            {
                return dao.findByCode(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public usp_actividades_listar_all2_Result actividadeBuscarporFecha(usp_actividades_listar_all2_Result pro)
        //{
        //    try
        //    {
        //        return dao.BuscarporFecha(pro);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public usp_actividades_listar_all2_Result actividadeBuscarporDescripcion(usp_actividades_listar_all2_Result pro)
        //{
        //    try
        //    {
        //        return dao.BuscarporDescripcion(pro);
        //    } 
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public List<usp_actividades_listar_all2_Result> ActividadListar()
        //{
        //    try
        //    {
        //        return dao.readAll();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

    }
}
