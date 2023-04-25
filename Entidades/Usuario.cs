using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario 
    {
        private string _apellido;
        private string _nombre;
        private int _dni;
        private string _nombreUsuario;
        private string _contrasenia;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }




        public bool ChequearContrasenia(string contrasenia)
        {
            return _contrasenia == contrasenia;
        }
        public void SetContrasenia(string contrasenia)
        {
            _contrasenia = contrasenia;
        }


    }
}
