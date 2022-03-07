using appcongreso.Model;
using appcongreso.EF;
using CapaDatos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Controller
{
    public class SedeBll
    {

        //variable de la clase SalaDAO
        SedeDAO dao;

        public SedeBll()
        {
            dao = new SedeDAO();
        }


        //metodos de persistencia de datos en sqlserver
        public void SedeAdicionar(usp_listar_sede_all_Result pro)
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

        public void SedeActualizar(usp_listar_sede_all_Result pro)
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

        public void SedeEliminar(usp_listar_sede_all_Result pro)
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


        public usp_listar_sede_all_Result SedeBuscar(usp_listar_sede_all_Result pro)
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



        public List<usp_listar_sede_all_Result> SedeListar()
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
