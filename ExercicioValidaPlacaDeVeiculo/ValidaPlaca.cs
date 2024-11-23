namespace ExercicioValidaPlacaDeVeiculo;

public static class ValidaPlaca
{
    public static bool PlacaValida(string placa)
    {
        string placaFormatada = placa.Replace("-", "").Trim();

        if (placaFormatada.Length != 7)
        {
            Console.WriteLine("Placa inválida.");
            return false;
        }

        string placaParteAlfabetica = placaFormatada.Substring(0, 3);
        string placaParteNumerica = placaFormatada.Substring(3, 4);

        foreach (char digito in placaParteAlfabetica)
        {
            bool resultadoConversaoAlfabetica = int.TryParse(digito.ToString(), out int resultadoAlfabetica);

            if (resultadoConversaoAlfabetica)
            {
                Console.WriteLine("Placa inválida!");
                return false;
            }
        }
        
        bool resultadoConversaoNumerica = int.TryParse(placaParteNumerica, out int resultadoNumerica);

        if (!resultadoConversaoNumerica)
        {
            Console.WriteLine("Placa inválida!");
            return false;
        }
        
        Console.WriteLine("Placa válida!");
        return true;
    }
}