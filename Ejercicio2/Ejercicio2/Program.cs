namespace Ejercicio2
{
    internal class Program
    {
        // Funcion para imprimir el pase de abordaje
        static void ImprimirPase(int asiento, int seccion)
        {
            if (seccion == 1)
                Console.WriteLine($"Su asiento es el #{asiento} en la seccion de fumar.");
            else
                Console.WriteLine($"Su asiento es el #{asiento} en la seccion de no fumar.");
        }

        // Funcion para asignar asiento en una seccion
        static int AsignarAsiento(int[] asientos, int inicio, int fin)
        {
            for (int i = inicio; i < fin; i++)
            {
                if (asientos[i] == 0) // Si el asiento no esta asignado
                {
                    asientos[i] = 1;   // Asignamos el asiento
                    return i + 1;      // Retornamos el numero de asiento
                }
            }
            return -1; // No hay asientos disponibles
        }

        static void Main(string[] args)
        {
            int[] asientos = new int[10];  // Arreglo que representa los asientos (0 disponible, 1 ocupado)
            int opcion, asientoAsignado;

            while (true)
            {
                // Mostramos el menu al usuario
                Console.WriteLine("Por favor ingrese 1 para 'fumar'");
                Console.WriteLine("Por favor ingrese 2 para 'no fumar'");
                opcion = int.Parse(Console.ReadLine());

                // Verificamos la opcion elegida
                if (opcion == 1)
                {
                    // Intentamos asignar un asiento en la seccion de fumar (1 al 5)
                    asientoAsignado = AsignarAsiento(asientos, 0, 5);
                    if (asientoAsignado != -1)
                    {
                        ImprimirPase(asientoAsignado, 1);
                    }
                    else
                    {
                        // La seccion de fumar está llena
                        Console.WriteLine("La sección de fumar esta llena. ¿Le parece bien ser colocado en la seccion de no fumar? (1 = sí, 0 = no): ");
                        int cambiarSeccion = int.Parse(Console.ReadLine());
                        if (cambiarSeccion == 1)
                        {
                            asientoAsignado = AsignarAsiento(asientos, 5, 10);
                            if (asientoAsignado != -1)
                            {
                                ImprimirPase(asientoAsignado, 2);
                            }
                            else
                            {
                                Console.WriteLine("No hay asientos disponibles. El proximo vuelo sale en 3 horas.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El proximo vuelo sale en 3 horas.");
                        }
                    }
                }
                else if (opcion == 2)
                {
                    // Intentamos asignar un asiento en la seccion de no fumar (6 al 10)
                    asientoAsignado = AsignarAsiento(asientos, 5, 10);
                    if (asientoAsignado != -1)
                    {
                        ImprimirPase(asientoAsignado, 2);
                    }
                    else
                    {
                        // La sección de no fumar esta llena
                        Console.WriteLine("La seccion de no fumar esta llena. ¿Le parece bien ser colocado en la seccion de fumar? (1 = sí, 0 = no): ");
                        int cambiarSeccion = int.Parse(Console.ReadLine());
                        if (cambiarSeccion == 1)
                        {
                            asientoAsignado = AsignarAsiento(asientos, 0, 5);
                            if (asientoAsignado != -1)
                            {
                                ImprimirPase(asientoAsignado, 1);
                            }
                            else
                            {
                                Console.WriteLine("No hay asientos disponibles. El proximo vuelo sale en 3 horas.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El proximo vuelo sale en 3 horas.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida. Por favor ingrese 1 o 2.");
                }

                // Verificamos si todos los asientos estan llenos
                bool asientosLlenos = true;
                for (int i = 0; i < 10; i++)
                {
                    if (asientos[i] == 0)
                    {
                        asientosLlenos = false;
                        break;
                    }
                }

                if (asientosLlenos)
                {
                    Console.WriteLine("Todos los asientos estan llenos. El proximo vuelo sale en 3 horas.");
                    break; // Salimos del bucle porque todos los asientos estan ocupados
                }
            }
        }
    }
}
