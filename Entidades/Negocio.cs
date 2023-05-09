using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Negocio
    {
        public static List<Usuario> listaUsuarios;

        static Negocio()
        {
            listaUsuarios = new List<Usuario>();
        }

        public static void CargarUsuarios()
        {
            listaUsuarios.Add(new Usuario("Rampi", "Mario", 40123123, "supermario", "rampi", Roles.superUsuario));
            listaUsuarios.Add(new Usuario("Mauro", "Luciano", 40123124, "mauromauro", "asd123", Roles.empleado));
        }
        public static Usuario LoguearUsuario(string nombreUsuario, string contrasenia)
        {            
            foreach (Usuario usuario in listaUsuarios)
            {
                if(usuario.NombreUsuario == nombreUsuario)
                {
                    if(usuario.ChequearContrasenia(contrasenia))
                    {
                        return usuario;
                    }
                }
            }
            throw new Exception("Usuario y/o contraseña incorrectos");
        }
    }
}
