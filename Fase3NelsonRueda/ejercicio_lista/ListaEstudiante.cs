using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3NelsonRueda.ejercicio_lista
{
    internal class ListaEstudiante
    {

        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public int Estrato { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Grado { get; set; }
        public bool UtilizaServicioPAE { get; set; }

        public ListaEstudiante(string tipoIdentificacion, string identificacion, string nombreCompleto, int estrato, DateTime fechaNacimiento, int grado, bool utilizaServicioPAE)
        {
            TipoIdentificacion = tipoIdentificacion;
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            Estrato = estrato;
            FechaNacimiento = fechaNacimiento;
            Grado = grado;
            UtilizaServicioPAE = utilizaServicioPAE;
        }
    }
}
