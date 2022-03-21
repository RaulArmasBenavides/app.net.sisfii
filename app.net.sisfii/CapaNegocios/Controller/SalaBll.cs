using appcongreso.Model;
using CapaDatos.EF;
using CapaDatos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Controller
{
    public class SalaBll
    {

        //variable de la clase SalaDAO
        SalaDAO dao;

        public SalaBll()
        {
            dao = new SalaDAO();
        }


        //metodos de persistencia de datos en sqlserver
        public void SalaAdicionar(usp_listar_salas_all_Result pro)
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

        public void SalaActualizar(usp_listar_salas_all_Result pro)
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

        public void SalaEliminar(usp_listar_salas_all_Result pro)
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


        public usp_listar_salas_all_Result SalaBuscar(usp_listar_salas_all_Result pro)
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



        public List<usp_listar_salas_all_Result> SalaListar()
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
