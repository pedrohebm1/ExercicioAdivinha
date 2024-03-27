using ExercicioAdivinha;

public class Program
{
    public static void Main(string[] args)
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
                        Console.WriteLine("Valor incorreto, por favor entre com um numero de 0 a 10");
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
}