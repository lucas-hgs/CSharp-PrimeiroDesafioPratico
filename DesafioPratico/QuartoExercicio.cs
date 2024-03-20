namespace DesafioPratico;

public class QuartoExercicio
{
    public static void ContadorDeCaracteres()
    {
        Console.WriteLine("\n########################################");

        Console.WriteLine("\nEscreva a sua palavra e / ou frase para contar os caracteres:");
        string words = Console.ReadLine();


        Console.WriteLine("\nO total de caracteres foi de: " + words.Replace(" ", "").Length);

        Console.WriteLine("\n########################################");
    }
}
