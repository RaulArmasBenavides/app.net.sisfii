using appcongreso.EF;
using CapaDatos.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaNegocios.Controller
{
    public class AlumnoBll
    {
        //variable de la clase ParticipanteDAO
        AlumnoDAO dao;
        //constructor
        public AlumnoBll()
        {
            dao = new AlumnoDAO();
        }

        //metodos de persistencia de datos en sqlserver
        public void ParticipanteAdicionar(usp_listar_alumnos_all_Result pro)
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

        public void ParticipanteActualizar(usp_listar_alumnos_all_Result pro)
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

        public void ParticipanteEliminar(usp_listar_alumnos_all_Result pro)
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

        public usp_listar_alumnos_all_Result ParticipanteBuscar(usp_listar_alumnos_all_Result pro)
        {
            try
            {
                return dao.findbyCode(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }



        public List<usp_listar_alumnos_all_Result> AlumnoListar()
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

        //public List<usp_listar_alumnos_all_Result> ParticipanteAlumnoListar()
        //{
        //    try
        //    {
        //        return dao.readAlumnos();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public List<usp_listar_alumnos_all_Result> ParticipantePonenteListar()
        //{
        //    try
        //    {
        //        return dao.readPonentes();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public List<usp_listar_alumnos_all_Result> ParticipanteProfesionalListar()
        //{
        //    try
        //    {
        //        return dao.readProfesionales();
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}




        /* 
        public List<usp_Proveedor_Listar_Result> ProveedorListar()
        {
            try
            {
                return dao.listaProveedores();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<usp_Categoria_Listar_Result> CategoriaListar()
        {
            try
            {
                return dao.listaCategoria();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        */
    }
}
