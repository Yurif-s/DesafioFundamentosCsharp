class Questao4
{
    public static void Main()
    {
        // Questão 4
        Console.Write("Escreva as palavras: ");
        string palavras = Console.ReadLine();
        var caracteres = palavras.Replace(" ", "").Count();
        Console.WriteLine($"\"{palavras}\" contém {caracteres} caracteres");
    }
}