using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3NelsonRueda.ejercicio_Pila
{
    internal class PilaClientes
    {// Declaración de la clase PilaClientes.

        // Declaración de la propiedad privada de tipo Stack<Cliente>.
        private Stack<Cliente> Clientes { get; set; }

        // Constructor de la clase PilaClientes.
        public PilaClientes()
        {
            // Inicializa la propiedad Clientes como una nueva pila de clientes.
            Clientes = new Stack<Cliente>();
        }

        // Método que agrega un cliente a la pila.
        public void AgregarCliente(Cliente cliente)
        {
            // Agrega el cliente a la pila utilizando el método Push.
            Clientes.Push(cliente);
        }

        // Método que elimina el último cliente agregado a la pila.
        public void EliminarCliente()
        {
            // Verifica que la pila contenga al menos un elemento antes de eliminar el último cliente agregado.
            if (Clientes.Count > 0)
            {
                Clientes.Pop();
            }
        }

        // Método que calcula el total de pagos de los clientes en la pila.
        public decimal ObtenerTotalPagos()
        {
            // Utiliza la función Sum de LINQ para calcular el total de pagos de los clientes en la pila.
            return Clientes.Sum(c => c.ValorMensual);
        }

        // Método que retorna una lista con todos los clientes en la pila.
        public List<Cliente> ObtenerClientes()
        {
            // Retorna una lista con todos los clientes en la pila utilizando el método ToList de LINQ.
            return Clientes.ToList();
        }
    }


}


