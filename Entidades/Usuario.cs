using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Parser, IInformableLog
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
        public string Contrasenia { get => _contrasenia!;}
        public Roles Rol { get => _rol; set => _rol = value; }

        public Usuario(string _apellido, string _nombre, int _dni, string _nombreUsuario, string _contrasenia, Roles _rol)
        {
            Apellido = _apellido!;
            Nombre = _nombre!;
            Dni = _dni;
            NombreUsuario = _nombreUsuario!;
            Rol = _rol;
            this._contrasenia = _contrasenia;
            Log.instanciaLog.HuboCambios += RegistrarCambio;
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


        public override string ParsearDatoAGuardarArchivos()        
        {           
            return $"{Apellido}-{Nombre}-{Dni}-{NombreUsuario}-{Rol}-{_contrasenia}";
        }
        public override string ParsearDatoAGuardarDB()
        {
            return $"usuarios (apellido, nombre, dni, nombreUsuario, rol, contrasenia) VALUES('{Apellido}', '{Nombre}', '{Dni}', '{NombreUsuario}', '{Rol}', '{_contrasenia}')";
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
            Usuario usuarioExistente = null!;
            Validadora.ValidarDatosUsuarioOrThrow(apellido, nombre, dniString, nombreUsuario, contrasenia, contraseniaRepetida, esSuperUsuario, out dni, out rol, out usuarioExistente);

            Usuario usuario = new Usuario(apellido, nombre, dni, nombreUsuario, contrasenia, rol);
            usuarios.Add(usuario);   
            return usuario;
        }
        public void ModificarUsuario(string apellido, string nombre, int dni, string nombreUsuario, string contrasenia, Roles rol)
        {
            if(ChequearContrasenia(contrasenia))
            {
                Apellido = apellido;
                Nombre = nombre;
                Dni = dni;
                NombreUsuario = nombreUsuario;        
                _contrasenia = contrasenia;
                Rol = rol;
            }
            else
            {
                throw new Exception("Introduzca la contraseña original para efectuar los cambios");
            }
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
        public static bool ExisteDniRegistrado(int dni, out Usuario usuario)
        {
            foreach (Usuario item in usuarios)
            {
                if (item.Dni == dni)
                {
                    usuario = item;
                    return true;
                }
            }
            usuario = null!;
            return false;
        }

        public static void BajarUsuario(Usuario usuarioABajar)
        {
            foreach (Parser item in usuarios)
            {
                if (item.Equals(usuarioABajar))
                {
                    usuarios.Remove(item);
                    break;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Nombre de Usuario: {NombreUsuario}");
            sb.AppendLine($"Rol: {Rol}");

            return sb.ToString();
        }

        private string PrepararCambioAInformar(string usuarioModificador, string AclaracionABM)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(usuarioModificador);
            sb.AppendLine(AclaracionABM);
            sb.AppendLine(this.ToString());
            sb.AppendLine();

            return sb.ToString();
        }

        public void RegistrarCambio(IInformableLog informableSender, string usuarioModificador, string aclaracionABMoVenta)
        {
            if (informableSender == this)
            {
                string cambioAInformar = PrepararCambioAInformar(usuarioModificador, aclaracionABMoVenta);
                Archivo.GuardarDatos(IInformableLog.FileName, cambioAInformar);
            }
        }
    }
}
