using CapaDatos.DataBase;
using CapaDatos.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Model
{
    public class SalaDAO : AccesoDB,Service<usp_listar_salas_all_Result>
    {
        public void create(usp_listar_salas_all_Result t)
        {
            try
            {
                e.usp_registrar_sala(t.nombre, t.ubicacion, t.capacidad, t.rol_creacion,t.tipo_sala);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public void delete(usp_listar_salas_all_Result t)
        {
            try
            {
                e.usp_eliminar_sala(t.idsala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public usp_listar_salas_all_Result find(usp_listar_salas_all_Result t)
        {
            usp_listar_salas_all_Result dato = null;
            var pro = e.usp_sala_datos(t.nombre);
            foreach (var item in pro)
            {
                dato = new usp_listar_salas_all_Result()
                {
                    idsala = item.idsala,
                    nombre = item.nombre,
                    capacidad = item.capacidad,
                    tipo_sala = item.tipo_sala,
                    ubicacion = item.ubicacion
                    //IdProducto = item.IdProducto,
                    //NombreProducto = item.NombreProducto,
                    //IdProveedor = item.IdProveedor,
                    //IdCategoría = item.IdCategoría,
                    //PrecioUnidad = item.PrecioUnidad,
                    //UnidadesEnExistencia = item.UnidadesEnExistencia
                };
            }
            return dato;
        }

        public List<usp_listar_salas_all_Result> readAll()
        {
            return e.usp_listar_salas_all().ToList();
        }

        public void update(usp_listar_salas_all_Result t)
        {
            try
            {
                e.usp_actualizar_sala_id(t.idsala, t.nombre, t.ubicacion, t.capacidad, t.tipo_sala);
            }
            catch (Exception ex )
            {

                throw ex;
            }
         
        }
    }
}
