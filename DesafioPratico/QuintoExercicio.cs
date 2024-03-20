namespace DesafioPratico;

public class QuintoExercicio
{
    public static void PlacaVeicular()
    {
        Console.WriteLine("\n########################################");

        Console.WriteLine("\nEscreva a sua palavra e / ou frase para contar os caracteres:");
        string placa = Console.ReadLine();

        if(placa.Length < 7 || placa.Length > 7)
        {
            Console.WriteLine("Falso");
        }

        for(int i = 0; i < placa.Length; i++) {
            if(i < 3 && !Char.IsLetter(placa[i])) {
                Console.WriteLine("Falso!");
                break;
            }
            else if (i > 2 && Char.IsLetter(placa[i]))
            {
                Console.WriteLine("Falso!");
                break;
            }
            else if (i == 6)
            {
                Console.WriteLine("Verdadeiro!");
            }
        }
        Console.WriteLine("\n########################################");
    }
}
