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

        public bool EliminarInfractor(string identificacion)
        {
            bool infractorEncontrado = false;
            Queue<Infractor> colaTemporal = new Queue<Infractor>();

            while (infractores.Count > 0)
            {
                Infractor infractorActual = infractores.Dequeue();
                if (infractorActual.Identificacion == identificacion)
                {
                    infractorEncontrado = true;
                }
                else
                {
                    colaTemporal.Enqueue(infractorActual);
                }
            }

            // Restaurar la cola de infractores
            infractores = colaTemporal;

            return infractorEncontrado;
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
