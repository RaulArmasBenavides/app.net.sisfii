using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;

namespace appcongreso.Model
{
    public class CursoDAO : Service<usp_listar_curso_all_Result>
    {

        // entidades  usando ENTITY FRAMEWORK
        readonly bdgenericEntities e = new bdgenericEntities();
        public void create(usp_listar_curso_all_Result t)
        {
            try
            {
                e.usp_registrar_curso(t.nombreCurso, t.tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(usp_listar_curso_all_Result t)
        {
            throw new NotImplementedException();
        }

        public usp_listar_curso_all_Result find(usp_listar_curso_all_Result t)
        {
            throw new NotImplementedException();
        }

        public List<usp_listar_curso_all_Result> readAll(string cod)
        {
            try
            {
               return  e.usp_listar_curso_all(cod).ToList(); //usp_equipo_listar_all().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
 
        }

        public List<usp_listar_curso_all_Result> readAll()
        {
            throw new NotImplementedException();
        }

        public void update(usp_listar_curso_all_Result t)
        {
            throw new NotImplementedException();
        }
    }
}
