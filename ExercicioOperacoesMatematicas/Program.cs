namespace ExercicioOperacoesMatematicas;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Informe o primeiro número decimal: ");
            double numero1 = double.Parse(Console.ReadLine());
        
            Console.WriteLine("Informe o segundo número decimal: ");
            double numero2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a operação: 1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 5 - Média");
            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Resultado: ");
            
            switch (opcao)
            {
                case 1: Console.WriteLine($"Resultado: {Operacoes.Soma(numero1, numero2)}"); break;
                case 2: Console.WriteLine($"Resultado: {Operacoes.Subtracao(numero1, numero2)}"); break;
                case 3: Console.WriteLine($"Resultado: {Operacoes.Multiplicacao(numero1, numero2)}"); break;
                case 4: Console.WriteLine($"Resultado: {Operacoes.Divisao(numero1, numero2)}"); break;
                case 5: Console.WriteLine($"Resultado: {Operacoes.Media(numero1, numero2)}"); break;
                default: Console.WriteLine("Operação inválida"); break;
            }
            
            Console.WriteLine("Digite S para sair ou qualquer outra tecla para continuar...");
            ConsoleKeyInfo execucao =  Console.ReadKey();
            Console.Clear();

            if (execucao.Key == ConsoleKey.S)
            {
                Console.WriteLine("Fim do programa...");
                break;
            }
        }
    }
}