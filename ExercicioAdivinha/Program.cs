using ExercicioAdivinha;

namespace ExercicioAdivinha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
            {
                bool isGameFinished = false;
                DisplayMenu();

                while (!isGameFinished)
                {
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "0":
                            isContinue = false;
                            isGameFinished = true;
                            break;
                        case "1":
                            GuessGame();
                            isGameFinished = true;
                            break;
                        case "2":
                            ConvertMetrosParaMilimetros();
                            isGameFinished = true;
                            break;
                        case "3":
                            Soma();
                            isGameFinished = true;
                            break;
                        default:
                            Console.WriteLine("Por favor selecione uma opção válida.");
                            break;
                    }
                }
            }
        }

        static void GuessGame()
        {
            Random random = new Random();
            bool isContinue = true;
            while (isContinue)
            {
                bool isRunning = true;
                Game game = new Game(random.Next(0, 100));
                Console.WriteLine("Insira um número de 0 a 100");
                while (isRunning)
                {
                    Console.WriteLine($"Você tem {game.getRemainingTries()} chances!");
                    while (true)
                    {
                        int number;
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            if (number >= 0 && number <= 100)
                            {
                                isRunning = game.guessNumber(number);
                                break;
                            }
                        }
                        Console.WriteLine("Valor incorreto, por favor entre com um número de 0 a 10");
                    }
                }

                Console.WriteLine("Deseja continuar | sim/nao");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input != "")
                    {
                        if (input == "sim" || input == "nao")
                        {
                            isContinue = input == "sim" ? true : false;
                            break;
                        }

                    }
                    Console.WriteLine("Por favor inserir um valor válido.");
                }

            }
        }

        static void ConvertMetrosParaMilimetros()
        {
            Console.WriteLine("Digite o valor em metros:");
            double metros = Convert.ToDouble(Console.ReadLine());

            double milimetros = MetrosParaMilimetros(metros);

            Console.WriteLine($"{metros} metros equivalem a {milimetros} milímetros.");
        }

        static void Soma()
        {
            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 + num2;

            Console.WriteLine($"A soma de {num1} e {num2} é igual a {resultado}.");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Por favor selecione uma opção:");
            Console.WriteLine("0. Fechar menu");
            Console.WriteLine("1. Jogo de adivinhar");
            Console.WriteLine("2. Converter metros para milímetros");
            Console.WriteLine("3. Soma de dois números");
        }

        static double MetrosParaMilimetros(double metros)
        {
            return metros * 1000;
        }
    }
}
