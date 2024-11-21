class Questao2
{
    public static void Main()
    {
        // Questão 2
        Console.WriteLine("Digite seu primeiro nome");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome");
        var sobrenome = Console.ReadLine();

        var nomeCompleto = nome + " " + sobrenome;
        Console.WriteLine($"Seu nome completo é {nomeCompleto}");

    }
}
