namespace DesafioPratico;

public class PrimeiroExercicio
{
    public static void BoasVindas()
    {
        var nome = "";
        while (nome == "") {
            Console.WriteLine("\n########################################");

            Console.WriteLine("\nQual é o seu nome?");

            nome = Console.ReadLine();

            if (nome == null)
            {
                Console.WriteLine("\nNome vazio, digite o seu nome:");
                nome = Console.ReadLine();
            } 
            else
            {
                Console.WriteLine($"\nOlá, {nome}! Seja muito bem-vindo(a)!");
            }

            Console.WriteLine("\n########################################");
        }
    }
}
