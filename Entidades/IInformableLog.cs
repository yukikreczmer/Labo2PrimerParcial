using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInformableLog
    {
        private static string _fileName = "logs.txt";

        static string FileName { get => _fileName; }

        public void RegistrarCambio(IInformableLog informableSender, string usuarioModificador, string aclaracionABMoVenta);

    }
}
