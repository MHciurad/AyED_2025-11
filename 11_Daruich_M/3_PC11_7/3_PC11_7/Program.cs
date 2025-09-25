using System;

class BorderlandsMVM
{
    static int maxPersonajes = 20;
    static int cantidad = 0;

    // Arrays paralelos
    static string[] nombres = new string[maxPersonajes];
    static string[] sagas = new string[maxPersonajes];
    static int[] fuerzas = new int[maxPersonajes];
    static int[] defensas = new int[maxPersonajes];
    static bool[] esHeroe = new bool[maxPersonajes];

    // 1. Nuevo personaje
    static void NuevoPersonaje()
    {
        if (cantidad >= maxPersonajes)
        {
            Console.WriteLine("No se pueden agregar más personajes (máx. 20).");
            return;
        }

        Console.Write("Ingrese nombre del personaje: ");
        string nombre = Console.ReadLine();

        // Validar duplicados
        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Ya existe un personaje con ese nombre.");
                return;
            }
        }

        nombres[cantidad] = nombre;

        Console.Write("Ingrese saga/facción: ");
        sagas[cantidad] = Console.ReadLine();

        Console.Write("Ingrese fuerza (entero): ");
        fuerzas[cantidad] = int.Parse(Console.ReadLine());

        Console.Write("Ingrese defensa (entero): ");
        defensas[cantidad] = int.Parse(Console.ReadLine());

        Console.Write("¿Es héroe? (s/n): ");
        string opcion = Console.ReadLine().ToLower();
        esHeroe[cantidad] = opcion == "s";

        cantidad++;
        Console.WriteLine("Personaje creado exitosamente.");
    }

    // 2. Consultar personaje
    static void ConsultarPersonaje()
    {
        Console.Write("Ingrese el nombre del personaje a consultar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                MostrarUnPersonaje(i);
                return;
            }
        }

        Console.WriteLine("No se encontró el personaje.");
    }

    static void MostrarUnPersonaje(int i)
    {
        Console.WriteLine("\n--- " + nombres[i] + " ---");
        Console.WriteLine("Saga/Facción: " + sagas[i]);
        Console.WriteLine("Fuerza: " + fuerzas[i]);
        Console.WriteLine("Defensa: " + defensas[i]);
        Console.WriteLine("Rol: " + (esHeroe[i] ? "Héroe" : "Villano"));
    }

    // 3. Modificar personaje
    static void ModificarPersonaje()
    {
        Console.Write("Ingrese el nombre del personaje a modificar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Nueva fuerza: ");
                fuerzas[i] = int.Parse(Console.ReadLine());

                Console.Write("Nueva defensa: ");
                defensas[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Personaje modificado.");
                return;
            }
        }

        Console.WriteLine("No se encontró el personaje.");
    }

    // 4. Eliminar personaje
    static void EliminarPersonaje()
    {
        Console.Write("Ingrese el nombre del personaje a eliminar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < cantidad - 1; j++)
                {
                    nombres[j] = nombres[j + 1];
                    sagas[j] = sagas[j + 1];
                    fuerzas[j] = fuerzas[j + 1];
                    defensas[j] = defensas[j + 1];
                    esHeroe[j] = esHeroe[j + 1];
                }

                cantidad--;
                Console.WriteLine("Personaje eliminado.");
                return;
            }
        }

        Console.WriteLine("No se encontró el personaje.");
    }

    // 5. Mostrar todos los personajes ordenados alfabéticamente
    static void MostrarTodos()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay personajes cargados.");
            return;
        }

        string[] nombresOrdenados = new string[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            nombresOrdenados[i] = nombres[i];
        }

        Array.Sort(nombresOrdenados);

        Console.WriteLine("\nLista de personajes:");
        foreach (string nombre in nombresOrdenados)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == nombre)
                {
                    MostrarUnPersonaje(i);
                }
            }
        }
    }

    // Menú principal
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n=== Borderlands Multiverse Manager ===");
            Console.WriteLine("1. Nuevo Personaje");
            Console.WriteLine("2. Consultar Personaje");
            Console.WriteLine("3. Modificar Personaje");
            Console.WriteLine("4. Eliminar Personaje");
            Console.WriteLine("5. Mostrar Todos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

            switch (opcion)
            {
                case 1: NuevoPersonaje(); break;
                case 2: ConsultarPersonaje(); break;
                case 3: ModificarPersonaje(); break;
                case 4: EliminarPersonaje(); break;
                case 5: MostrarTodos(); break;
                case 6: Console.WriteLine("Saliendo del programa..."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }

        } while (opcion != 6);
    }
}
