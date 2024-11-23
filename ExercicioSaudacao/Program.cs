namespace ExercicioSaudacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome: ");
        Console.WriteLine(Saudacao.Saudar(Console.ReadLine()));
    }
}