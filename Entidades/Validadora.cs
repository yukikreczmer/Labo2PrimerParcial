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

            decimal.TryParse(numeroIngresado, out precioValidado);
            if(precioValidado <= 0)
            {
                throw new Exception("Precio no válido");
            }
            return true;
        }

        public static bool ValidarDatosUsuarioOrThrow(string apellido, string nombre, string dniString, string nombreUsuario, string contrasenia, string contraseniaRepetida, bool esSuperUsuario, out int dni, out Roles rol, out Usuario usuarioExistente) 
        {

            ValidarDatosUsuarioOrThrow(apellido, nombre, dniString, nombreUsuario, contrasenia, contraseniaRepetida, esSuperUsuario, out dni, out rol);
            
            if (Usuario.ExisteNombreUsuarioRegistrado(nombreUsuario))
            {
                throw new Exception("Nombre de Usuario ya registrado");
            }
            if (!Validadora.ValidarDni(dniString, out dni))
            {
                throw new Exception("DNI no valido");
            }
            if (Usuario.ExisteDniRegistrado(dni, out usuarioExistente))
            {
                throw new Exception($"DNI ya registrado con el nombre de usuario: {usuarioExistente.NombreUsuario}");
            }
            return true;
        }
        public static bool ValidarDatosUsuarioOrThrow(string apellido, string nombre, string dniString, string nombreUsuario, string contrasenia, string contraseniaRepetida, bool esSuperUsuario, out int dni, out Roles rol)
        {
            if (!Validadora.ValidarNombre(apellido))
            {
                throw new Exception("Apellido no valido");
            }
            if (!Validadora.ValidarNombre(nombre))
            {
                throw new Exception("Nombre no valido");
            }
            if (!Validadora.ValidarDni(dniString, out dni))
            {
                throw new Exception("DNI no valido");
            }                        
            if (nombreUsuario.Trim().Length < 5)
            {
                throw new Exception("El nombre de usuario debe contener minimo 5 caracteres");
            }
            if (contrasenia.Length < 8)
            {
                throw new Exception("La contraseña debe contener minimo 8 caracteres");
            }
            if (contrasenia != contraseniaRepetida)
            {
                throw new Exception("Las contraseñas no coinciden");
            }

            if (esSuperUsuario)
            {
                rol = Roles.superUsuario;
            }
            else
            {
                rol = Roles.empleado;
            }
           
            return true;
        }
        
    }
}
