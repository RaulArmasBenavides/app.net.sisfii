using CapaDatos.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace CapaDatos.Model
{
    public class ActividadDAO //: Service<usp_actividades_listar_all2_Result>
    {   // entidades  usando ENTITY FRAMEWORK
        bdgenericEntities e = new bdgenericEntities();
        public void create(usp_listar_actividades_all_Result t)
        {
            try
            {
                e.usp_registrar_actividad_oficial(t.nombre,t.codigo, t.descripcion, t.responsable, "SGIT", t.fec_inicio, t.fec_fin, t.tipoevento,t.lugar,t.certificado,t.inscripcion, t.idlistaeq, t.idsala, t.idsede, t.idambiente, t.justificacion, t.objetivos, t.horas, t.idorganiz);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            //objeto de tipo objectparameter para guardar el idproduto que devuelve el store
            //ObjectParameter cod = new ObjectParameter("idactividad", typeof(Int64));
            //dc.usp_Producto_Adicionar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia, cod);
            //e.usp_registrar_actividad(t.descripcion,t.rol_creacion,t.
            //t.idactividad = Convert.ToInt32(cod.Value.ToString()); // opcional
            //dc.SaveChanges();
        }

        public void update(usp_listar_actividades_all_Result pro)
        {
            try
            {
                e.usp_actualizar_actividad_codigo(pro.idactividad, pro.descripcion, pro.idlistaeq, pro.idsala, pro.idorganiz, pro.nombre, pro.fec_inicio, pro.fec_fin, pro.responsable, pro.codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void delete(usp_buscar_actividad_codigo_Result t)
        {
            try
            {
                e.usp_eliminar_actividad_codigo(t.codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int CodeGenereActivity()
        {
            int result = 0;
            ObjectParameter id2 = new ObjectParameter("codigox", typeof(int));
            try
            {
                result =  e.usp_generarcodigo_actividad(id2);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Convert.ToInt32(id2.Value)+1;
        }


        public void deleteByCode(usp_listar_actividades_all_Result t)
        {
            try
            {
                e.usp_eliminar_actividad_codigo(t.codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public usp_buscar_actividad_codigo_Result findByCode(usp_buscar_actividad_codigo_Result t)
        {

            usp_buscar_actividad_codigo_Result dato = null;
            var pro = e.usp_buscar_actividad_codigo(t.codigo);
            foreach (var item in pro)
            {
                dato = new usp_buscar_actividad_codigo_Result()
                {
                    idactividad = item.idactividad,
                    nombre = item.nombre,
                    responsable = item.responsable,
                    descripcion = item.descripcion,
                    justificacion =item.justificacion,
                    objetivos = item.objetivos,
                    horas = item.horas,
                    certificado = item.certificado,
                    inscripcion = item.inscripcion,
                    fec_inicio = item.fec_inicio,
                    fec_fin = item.fec_fin
                    //id = item.IdProducto,
                    //NombreProducto = item.NombreProducto,
                    //IdProveedor = item.IdProveedor,
                    //IdCategoría = item.IdCategoría,
                    //PrecioUnidad = item.PrecioUnidad,
                    //UnidadesEnExistencia = item.UnidadesEnExistencia
                    //idactividad = irwm
                };
            }
            return dato; 

        }


        //        public usp_actividades_listar_all2_Result BuscarporDescripcion(usp_actividades_listar_all2_Result t)
        //        {
        //            //return e.usp_BusquedaActividadforDescripcion(t.descripcion);
        //            //return e.usp_participantes_listar_ponentes().ToList();
        //            usp_actividades_listar_all2_Result dato = null;
        //            var pro = e.usp_BusquedaActividadforDescripcion(t.descripcion);
        //            foreach (var item in pro)
        //            {
        //                dato = new usp_actividades_listar_all2_Result()
        //                {
        //                    idactividad = item.idactividad,
        //                    descripcion = item.descripcion,
        //                    fecha_creacion = item.fecha_creacion
        //                    /*  IdProducto=item.IdProducto,
        //                      NombreProducto=item.NombreProducto,
        //                      IdProveedor=item.IdProveedor,
        //                      IdCategoría=item.IdCategoría,
        //                      PrecioUnidad=item.PrecioUnidad,
        //                      UnidadesEnExistencia=item.UnidadesEnExistencia*/
        //                };
        //            }
        //            return dato;
        //        }
        //        public usp_actividades_listar_all2_Result BuscarporFecha(usp_actividades_listar_all2_Result t)
        //        {
        //          //  return e.usp_BusquedaActividadforDescripcion(t.fecha.ToString()).ToString();
        //            //return e.usp_participantes_listar_ponentes().ToList();


        //      usp_actividades_listar_all2_Result dato = null;
        //      var pro = e.usp_BusquedaActividadforFecha(t.fecha_creacion);
        //      foreach (var item in pro)   
        //          {
        //                dato = new usp_actividades_listar_all2_Result()
        //                { idactividad = item.idactividad,
        //                  descripcion = item.descripcion,
        //                  fecha_creacion = item.fecha_creacion
        //                  };
        //           }
        //           return dato; 

        //}

        //            public List<usp_actividades_listar_all2_Result> readAll()
        //            {
        //                return e.usp_actividades_listar_all2().ToList();
        //            }

        //            public void update(usp_actividades_listar_all2_Result t)
        //            {
        //            //dc.usp_Producto_Actualizar(t.NombreProducto, t.IdProveedor, t.IdCategoría, t.PrecioUnidad, t.UnidadesEnExistencia, t.IdProducto);
        //            //dc.SaveChanges();
        //            e.usp_actualizar_actividad(t.idactividad, t.descripcion, t.fecha_creacion);

        //            }
    }
}
