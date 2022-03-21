using CapaDatos.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Model
{
    public class AmbienteDAO : Service<usp_listar_ambientes_all_Result>
    {
        bdgenericEntities e = new bdgenericEntities();

        public void create(usp_listar_ambientes_all_Result t)
        {
            throw new NotImplementedException();
        }

        public void delete(usp_listar_ambientes_all_Result t)
        {
            throw new NotImplementedException();
        }

        public usp_listar_ambientes_all_Result find(usp_listar_ambientes_all_Result t)
        {
            throw new NotImplementedException();
        }

        public List<usp_listar_ambientes_all_Result> readAll()
        {
            return e.usp_listar_ambientes_all().ToList();
        }

        public void update(usp_listar_ambientes_all_Result t)
        {
            throw new NotImplementedException();
        }
    }
}
