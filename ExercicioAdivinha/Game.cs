namespace ExercicioAdivinha
{
    public class Game
    {
        private int number;
        private int remaining_tries = 10;

        public Game(int theNumber) 
        {
            number = theNumber;
        }

        public int getNumber() {
            return number;
        }

        public int getRemainingTries()
        {
            return remaining_tries;
        }
    
        public bool guessNumber(int n)
        {
            if (!(remaining_tries > 1)) {
                Console.WriteLine("Voce usou todas as suas tentativas!");
                return false;
            }
            remaining_tries--;
            if (number==n)
            {
                Console.WriteLine("Voce adivinhou o numero!");
                return false;
            }

            if(n>number)
            {
                Console.WriteLine("Muito alto");
            }
            if (n < number)
            {
                Console.WriteLine("Muito baixo");
            }

            Console.WriteLine("Número incorreto, tente novamente.");
            return true;
        }
    }
}
