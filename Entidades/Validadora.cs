using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    static public class Validadora
    {
        public static bool ValidarDni(string numeroTexto, out int dni)
        {
            if (numeroTexto.Length > 6 && numeroTexto.Length < 9)
            {
                return int.TryParse(numeroTexto, out dni);
            }

            dni = 0;

            return false;
        }
        public static bool ValidarNombre(string textoAValidar)
        {      
            if(string.IsNullOrEmpty(textoAValidar.Trim()))
            {
                return false;
            }
            foreach (char c in textoAValidar)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            textoAValidar.Trim();

            return true;
        }

        public static bool ValidarPrecio(string numeroIngresado, out decimal precioValidado)
        {
            int contadorComas = 0;
            precioValidado = 0;

            numeroIngresado = numeroIngresado.Replace('.', ',');

            foreach (char c in numeroIngresado)
            {
                if (!char.IsDigit(c))
                {
                    if (c == ',')
                    {
                        contadorComas++;
                        if (contadorComas >= 2)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return decimal.TryParse(numeroIngresado, out precioValidado);
        }
    }
}
