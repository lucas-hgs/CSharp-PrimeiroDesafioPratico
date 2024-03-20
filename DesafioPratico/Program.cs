namespace DesafioPratico;

class Program
{
    static void Main()
    {
        Console.WriteLine("Primeiro Desafio Prático C#");

        var option = "";

        while (option != "0") { 

            Console.WriteLine("Escolha a opção que você deseja:");

            Console.WriteLine("1: Boas-Vindas");
            Console.WriteLine("2: Concatenar seu nome e sobrenome");
            Console.WriteLine("3: Operações matemáticas com 2 números");
            Console.WriteLine("4: Contador de caracteres");
            Console.WriteLine("5: Verificador de placa de veículo");
            Console.WriteLine("6: Data de hoje em diferentes formatos");

            option = Console.ReadLine();


            switch (option)
            {
                case "0":
                    {
                        Console.WriteLine("O programa foi encerrado! Até a próxima...");
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
                default: 
                    { 
                        Console.WriteLine("Opção desconhecida"); 
                    }
                    break;
            }
        }
    }
}