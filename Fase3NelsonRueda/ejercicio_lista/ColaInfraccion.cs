using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fase3NelsonRueda.ejercicio_cola;

namespace Fase3NelsonRueda.ejercicio_lista
{
    internal class ColaInfraccion
    {
        private Queue<Infractor> infractores;

        public ColaInfraccion()
        {
            infractores = new Queue<Infractor>();
        }

        public void AgregarInfractor(Infractor infractor)
        {
            infractores.Enqueue(infractor);
        }

        public bool EliminarInfractor()
        {
            if (infractores.Count > 0)
            {
                infractores.Dequeue();
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Count()
        {
            return infractores.Count;
        }

        public IEnumerable<Infractor> ObtenerInfractores()
        {
            return infractores.ToList();
        }
    }
}
