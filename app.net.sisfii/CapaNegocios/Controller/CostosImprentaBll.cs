using CapaDatos.EF;
using CapaDatos.Clases;
using CapaDatos.Model;
using System;
using System.Data.SqlClient;

namespace CapaNegocios.Controller
{
    public class CostosImprentaBll
    {

        //variable de la clase EquipoDAO
        CostosImprentaDAO dao;

        public CostosImprentaBll()
        {
            dao = new CostosImprentaDAO();
        }


        //metodos de persistencia de datos en sqlserver
        public void CostosImprentaAdicionar(usp_costos_prod_imprenta_datos_Result pro, bool acolor)
        {
            try
            {
                CalculoCostos(ref pro , acolor);
                dao.create(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CostosImprentaActualizar(usp_costos_prod_imprenta_datos_Result pro , bool acolor)
        {
            try
            {
                CalculoCostos(ref pro,acolor);
                dao.update(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CostosImprentaEliminar(usp_costos_prod_imprenta_datos_Result pro)
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

        public usp_costos_prod_imprenta_datos_Result CostosImprentaBuscar_Codigo(usp_costos_prod_imprenta_datos_Result pro)
        {
            try
            {
                return dao.find_codigo(pro);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CalculoCostos( ref usp_costos_prod_imprenta_datos_Result pro, bool acolor )
        {
            decimal largo_pliego = 0;
            decimal ancho_pliego = 0;
            decimal nro_hojas_x_pliego = 0;
            decimal precio_resma = 100;
            decimal precio_placa = 13.5m;
            decimal precio_doblez = 0;
            decimal precio_alce = 8m;
            decimal precio_corte_refilado = 100;
            decimal precio_movilidad = 100;
            decimal precio_manejo_archivo = 100;
            decimal precio_best_color = 18;
            decimal precio_encolado = 0.3m;
            decimal precio_tinta = 0.3m;
            decimal monto01 = 0;
            largo_pliego = 61;
            ancho_pliego = 82;


            precio_alce = getValorParametro(Constantes.CTE_ALCE);
            precio_doblez = getValorParametro(Constantes.CTE_DOBLEZ);
            precio_corte_refilado = getValorParametro(Constantes.CTE_CORTEREFILADO);
            precio_movilidad = getValorParametro(Constantes.CTE_MOVILIDAD);
            precio_best_color = getValorParametro(Constantes.CTE_BESTCOLOR);
            precio_encolado = getValorParametro(Constantes.CTE_ENCOLADO);
            precio_tinta = getValorParametro(Constantes.CTE_TINTA);

            nro_hojas_x_pliego = (largo_pliego / pro.largo) * (ancho_pliego / pro.ancho);

            pro.nro_pliegos = Convert.ToInt32((pro.nro_libros * pro.nro_paginas) / nro_hojas_x_pliego);
            //1 resma contiene 500 pliegos
            pro.nro_resmas = Convert.ToInt32(pro.nro_pliegos / 500);
            monto01 += pro.nro_resmas * precio_resma;
            pro.nro_placas = Convert.ToInt32(nro_hojas_x_pliego * 2);
            monto01 += pro.nro_placas * precio_placa;
            pro.alce = nro_hojas_x_pliego * precio_alce;
            pro.doblez = nro_hojas_x_pliego *precio_doblez;
            pro.manejo_archivo = 100;
            pro.encolado = pro.nro_libros * precio_encolado;
            pro.movilidad = precio_movilidad;
            pro.corte_refilado = precio_corte_refilado;
            pro.best_color = precio_best_color;
            pro.tinta = precio_tinta;
            if (acolor == true) pro.tinta = pro.tinta * 1.3m;

            pro.total = (decimal)(monto01 + pro.doblez + pro.alce + pro.manejo_archivo + pro.encolado + pro.movilidad + pro.corte_refilado 
                + pro.best_color + pro.tinta);
            pro.cif = 0.10m * pro.total;
            pro.total += pro.cif;


        }

        public void PrecioActualizar(string param , string valor)
        {
            try
            {
                dao.actualizarParametro(param,Convert.ToDecimal(valor));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public decimal  getValorParametro( string nombre)
         {
           try
             {
               return dao.consultarValorParametro(nombre);
             }
                catch (Exception ex)
             {
                throw ex;
             }

           }
    }
}
