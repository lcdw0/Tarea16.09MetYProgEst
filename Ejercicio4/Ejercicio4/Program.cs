namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo para almacenar los contadores de los diferentes rangos salariales
            int[] rangos = new int[9];

            // Continuar ingresando ventas hasta que el usuario decida detenerse
            while (true)
            {
                Console.WriteLine("Ingrese las ventas brutas del vendedor (o -1 para finalizar): ");
                decimal ventasBrutas = decimal.Parse(Console.ReadLine());

                // Salir del bucle si se ingresa -1
                if (ventasBrutas == -1)
                {
                    break;
                }

                // Calcular el salario: $200 mas el 9% de las ventas brutas
                decimal salario = 200 + (ventasBrutas * 0.09m);

                // Truncar el salario a la parte entera
                int salarioEntero = (int)salario;

                // Determinar el rango correspondiente
                if (salarioEntero >= 200 && salarioEntero <= 299)
                    rangos[0]++;
                else if (salarioEntero >= 300 && salarioEntero <= 399)
                    rangos[1]++;
                else if (salarioEntero >= 400 && salarioEntero <= 499)
                    rangos[2]++;
                else if (salarioEntero >= 500 && salarioEntero <= 599)
                    rangos[3]++;
                else if (salarioEntero >= 600 && salarioEntero <= 699)
                    rangos[4]++;
                else if (salarioEntero >= 700 && salarioEntero <= 799)
                    rangos[5]++;
                else if (salarioEntero >= 800 && salarioEntero <= 899)
                    rangos[6]++;
                else if (salarioEntero >= 900 && salarioEntero <= 999)
                    rangos[7]++;
                else if (salarioEntero >= 1000)
                    rangos[8]++;
            }

            // Imprimir los resultados
            Console.WriteLine("\nNumero de vendedores en cada rango de salario:");
            Console.WriteLine($"$200 - $299: {rangos[0]}");
            Console.WriteLine($"$300 - $399: {rangos[1]}");
            Console.WriteLine($"$400 - $499: {rangos[2]}");
            Console.WriteLine($"$500 - $599: {rangos[3]}");
            Console.WriteLine($"$600 - $699: {rangos[4]}");
            Console.WriteLine($"$700 - $799: {rangos[5]}");
            Console.WriteLine($"$800 - $899: {rangos[6]}");
            Console.WriteLine($"$900 - $999: {rangos[7]}");
            Console.WriteLine($"$1000 o más: {rangos[8]}");
        }
    }
}
