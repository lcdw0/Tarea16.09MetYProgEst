namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz de ventas: 5 productos (filas) y 4 vendedores (columnas)
            decimal[,] sales = new decimal[5, 4];

            // Entrada de ventas por vendedor y producto
            while (true)
            {
                Console.WriteLine("Ingrese el numero del vendedor (1-4, o 0 para finalizar): ");
                int vendedor = int.Parse(Console.ReadLine());

                // Si el numero de vendedor es 0, se detiene la entrada de datos
                if (vendedor == 0)
                    break;

                // Validar que el vendedor este en el rango de 1 a 4
                if (vendedor < 1 || vendedor > 4)
                {
                    Console.WriteLine("Numero de vendedor inválido. Intentelo de nuevo.");
                    continue;
                }

                Console.WriteLine("Ingrese el numero del producto (1-5): ");
                int producto = int.Parse(Console.ReadLine());

                // Validar que el producto este en el rango de 1 a 5
                if (producto < 1 || producto > 5)
                {
                    Console.WriteLine("Numero de producto invalido. Intentelo de nuevo.");
                    continue;
                }

                Console.WriteLine("Ingrese el valor total en dolares de la venta: ");
                decimal valorVenta = decimal.Parse(Console.ReadLine());

                // Acumular la venta en la matriz (ajustamos indices porque empiezan desde 0)
                sales[producto - 1, vendedor - 1] += valorVenta;
            }

            // Imprimir resultados en forma tabular
            Console.WriteLine("\nResumen de ventas del mes anterior:");
            Console.WriteLine("Producto\tVendedor 1\tVendedor 2\tVendedor 3\tVendedor 4\tTotal por producto");

            // Variables para totales
            decimal[] totalPorVendedor = new decimal[4]; // Para almacenar el total por vendedor
            decimal totalPorProducto;

            // Recorrer cada producto (fila)
            for (int i = 0; i < 5; i++)
            {
                totalPorProducto = 0;
                Console.Write($"Producto {i + 1}\t");

                // Recorrer cada vendedor (columna) para el producto actual
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{sales[i, j]:C}\t\t"); // Imprimir la venta
                    totalPorProducto += sales[i, j]; // Acumular ventas por producto
                    totalPorVendedor[j] += sales[i, j]; // Acumular ventas por vendedor
                }

                // Imprimir el total por producto
                Console.WriteLine($"{totalPorProducto:C}");
            }

            // Imprimir el total por vendedor
            Console.Write("Total por vendedor\t");
            decimal totalGeneral = 0;
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{totalPorVendedor[j]:C}\t");
                totalGeneral += totalPorVendedor[j]; // Acumular total general
            }

            // Imprimir el total general
            Console.WriteLine($"\nTotal general de ventas: {totalGeneral:C}");
        }
    }
}
