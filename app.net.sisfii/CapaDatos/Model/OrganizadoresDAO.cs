using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appcongreso.EF;
using System.Threading.Tasks;
using CapaDatos.Service;
using System.Data.Entity.Core.Objects;

namespace appcongreso.Model
{
    public class OrganizadoresDAO : Service<usp_organizadores_oficial_Result>
    {
        // entidades  usando ENTITY FRAMEWORK
        bdgenericEntities entidades = new bdgenericEntities();
        public void create(usp_organizadores_oficial_Result t)
        {
            throw new NotImplementedException();
        }

        public void delete(usp_organizadores_oficial_Result t)
        {
            throw new NotImplementedException();
        }

        public List<usp_organizadores_oficial_Result> find(usp_organizadores_oficial_Result t)
        {

            List<usp_organizadores_oficial_Result> lista_aux = new List<usp_organizadores_oficial_Result>();
            usp_organizadores_oficial_Result dato = null;
            var pro = entidades.usp_organizadores_oficial(t.codigo);
            foreach (var item in pro.ToList())
            {
                dato = new usp_organizadores_oficial_Result()
                {
                    ap_materno = item.ap_materno,
                    ap_paterno = item.ap_paterno,
                    DNI = item.DNI,
                    codigo = t.codigo,
                    idorganiz = item.idorganiz
                };
                lista_aux.Add(dato);
            }
            return lista_aux;
 
        }

        public List<usp_organizadores_oficial_Result> find2(usp_organizadores_oficial_Result t)
        {

            //usp_asistencias_Result dato = null;
            var pro = entidades.usp_organizadores_oficial(t.codigo);
            //foreach (var item in pro)
            //{
            //    dato = new usp_asistencias_Result()
            //    {
            //        ap_materno =item.ap_materno,
            //        ap_paterno = item.ap_paterno,
            //        DNI = item.DNI
            //        //IdProducto = item.IdProducto,
            //        //NombreProducto = item.NombreProducto,
            //        //IdProveedor = item.IdProveedor,
            //        //IdCategoría = item.IdCategoría,
            //        //PrecioUnidad = item.PrecioUnidad,
            //        //UnidadesEnExistencia = item.UnidadesEnExistencia
            //    };
            //}
            return pro.ToList();
            //hrow new NotImplementedException();
        }

        //public List<usp_asistencias_listar_all_Result> readAll2()
        //{
        //    return entidades.usp_asistencias_listar_all("").ToList();
        //}

        public List<usp_organizadores_oficial_all_Result> readAll2()
        {
            return entidades.usp_organizadores_oficial_all("").ToList();
        }

        //this method reads usp_listar_tipoeventos_Result event type
        public List<usp_listar_tipoeventos_Result> readAllEventType()
        {
            return entidades.usp_listar_tipoeventos().ToList();
        }


        public usp_organizadores_datos_codigo_Result Leer_asistencia_cabecera (usp_organizadores_datos_codigo_Result t)
        {


            usp_organizadores_datos_codigo_Result dato = null;
            var pro = entidades.usp_organizadores_datos_codigo(t.codigo);
            foreach (var item in pro)
            {
                dato = new usp_organizadores_datos_codigo_Result()
                {
                    idorganiz = item.idorganiz

                };
            }

           return dato; 
        } 


 



        public int RegistrarListaAsistentes(string codigo ,int iddet, List<usp_organizadores_oficial_Result> lista , bool Esnuevo)
        {
            int i = 0;
            ObjectParameter id2 = new ObjectParameter("idorganiz", typeof(int));
            if (Esnuevo)
            {  //registro nuevo
               i = entidades.usp_registrar_organizadores(codigo, iddet, id2);
            }
             if(lista.Count >0)
             RegistrarDetalleCabecera(codigo, lista, Esnuevo);

            return Convert.ToInt32(id2.Value);
        }

        public void RegistrarDetalleCabecera(string codigo, List<usp_organizadores_oficial_Result> lista, bool Esnuevo)
        {
            if(!Esnuevo)
            {
                entidades.usp_borrar_det_organizadores(codigo);
            }
          
            foreach (var item in lista)
            {
                entidades.usp_registrar_det_org(item.DNI, item.codigo);
            }
        }

        public List<usp_organizadores_oficial_Result> readAll()
        {
            throw new NotImplementedException();
        }

 

        public void update(usp_organizadores_oficial_Result t)
        {
            throw new NotImplementedException();
        }

        usp_organizadores_oficial_Result Service<usp_organizadores_oficial_Result>.find(usp_organizadores_oficial_Result t)
        {
            throw new NotImplementedException();
        }

        List<usp_organizadores_oficial_Result> Service<usp_organizadores_oficial_Result>.readAll()
        {
            throw new NotImplementedException();
        }
    }
}
