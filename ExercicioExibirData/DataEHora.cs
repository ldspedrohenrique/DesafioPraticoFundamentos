namespace ExercicioExibirData;

public static class DataEHora
{
    public static string DataHora(ConsoleKeyInfo opcao)
    {
        DateTime dataHora = DateTime.Now;

        string saidaSolicitada = opcao.Key switch
        {
            ConsoleKey.D1 => dataHora.ToString("F"),
            ConsoleKey.D2 => dataHora.ToString("d/M/yy"),
            ConsoleKey.D3 => dataHora.ToString("T"),
            ConsoleKey.D4 => dataHora.ToString("dd MMMM yyyy"),
            _ => "Opção inválida"
        };
        
        return saidaSolicitada;
    }
}