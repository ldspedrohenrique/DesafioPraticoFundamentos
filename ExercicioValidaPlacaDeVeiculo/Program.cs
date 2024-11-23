namespace ExercicioValidaPlacaDeVeiculo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma placa de veículo padrão (AAA-5555)");
        string placa = Console.ReadLine();
        ValidaPlaca.PlacaValida(placa);
    }
}