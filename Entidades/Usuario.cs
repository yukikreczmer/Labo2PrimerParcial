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
        private Roles _rol;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        private Roles Rol { get => _rol; set => _rol = value; }

        public Usuario(string _apellido, string _nombre, int _dni, string _nombreUsuario, string _contrasenia, Roles _rol)
        {
            Apellido = _apellido!;
            Nombre = _nombre!;
            Dni = _dni;
            NombreUsuario = _nombreUsuario!;
            this._contrasenia = _contrasenia;
            Rol = _rol;
        }     


        public bool ChequearContrasenia(string contrasenia)
        {
            return _contrasenia == contrasenia;
        }       



    }
}
