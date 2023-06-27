using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Parser
    {
        /// <summary>
        /// Convierte los datos del objeto de tipo Parser a string, separados por un guion '-'
        /// </summary>
        /// <returns></returns> retorna string de los datos del objeto
        public abstract string ParsearDatoAGuardarArchivos();

        public abstract string ParsearDatoAGuardarDB();

        /// <summary>
        /// Convierte cada linea de la lista de strings que se pasa por parametros, en usuarios y los agrega a la lista parser de usuarios
        /// </summary>
        /// <param name="listaUsuariosString"></param>
        /// <param name="listaUsuariosParser"></param>

        public static void ParsearUsuarios(List<string> listaUsuariosString, List<Parser> listaUsuariosParser)
        {            
            {
                foreach(string item in listaUsuariosString)
                {                   
                    Usuario usuario = (Usuario)item;
                    listaUsuariosParser.Add(usuario);
                }
            }            
        }


        /// <summary>
        /// Convierte cada linea de la lista de strings que se pasa por parametros, en productos y los agrega a la lista parser de productos
        /// </summary>
        /// <param name="listaProductosString"></param>
        /// <param name="listaProductosParser"></param>
        public static void ParsearProductos(List<string> listaProductosString, List<Parser> listaProductosParser)
        {            
            {
                foreach(string item in listaProductosString)
                {                   
                    Producto producto = (Producto)item;
                    listaProductosParser.Add(producto);
                }
            }            
        }       

    }
}
