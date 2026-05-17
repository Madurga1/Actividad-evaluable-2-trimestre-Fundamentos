List<Usuario> usuarios = new List<Usuario>();
Usuario usuarioActivo = null;

int opcion;

do
{
    if (usuarioActivo == null)
    {
        Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Iniciar sesión");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción: ");
    }
    else
    {
        Console.WriteLine($"\n=== MENÚ USUARIO: {usuarioActivo.Email} ===");
        Console.WriteLine("1. Registrar entrenamiento");
        Console.WriteLine("2. Listar entrenamientos");
        Console.WriteLine("3. Vaciar entrenamientos");
        Console.WriteLine("4. Cerrar sesión");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción: ");
    }

    opcion = int.Parse(Console.ReadLine());

    if (usuarioActivo == null)
    {
        switch (opcion)
        {
            case 1:
            Console.Write("Introduce tu correo: ");
                string email = Console.ReadLine();

                bool existe = false;
                foreach (Usuario u in usuarios)
                {
                    if (u.Email == email)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe)
                {
                    Console.WriteLine("Ya existe un usuario con ese correo.");
                }
                else
                {
                    Console.Write("Introduce tu contraseña: ");
                    string contrasena = Console.ReadLine();
                    usuarios.Add(new Usuario(email, contrasena));
                    Console.WriteLine("Usuario registrado correctamente.");
                }
                break;

            case 2:
             Console.Write("Introduce tu correo: ");
                string emailLogin = Console.ReadLine();
                Console.Write("Introduce tu contraseña: ");
                string contrasenaLogin = Console.ReadLine();

                foreach (Usuario u in usuarios)
                {
                    if (u.Email == emailLogin && u.Contraseña == contrasenaLogin)
                    {
                        usuarioActivo = u;
                        break;
                    }
                }

                if (usuarioActivo == null)
                    Console.WriteLine("Correo o Contraseña incorrectos.");
                else
                    Console.WriteLine($"Bienvenido, {usuarioActivo.Email}!");
                break;
            case 0:
                Console.WriteLine("Hasta luego!");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    else
    {
        switch (opcion)
        {
            case 1: // Registrar entrenamiento
                Console.Write("Distancia recorrida (km): ");
                double distancia = double.Parse(Console.ReadLine());
                Console.Write("Tiempo empleado (min): ");
                double tiempo = double.Parse(Console.ReadLine());
                usuarioActivo.Entrenamientos.Add(new Entrenamiento(distancia, tiempo));
                Console.WriteLine("Entrenamiento registrado.");
                break;

            case 2: // Listar entrenamientos
                if (usuarioActivo.Entrenamientos.Count == 0)
                {
                    Console.WriteLine("No hay entrenamientos registrados.");
                }
                else
                {
                    Console.WriteLine("\n--- Tus entrenamientos ---");
                    for (int i = 0; i < usuarioActivo.Entrenamientos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {usuarioActivo.Entrenamientos[i]}");
                    }
                }
                break;

            case 3: // Vaciar entrenamientos
                usuarioActivo.Entrenamientos.Clear();
                Console.WriteLine("Entrenamientos vaciados.");
                break;

            case 4: // Cerrar sesión
                Console.WriteLine($"Sesión cerrada. Hasta luego, {usuarioActivo.Email}!");
                usuarioActivo = null;
                break;

            case 0:
                Console.WriteLine("Hasta luego!");
                opcion = 0;
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
} while (opcion != 0);
