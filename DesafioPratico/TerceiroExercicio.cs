namespace DesafioPratico;

public class TerceiroExercicio
{
    public static void CalcularDoisValores()
    {
        double valueA = 0;
        double valueB = 0;
        double total = 0;

        Console.WriteLine("\n########################################");

        Console.WriteLine("\nInforme o primeiro valor:");
        valueA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nInforme o segundo valor:");
        valueB =  Convert.ToDouble(Console.ReadLine());

        total = valueA + valueB;
        Console.WriteLine("\nA soma dos dois valores: " + total);

        total = valueA - valueB;
        Console.WriteLine("\nA subtração dos dois valores: " + total);

        total = valueA * valueB;
        Console.WriteLine("\nA multiplicação dos dois valores: " + total);

        total = valueA / valueB;
        Console.WriteLine("\nA divisão entre os dois valores: " + total);

        total = (valueA + valueB) / 2;
        Console.WriteLine("\nA média dos dois valores: " + total);

        Console.WriteLine("\n########################################");
    }
}
