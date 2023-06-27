using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivo
    {        

        /// <summary>
        /// Abre el archivo que corresponde a la ruta que se pasa por parametro y retorna una lista de strings siendo cada string una linea del archivo.
        /// Si el archivo no existe arroja una NullReferenceException
        /// </summary>
        /// <param name="pathArchivo"></param>
        /// <returns></returns> contenido del archivo en forma de string o NullReferenceException
        /// <exception cref="NullReferenceException"></exception>
        public static List<string> LeerArchivo(string pathArchivo)
        {
            List<string> listaLineas = new List<string>();
            string linea;            
            if(File.Exists(pathArchivo))
            {
                StreamReader sr = File.OpenText(pathArchivo);
                while(sr.Peek() != -1)
                {
                    linea = sr.ReadLine()!;
                    listaLineas.Add(linea);
                }
                sr.Close();
                sr.Dispose();
            }
            else
            {
                throw new NullReferenceException();
            }
            
            return listaLineas;
        }
                
        /// <summary>
        /// Guarda los datos de la lista pasada por parámetro en la ruta de archivo que tambien se pasa por parametro como string, creándolo si no existe.
        /// </summary>
        /// <param name="archivoDestino"></param>
        /// <param name="datosAGuardar"></param>
        public static void GuardarDatos(string archivoDestino, List<Parser> datosAGuardar)
        {                                    
            StreamWriter streamWriter = new StreamWriter(archivoDestino, false);
            foreach(Parser item in datosAGuardar)
            {
                streamWriter.WriteLine(item.ParsearDatoAGuardarArchivos());
            }
            streamWriter.Close();
            streamWriter.Dispose();            
        }            

    }
}
