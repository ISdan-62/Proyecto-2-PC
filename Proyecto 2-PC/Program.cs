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

class Pieza
{
    public int FILA;
    public int COLUMNA;
    public string COLOR;
    public string TIPO;
    public string SIMBOLO;
    public bool VIVA;

    public Pieza(int fila, int columna, string color, string tipoPieza, string simboloPieza)
    {
        FILA = fila;
        COLUMNA = columna;
        COLOR = color;
        TIPO = tipoPieza;
        SIMBOLO = simboloPieza;
        VIVA = true;
    }

    public virtual bool movimientoV(int nuevaFila, int nuevaColumna, Pieza[,] tablero)
    {
        return false;
    }

    public void mover(int nuevaFila, int nuevaColumna)
    {
        FILA = nuevaFila;
        COLUMNA = nuevaColumna;
    }

    public string mostrar()
    {
        return SIMBOLO;
    }
}

class Rey : Pieza
{

    public Rey(int fila, int columna, string color) : base(fila, columna, color, "Rey", tipoLetra(color))
    {

    }

    private static string tipoLetra(string color)
    {
        if (color == "Blanco")
        {
            return "R";
        }
        else
        {
            return "r";
        }
    }

    public override bool movimientoV(int nuevaFila, int nuevaColumna, Pieza[,] tablero)
    {
        int cambioFila = Math.Abs(nuevaFila - FILA);
        int cambioColumna = Math.Abs(nuevaColumna - COLUMNA);

        if (cambioFila <= 1 && cambioColumna <= 1)
        {

            if (cambioFila == 0 && cambioColumna == 0)
            {
                return false;
            }

            if (tablero[nuevaFila, nuevaColumna] == null || tablero[nuevaFila, nuevaColumna].COLOR != this.COLOR)
            {
                return true;
            }
        }

        return false;
    }
}