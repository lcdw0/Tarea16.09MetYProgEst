namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos el generador de numeros aleatorios
            Random random = new Random();

            // Arreglo para almacenar la frecuencia de las sumas (de 2 a 12)
            int[] frecuenciaSuma = new int[11];

            // Realizamos 36,000 lanzamientos de los dados
            int totalLanzamientos = 36000;

            for (int i = 0; i < totalLanzamientos; i++)
            {
                // Simulamos los lanzamientos de dos dados
                int dado1 = random.Next(1, 7); // Dado con valores de 1 a 6
                int dado2 = random.Next(1, 7);

                // Calculamos la suma de los dados (dado1 + dado2)
                int suma = dado1 + dado2;

                // Incrementamos la frecuencia en el indice correspondiente (suma - 2)
                frecuenciaSuma[suma - 2]++;
            }

            // Imprimir los resultados en formato tabular
            Console.WriteLine("Suma\tFrecuencia");
            for (int suma = 2; suma <= 12; suma++)
            {
                Console.WriteLine($"{suma}\t{frecuenciaSuma[suma - 2]}");
            }

            // Determinar si los resultados son razonables
            double proporcionSiete = (double)frecuenciaSuma[7 - 2] / totalLanzamientos;
            Console.WriteLine($"\nAproximadamente el {(proporcionSiete * 100):F2}% de las sumas son 7.");

        }
    }
}
