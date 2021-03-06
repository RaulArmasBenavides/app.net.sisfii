using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.EF;
using CapaDatos.Service;

namespace CapaDatos.Model
{
    public class EquipoDAO : Service<usp_equipo_listar_all_Result>
    {
        // entidades  usando ENTITY FRAMEWORK
        bdgenericEntities e = new bdgenericEntities();
        
        public void create(usp_equipo_listar_all_Result t)
        {   
            try
            {
                e.usp_registrar_equipo(t.Nombre,t.SO,t.Procesador,t.RAM,t.TarjetaMadre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(usp_equipo_listar_all_Result t)
        {
            try
            {
                e.usp_eliminar_equipo(t.idEquipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }
        public void delete(equipo g)
        {
            try
            {
                var aux = (from p in e.equipo
                           where p.idEquipo == g.idEquipo 
                                select p).SingleOrDefault();
                e.equipo.Remove(aux);
                e.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public usp_equipo_listar_all_Result find(usp_equipo_listar_all_Result t)
       {
            usp_equipo_listar_all_Result dato = null;
            var pro = e.usp_equipo_datos(t.idEquipo);
            foreach (var item in pro)
            {
                dato = new usp_equipo_listar_all_Result()
                {
                    idEquipo = item.idEquipo,
                    Nombre = item.Nombre,
                    SO = item.SO,
                    RAM = item.RAM,
                    Procesador= item.Procesador,
                    TarjetaMadre = item.TarjetaMadre
                };
            }
            return dato;
        }


        public usp_equipo_listar_all_Result find_codigo(usp_equipo_listar_all_Result t)
        {
            usp_equipo_listar_all_Result dato = null;
            var pro = e.usp_equipo_datos_codigo(t.Nombre);
            foreach (var item in pro)
            {
                dato = new usp_equipo_listar_all_Result()
                {
                    idEquipo = item.idEquipo,
                    Nombre = item.Nombre,
                    SO = item.SO,
                    RAM = item.RAM,
                    Procesador = item.Procesador,
                    TarjetaMadre = item.TarjetaMadre
                };
            }
            return dato;
        }

        public List<usp_equipo_listar_all_Result> readAll()
        {
            return e.usp_equipo_listar_all().ToList();
        }

        public void update(usp_equipo_listar_all_Result t)
        {
            try
            {
                e.usp_actualizar_equipo(t.idEquipo,t.Nombre,t.SO,t.Procesador,t.RAM,t.TarjetaMadre);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
