class Questao3
{
    public static void Main()
    {
        // Questão 3
        Console.WriteLine("Digite o primeiro valor: "); 
        var valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        var valor2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Soma: ");
        Soma(valor1, valor2);
        Console.WriteLine("Subtração: ");
        Subtracao(valor1, valor2);
        Console.WriteLine("Multiplicação: ");
        Multiplicacao(valor1, valor2);
        Console.WriteLine("Divisão: ");
        Divisao(valor1, valor2);
        Console.WriteLine("Média: ");
        Media(valor1, valor2);
    }
    public static void Soma(double valor1, double valor2) => Console.WriteLine(valor1+valor2);
    public static void Subtracao(double valor1, double valor2) => Console.WriteLine(valor1 - valor2);
    public static void Multiplicacao(double valor1, double valor2) => Console.WriteLine(valor1 * valor2);
    public static void Divisao(double valor1, double valor2)
    {
        if (valor2 == 0)
        {
            Console.WriteLine("Impossível dividir por zero");
        }
        else
        {
            Console.WriteLine(valor1 / valor2);
        }
    }
    public static void Media(double valor1, double valor2) => Console.WriteLine((valor1+valor2)/2);
}