using System.Globalization;

namespace DesafioPratico;

public class SextoDesafio
{
    public static void DataAgora()
    {
        DateTime todaysDate = DateTime.Now;
        var formattedDate = todaysDate.ToString("F", new CultureInfo("pt-BR"));

        Console.WriteLine("\n########################################");
        Console.WriteLine("\nApresentando a data atual em diferentes formatos:");
        Console.WriteLine($"\n{todaysDate.ToString("F", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"\n{todaysDate.ToString("d", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"\n{todaysDate.ToString("t", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"\n{todaysDate.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"))}");
        Console.WriteLine("\n########################################");
    }
}
