using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Proceso
    {
        private int _tiempo;
        public int tiempo { get { return _tiempo; } set { _tiempo = value; } }

        private Proceso _siguiente;
        public Proceso Siguiente { get { return _siguiente; } set { _siguiente = value; } }

        private Proceso _anterior;
        public Proceso Anterior { get { return _anterior; } set { _anterior = value; } }

        public Proceso(int tiempo1)
        {
            tiempo1=_tiempo;
        }
    }
}
