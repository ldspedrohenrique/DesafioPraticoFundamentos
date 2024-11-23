namespace ExercicioContadorDeCaracteres;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra ou frase: ");
        string palavraOuFrase = Console.ReadLine();
        string palavraOuFraseSemEspacos = palavraOuFrase.Replace(" ", "");
        
        Console.WriteLine($"A palavra ou frase informada tem: {palavraOuFrase.Length} caracteres COM espaços.");
        Console.WriteLine($"A palavra ou frase informada tem: {palavraOuFraseSemEspacos.Length} caracteres SEM espaços.");
    }
}