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

        public Proceso(int tiempo1)
        {
            tiempo1=_tiempo;
        }
    }
}
