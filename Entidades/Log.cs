using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Log
    {        
        public event Action<IInformableLog, string, string> HuboCambios;
        public static Log instanciaLog = new Log();

        public Log()
        {
        }

        public void InformarEnLog(IInformableLog informableSender, string usuarioModificador, string aclaracionABMoVenta)
        {
            HuboCambios?.Invoke(informableSender, usuarioModificador, aclaracionABMoVenta);
        }

    }
}
