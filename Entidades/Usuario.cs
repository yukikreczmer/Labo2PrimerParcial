﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Parser
    {
        public static List<Parser> usuarios = new List<Parser>();
        public static string pathRelativoUsuarios = "usuarios.txt";

        private string? _apellido;
        private string? _nombre;
        private int _dni;
        private string? _nombreUsuario;
        private string _contrasenia;
        private Roles _rol;

        public string Apellido { get => _apellido!; set => _apellido = value; }
        public string Nombre { get => _nombre!; set => _nombre = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string NombreUsuario { get => _nombreUsuario!; set => _nombreUsuario = value; }
        public Roles Rol { get => _rol; set => _rol = value; }

        public Usuario(string _apellido, string _nombre, int _dni, string _nombreUsuario, string _contrasenia, Roles _rol)
        {
            Apellido = _apellido!;
            Nombre = _nombre!;
            Dni = _dni;
            NombreUsuario = _nombreUsuario!;
            this._contrasenia = _contrasenia;
            Rol = _rol;
        }

        private bool ChequearContrasenia(string contrasenia)
        {
            return _contrasenia == contrasenia;
        }

        public static Usuario LoguearUsuario(string nombreUsuario, string contrasenia)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    if (usuario.ChequearContrasenia(contrasenia))
                    {
                        return usuario;
                    }
                }
            }            
            throw new Exception("Usuario y/o contraseña incorrectos");
        }


        public override string ParsearDatoAGuardar()        
        {           
            return $"{Apellido}-{Nombre}-{Dni}-{NombreUsuario}-{Rol}-{_contrasenia}";
        }

        public static void CargarUsuarios()
        {                     
            List<string> listaUsuariosString = Archivo.LeerArchivo(pathRelativoUsuarios);            
            ParsearUsuarios(listaUsuariosString, usuarios);
        }

        public static List<Usuario> VerListaComoUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            foreach (Usuario item in usuarios)
            {
                listaUsuarios.Add(item);
            }
            return listaUsuarios;
        }

        public static Usuario AgregarUsuario(string apellido, string nombre, string dniString, string nombreUsuario, string contrasenia, string contraseniaRepetida, bool esSuperUsuario)
        {
            int dni;
            Roles rol;

            if(!Validadora.ValidarNombre(apellido))
            {
                throw new Exception("Apellido no valido");
            }
            if(!Validadora.ValidarNombre(nombre))
            {
                throw new Exception("Nombre no valido");
            }
            if(!Validadora.ValidarDni(dniString, out dni))
            {
                throw new Exception("DNI no valido");
            }
            if(ExisteDniRegistrado(dni))
            {
                throw new Exception("DNI ya registrado");
            }
            if(ExisteNombreUsuarioRegistrado(nombreUsuario))
            {
                throw new Exception("Nombre de Usuario ya registrado");
            }
            if(nombreUsuario.Trim().Length < 5)
            {
                throw new Exception("El nombre de usuario debe contener minimo 5 caracteres");
            }
            if(contrasenia.Length < 8)
            {
                throw new Exception("La contraseña debe contener minimo 8 caracteres");
            }
            if(contrasenia != contraseniaRepetida)
            {
                throw new Exception("Las contraseñas no coinciden");            
            }            

            if(esSuperUsuario)
            {
                rol = Roles.superUsuario;
            }
            else
            {
                rol = Roles.empleado;
            }

            Usuario usuario = new Usuario(apellido, nombre, dni, nombreUsuario, contrasenia, rol);
            usuarios.Add(usuario);
            return usuario;
            
        }

        public static explicit operator Usuario (string linea)
        {       
            string[] cadenaDatos = linea.Split('-');            
            string apellido = cadenaDatos[0];
            string nombre = cadenaDatos[1];
            if(!int.TryParse(cadenaDatos[2],out int dni))
            {
                throw new Exception("Error al intentar cargar los dni de usuarios.");
            }
            string nombreUsuario = cadenaDatos[3];
            if(!Enum.TryParse(cadenaDatos[4],out Roles rol))
            {
                throw new Exception("Error al intentar cargar roles de usuarios.");
            }
            string contrasenia = cadenaDatos[5];
            Usuario usuario = new(apellido, nombre, dni, nombreUsuario, contrasenia, rol);
            return usuario;
        }

        public static bool ExisteNombreUsuarioRegistrado(string nombreUsuario)
        {
            foreach(Usuario item in usuarios)
            {
                if(item.NombreUsuario == nombreUsuario)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ExisteDniRegistrado(int dni)
        {
            foreach (Usuario item in usuarios)
            {
                if (item.Dni == dni)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
