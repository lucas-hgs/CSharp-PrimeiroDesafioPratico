namespace DesafioPratico;

public class SegundoExercicio
{
    public static void ConcatenaNomeSobrenome()
    {
        var nome = "";
        var sobrenome = "";

        Console.WriteLine("\n########################################");

        Console.WriteLine("\nDigite o seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("\nDigite o seu sobrenome:");
        sobrenome = Console.ReadLine();

        Console.WriteLine($"\nSeu nome concatenado: {nome} {sobrenome}");

        Console.WriteLine("\n########################################");
    } 
}
