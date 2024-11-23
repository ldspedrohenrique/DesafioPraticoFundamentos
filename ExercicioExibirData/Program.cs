namespace ExercicioExibirData;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("__________________________________________________");
        Console.WriteLine("Informe de que jeito deseja imprimir a data atual:");
        Console.WriteLine("1 - Formato completo.");
        Console.WriteLine("2 - Formato suficiente.");
        Console.WriteLine("3 - Horario padrão.");
        Console.WriteLine("4 - Data padrão.");
        Console.WriteLine("5 - Para sair.");
        Console.WriteLine("__________________________________________________");

        ConsoleKeyInfo opcao =  Console.ReadKey();
        Console.Clear();

        if (opcao.Key == ConsoleKey.D5)
        {
            Console.WriteLine("Fim do programa...");
            return;
        }
            
        Console.WriteLine(DataEHora.DataHora(opcao: opcao));
    }
}