using CapaDatos.DataBase;
using CapaDatos.EF;
using CapaDatos.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace CapaDatos.Model
{
    public class UsuarioDAO : AccesoDB, Service<usp_usuarios_listar_all_Result>
    {
        //crear usuario
        public void create(usp_usuarios_listar_all_Result t)
        {
            //throw new NotImplementedException();
            e.usp_registrar_usuario(t.usuario, t.clave);

        }
        //eliminar usuario
        public void delete(usp_usuarios_listar_all_Result t)
        {
            //throw new NotImplementedException();
            e.usp_eliminar_usuario(t.usuario);
        }
        //encontrar usuarios
        public usp_usuarios_listar_all_Result find(usp_usuarios_listar_all_Result t)
        {
            throw new NotImplementedException();
        }
        //listar usuarios
        public List<usp_usuarios_listar_all_Result> readAll()
        {
            return e.usp_usuarios_listar_all().ToList();
        }
        //actualizar usuarios
        public void update(usp_usuarios_listar_all_Result t)
        {
            e.usp_actualizar_usuario(t.usuario, t.clave);
        }

        //actualizar usuarios foto
        public void updateandpic(usp_buscar_usuario_nombre_Result t)
        {
            e.usp_actualizar_usuario_user(t.usuario, t.clave,t.foto);
        }


        public usp_buscar_usuario_nombre_Result findDatosUsuario(usp_buscar_usuario_nombre_Result t)
        {

            usp_buscar_usuario_nombre_Result dato = null;
            var pro = e.usp_buscar_usuario_nombre(t.usuario);
            foreach (var item in pro)
            {
                dato = new usp_buscar_usuario_nombre_Result()
                {
                    idusuario = item.idusuario,
                    usuario = item.usuario,
                    clave = item.clave,
                    foto = item.foto
                };

            }
            return dato;
        }

        public ObjectResult<usp_ValidaUsuario_Result> validar(usp_usuarios_listar_all_Result t)
        {
            try
            {
                return e.usp_ValidaUsuario(t.usuario, t.clave);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* public usp_usuarios_listar_all_Result validar(usp_usuarios_listar_all_Result t)
            {   
                MessageBox.Show(" 1 " + t.usuario);
                MessageBox.Show(" 2 " + t.clave);


                return e.ValidaUsuario(t.usuario, t.clave);
                //return e.ValidaUsuario(t.usuario, t.clave);
                //MessageBox.Show(" el x es " + x);

                /*if(x==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
    }*/

    }
}
