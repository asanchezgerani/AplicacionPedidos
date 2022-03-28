using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libreriaPedidos;

namespace AplicacionPedidos
{
     class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            ControlPedidos.CrearPedido();

            do
            {
                Console.Clear();
                Console.WriteLine("1. Seleccionar el Cliente");
                Console.WriteLine("2. Agregar producto al pedido");
                Console.WriteLine("3. Eliminar producto del pedido");
                Console.WriteLine("4. Mostrar pedido ");
                Console.WriteLine("0. Salir ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ControlPedidos.SeleccionaCliente();
                        break;

                    case 2:
                        ControlPedidos.AgregaProductoAlPedido();
                        break;

                    case 3:
                        ControlPedidos.EliminaProductoDePedido();
                        break;

                    case 4:
                        ControlPedidos.MuestraPedido();
                        break;

                    default:
                        break;
                }


            } while (opcion != 0);
        }
    }
}
