class Questao5
{
    public static void Main()
    {
        // Questão 5
        Console.WriteLine("Digite a placa do carro [XXX0000]: ");
        var placa = Console.ReadLine().Trim().ToLower();
        if (placa == null || placa.Length != 7)
        {
            Console.WriteLine("A placa não é válida");
        }
        else
        {
            bool letras = true;
            for (int i = 0; i < 3; i++)
            {
                if (!Char.IsLetter(placa[i]))
                {
                    letras = false;
                    break;
                }
            }
            bool numeros = true;
            for (int i = 3; i < 7; i++)
            {
                if (!Char.IsDigit(placa[i]))
                {
                    numeros = false;
                    break;
                }
            }
            if (letras && numeros)
            {
                Console.WriteLine("A placa é válida");
            }
            else
            {
                Console.WriteLine("A placa não é válida");
            }
        }


    }
}