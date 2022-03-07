using appcongreso.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Model
{
    public class CostosImprentaDAO : Service<usp_costos_prod_imprenta_datos_Result>
    {

        // entidades  usando ENTITY FRAMEWORK
        bdgenericEntities e = new bdgenericEntities();


        public void create(usp_costos_prod_imprenta_datos_Result t)
        {
            try
            {
                e.usp_registrar_costos_prod_imprenta(t.codigo, t.nro_libros, t.nro_paginas, t.largo, t.ancho, t.nro_pliegos, t.nro_resmas, t.nro_placas, t.doblez, 
                    t.alce, t.corte_refilado, t.encolado, t.movilidad, t.manejo_archivo, t.best_color, t.cif,t.tinta, t.total,t.titulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(usp_costos_prod_imprenta_datos_Result t)
        {
            try
            {
                e.usp_eliminar_costosimprenta(t.codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void update(usp_costos_prod_imprenta_datos_Result t)
        {
            try
            {
                e.usp_actualizar_costosimprenta(t.codigo, t.nro_libros, t.nro_paginas, t.largo, t.ancho, t.nro_pliegos, t.nro_resmas, t.nro_placas, t.doblez, t.alce, t.corte_refilado, 
                    t.encolado, t.movilidad, t.manejo_archivo, t.best_color, t.cif,t.tinta, t.total,t.titulo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public usp_costos_prod_imprenta_datos_Result find(usp_costos_prod_imprenta_datos_Result t)
        {
            throw new NotImplementedException();
        }


        public usp_costos_prod_imprenta_datos_Result find_codigo(usp_costos_prod_imprenta_datos_Result t)
        {
            usp_costos_prod_imprenta_datos_Result dato = null;
            var pro = e.usp_costos_prod_imprenta_datos(t.codigo);
            foreach (var item in pro)
            {
                dato = new usp_costos_prod_imprenta_datos_Result()
                {
                    idprodimprenta = item.idprodimprenta,
                    codigo = item.codigo,
                    ancho = item.ancho,
                    largo = item.largo,
                    nro_libros = item.nro_libros,
                    nro_paginas = item.nro_paginas,
                    nro_resmas = item.nro_resmas,
                    nro_placas = item.nro_placas,
                    encolado = item.encolado,
                    corte_refilado = item.corte_refilado,
                    manejo_archivo = item.manejo_archivo,
                    alce = item.alce,
                    doblez = item.doblez,
                    best_color = item.best_color,
                    movilidad = item.movilidad,
                    nro_pliegos = item.nro_pliegos,
                    tinta = item.tinta,
                    cif = item.cif,
                    total = item.total,
                    titulo = item.titulo
 
                };
            }
            return dato;
        }

        public List<usp_costos_prod_imprenta_datos_Result> readAll()
        {
            throw new NotImplementedException();
        }

        public void actualizarParametro(string nombre, decimal valor )
        {
            try
            {
                e.usp_actualizar_valor_param(valor, nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public decimal consultarValorParametro(string nombre)
        {
            usp_parametros_valor_xnombre_Result dato = null;
            try
            {     
                var pro = e.usp_parametros_valor_xnombre(nombre);
                foreach (var item in pro)
                {
                    dato = new usp_parametros_valor_xnombre_Result()
                    {
                        valor = item.valor
                    };
                }
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dato.valor;
        }
    }
}
