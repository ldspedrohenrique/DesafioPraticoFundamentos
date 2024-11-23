namespace ExercicioNomeSobrenome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Agora informe seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        
        Console.WriteLine($"Nome completo: {nome} {sobrenome}.");
    }
}