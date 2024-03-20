namespace DesafioPratico;

public class SegundoExercicio
{
    public static void ConcatenaNomeSobrenome()
    {
        var nome = "";
        var sobrenome = "";


        Console.WriteLine("Digite o seu nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o seu sobrenome:");
        sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome concatenado: {nome} {sobrenome}");
    } 
}
