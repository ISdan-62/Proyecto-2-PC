string Vadiacion1()
{
    string usuario;

    while (true)
    {
        Console.Write("Ingrese el usuario: ");
        usuario = Console.ReadLine();
        if (usuario == "JTello")
        {
            Console.WriteLine();
            Console.WriteLine("-------Usuario valido-------");
            return usuario;
        }
        else
        {
            Console.WriteLine("Uasio inválida");
            Console.WriteLine("Presione cualquier tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
string resultadoUsuario = Vadiacion1();

string Validacion2()
{
    string contrasenaCorrecta = "+Ma0An+PC";
    string ingreso;

    do
    {
        Console.WriteLine();
        Console.Write("Ingrese la contraseña: ");
        ingreso = LeerPassword();

        if (ingreso != contrasenaCorrecta)
        {
            Console.WriteLine();
            Console.WriteLine("Contraseña Invalida");
            Console.WriteLine("Presione cualquier tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("-------Contraseña valida-------");
        }

    } while (ingreso != contrasenaCorrecta);

    return ingreso;
}
string resultadoContrasena = Validacion2();

static string LeerPassword()
{
    string pass = "";
    ConsoleKeyInfo tecla;

    while (true)
    {
        tecla = Console.ReadKey(true);

        if (tecla.Key == ConsoleKey.Enter)
        {
            break;
        }
        else if (tecla.Key == ConsoleKey.Backspace)
        {
            if (pass.Length > 0)
            {
                pass = pass.Substring(0, pass.Length - 1);
                Console.Write("\b \b");
            }
        }
        else
        {
            pass += tecla.KeyChar;
            Console.Write("*");
        }
    }
    return pass;
}

int opcion;
bool correctaOpcion;
if (resultadoUsuario == "JTello" && resultadoContrasena == "+Ma0An+PC")
{
    do
    {
        Console.WriteLine();
        Console.WriteLine("MENU");
        Console.WriteLine("1. Iniciar partida ");
        Console.WriteLine("2. Ver reglas del juego");
        Console.WriteLine("3. Ver puntaje más alto");
        Console.WriteLine("4. Salir ");
        Console.WriteLine();
        Console.Write("Ingrese la opcion que desea realisar: ");
        correctaOpcion = int.TryParse(Console.ReadLine(), out opcion);
        switch (opcion)
        {
            case 1:
                {
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {

                    break;
                }
            case 4:
                {
                    Console.WriteLine("Salida");
                    break;
                }
            default:
                {
                    Console.WriteLine("Opcion Invalida");
                    break;
                }
        }
    } while (opcion != 4);
}

