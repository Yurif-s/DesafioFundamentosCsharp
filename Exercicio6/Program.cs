using System.Globalization;

class Program
{
    public static void Main()
    {
        Console.Write("Data no formato completo: ");
        var data = DateTime.Now;
        var dataCompleta = data.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine(dataCompleta);

        Console.Write("Data no formato d/m/a: ");
        var dataEmBarras = data.ToString("d/MM/yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine(dataEmBarras);

        Console.Write("Horário no formato de 24 horas: ");
        var dataApenasHoras = data.ToString("HH:mm", new CultureInfo("pt-BR"));
        Console.WriteLine(dataApenasHoras);

        Console.Write("Data com o mês por extenso: ");
        var dataMesExtenso = data.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine(dataMesExtenso);

    }
}