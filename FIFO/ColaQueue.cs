using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class ColaQueue
    {
        private Proceso _inicio;
        public Proceso Inicio { get { return _inicio; } }

        private Proceso _ultimo;
        public Proceso Ultimo { get { return _ultimo; } }

        private int _count;
        public int Count { get { return _count; } }


        public void Enqueue(Proceso nuevo)
        {
            Proceso temp = _inicio;

            _inicio = nuevo;
            _inicio.Siguiente = temp;

            if (temp == null)
                _ultimo = _inicio;
            else
                temp.Anterior = _inicio;

            _count++;
        }

        public void Dequeue()
        {
            Proceso temp = _ultimo.Anterior;

            if (_count != 0)
            {
                if (_count == 1)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo = temp;
                    _ultimo.Siguiente = null;
                }
                _count--;
            }
        }

        public Proceso Peek()
        {
            Proceso temp = Ultimo;
            return temp;
        }
    }
}
