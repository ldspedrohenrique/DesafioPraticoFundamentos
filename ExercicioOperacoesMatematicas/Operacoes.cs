namespace ExercicioOperacoesMatematicas;

public static class Operacoes
{
    public static double Soma(double numero1, double numero2) => numero1 + numero2;
    
    public static double Subtracao(double numero1, double numero2) => numero1 - numero2;
    
    public static double Multiplicacao(double numero1, double numero2) => numero1 * numero2;

    public static double Divisao(double numero1, double numero2)
    {
        if (numero2 == 0)
        {
            Console.WriteLine("Não é possível dividir um número por zero.");
            return double.NaN;
        }
        return numero1 / numero2;
    }
    
    public static double Media(double numero1, double numero2) => (numero1 + numero2) / 2;
}