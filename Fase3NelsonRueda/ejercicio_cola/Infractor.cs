using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3NelsonRueda.ejercicio_cola
{
    internal class Infractor
    {

        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Direccion { get; set; }
        public string Placa { get; set; }
        public string TipoAutomotor { get; set; }
        public int AnioMatricula { get; set; }
        public DateTime FechaComparendo { get; set; }
        public int DiasDesdeExpedicion { get; set; }
        public decimal ValorComparendo { get; set; }



        public decimal CalcularValorConDescuento()
        {
            decimal valorBase = 450000;
            decimal descuento = 0;

            if (DiasDesdeExpedicion < 10)
            {
                descuento = 0.5m;
            }
            else if (DiasDesdeExpedicion < 20)
            {
                descuento = 0.25m;
            }
            else if (DiasDesdeExpedicion < 30)
            {
                descuento = 0.1m;
            }

            return valorBase * (1 - descuento);
        }

    }
}
