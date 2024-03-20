namespace DesafioPratico;

public class PrimeiroExercicio
{
    public static void BoasVindas()
    {
        var nome = "";
        while (nome == "") { 
            Console.WriteLine("Qual é o seu nome?");

            nome = Console.ReadLine();

            if (nome == null)
            {
                Console.WriteLine("Nome vazio, digite o seu nome:");
                nome = Console.ReadLine();
            } 
            else
            {
                Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
            }
        }
    }
}
