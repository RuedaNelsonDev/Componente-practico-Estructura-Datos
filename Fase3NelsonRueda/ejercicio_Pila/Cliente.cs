using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3NelsonRueda.ejercicio_Pila
{
    // Declaración de la clase Cliente.
    internal class Cliente
    {
        // Propiedades públicas de la clase Cliente.
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Estrato { get; set; }
        public DateTime MesAfiliacion { get; set; }
        public string Categoria { get; set; }
        public int VelocidadInternet { get; set; }
        public decimal ValorMensual { get; set; }

        // Constructor de la clase Cliente.
        public Cliente(string identificacion, string nombre, string direccion, int estrato, DateTime mesAfiliacion, string categoria, int velocidadInternet)
        {
            // Asignación de valores a las propiedades del cliente.
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            Estrato = estrato;
            MesAfiliacion = mesAfiliacion;
            Categoria = categoria;
            VelocidadInternet = velocidadInternet;
            ValorMensual = CalcularValorMensual();
        }

        // Método privado que calcula el valor mensual que debe pagar el cliente.
        private decimal CalcularValorMensual()
        {
            decimal valorBase = 0;
            decimal descuento = 0;

            // Calcula el valor base dependiendo de la velocidad de Internet y la categoría del cliente.
            switch (VelocidadInternet)
            {
                // Si la velocidad de Internet es de 5 Mbps
                case 5:
                    // El valor base se define como 20000 si el cliente es urbano y 30000 si el cliente es rural
                    valorBase = Categoria == "Urbano" ? 20000 : 30000;
                    break;

                // Si la velocidad de Internet es de 10 Mbps
                case 10:
                    // El valor base se define como 30000 si el cliente es urbano y 40000 si el cliente es rural
                    valorBase = Categoria == "Urbano" ? 30000 : 40000;
                    break;

                // Si la velocidad de Internet es de 20 Mbps
                case 20:
                    // El valor base se define como 45000 si el cliente es urbano y 55000 si el cliente es rural
                    valorBase = Categoria == "Urbano" ? 45000 : 55000;
                    break;

                // Si la velocidad de Internet es de 50 Mbps
                case 50:
                    // El valor base se define como 60000 si el cliente es urbano y 70000 si el cliente es rural
                    valorBase = Categoria == "Urbano" ? 60000 : 70000;
                    break;
            }



            // Calcula el descuento dependiendo del estrato del cliente.
            switch (Estrato)
            {
                // Si el estrato del cliente es 1, 2 o 3
                case 1:
                case 2:
                case 3:
                    // El descuento se define como el 15% del valor base
                    descuento = 0.15m;
                    break;

                // Si el estrato del cliente es 4, 5 o 6
                case 4:
                case 5:
                case 6:
                    // El descuento se define como el 10% del valor base
                    descuento = 0.10m;
                    break;
            }



            // Calcula el valor mensual a partir del valor base y el descuento.
            return valorBase * (1 - descuento);
        }
    }

}
