using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public interface IManipulable<T>
    {
        public List<T> TraerListaParser();
        public T Traer(int id);//me trae uno solo

        public int Agregar(T objeto);
        public int Modificar(T objeto);
        public int Eliminar(int id);
    }
}
