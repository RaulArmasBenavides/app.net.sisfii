using CapaDatos.DataBase;
using CapaDatos.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos.Model
{
    public class AlumnoDAO : AccesoDB, Service<usp_listar_alumnos_all_Result>
    {
       // bdgenericEntities e = new bdgenericEntities();
        public void create(usp_listar_alumnos_all_Result t)
        {
            e.usp_registrar_alumno(t.ap_paterno, t.ap_materno, t.nombre, t.telefono, t.sexo, t.correo, t.DNI, t.carrera, t.direccion, t.tipo_alumno);
        }

        public void delete(usp_listar_alumnos_all_Result t)
        {
            e.usp_eliminar_alumno_dni(t.DNI);
        }

        public usp_listar_alumnos_all_Result find(usp_listar_alumnos_all_Result t)
        {
            throw new NotImplementedException();
        }

        public usp_listar_alumnos_all_Result findbyCode(usp_listar_alumnos_all_Result t)
        {
            usp_listar_alumnos_all_Result dato = null;
            var pro = e.usp_buscar_alumno_dni(t.DNI);
            foreach (var item in pro)
            {
                dato = new usp_listar_alumnos_all_Result()
                {
                    idalumno = item.idalumno,
                    nombre = item.nombre,
                    ap_paterno = item.ap_paterno,
                    ap_materno = item.ap_materno,
                    DNI = item.DNI,
                    correo = item.correo,
                    direccion = item.direccion,
                    tipo_alumno = item.tipo_alumno,
                    carrera = item.carrera,
                    sexo = item.sexo,
                    telefono = item.telefono
                };
            }

            return dato;
        }

        public List<usp_listar_alumnos_all_Result> readAll()
        {
            return e.usp_listar_alumnos_all().ToList();
        }

        public void update(usp_listar_alumnos_all_Result t)
        {
            try
            {
                e.usp_actualizar_alumno_dni(t.ap_paterno, t.ap_materno, t.nombre, t.telefono, t.sexo, t.correo, t.DNI, t.direccion, t.tipo_alumno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
          //  e.SaveChanges();
        }

    }
}
