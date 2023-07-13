using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public interface IManipulable<T>
    {
        public Task<List<Parser>> TraerListaParser();

    }
}
