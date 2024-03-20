namespace DesafioPratico;

class Program
{
    static void Main()
    {
        Console.WriteLine("Primeiro Desafio Prático C#");

        var option = "";

        while (option != "0") { 

            Console.WriteLine("\nEscolha a opção que você deseja:");

            Console.WriteLine("\n1: Boas-Vindas");
            Console.WriteLine("\n2: Concatenar seu nome e sobrenome");
            Console.WriteLine("\n3: Operações matemáticas com 2 números");
            Console.WriteLine("\n4: Contador de caracteres");
            Console.WriteLine("\n5: Verificador de placa de veículo");
            Console.WriteLine("\n6: Data de hoje em diferentes formatos\n");

            option = Console.ReadLine();


            switch (option)
            {
                case "0":
                    {
                        Console.WriteLine("\nO programa foi encerrado! Até a próxima...");
                    }
                    break;
                case "1":
                    { 
                        PrimeiroExercicio.BoasVindas();
                    }
                    break;
                case "2":
                    {
                        SegundoExercicio.ConcatenaNomeSobrenome();
                    }
                    break;
                case "3":
                    {
                        TerceiroExercicio.CalcularDoisValores();
                    }
                    break;
                default: 
                    { 
                        Console.WriteLine("\nOpção desconhecida"); 
                    }
                    break;
            }
        }
    }
}