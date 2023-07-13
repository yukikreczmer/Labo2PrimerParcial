using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExportadorCSV
    {
        public static string GenerarContenidoCSV<T>(List<T> listaDatos)
        {
            StringBuilder contenidoCSV = new StringBuilder();


            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                contenidoCSV.Append(property.Name + ",");
            }
            contenidoCSV.AppendLine();


            foreach (var dato in listaDatos)
            {
                foreach (var property in properties)
                {
                    var value = property.GetValue(dato);
                    contenidoCSV.Append(value + ",");
                }
                contenidoCSV.AppendLine();
            }

            return contenidoCSV.ToString();
        }
    }
}
