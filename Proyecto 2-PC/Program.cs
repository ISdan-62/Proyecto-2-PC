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