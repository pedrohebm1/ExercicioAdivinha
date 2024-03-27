using ExercicioAdivinha;

namespace TestExercicioAdivinha
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Game_Correct()
        {
            Game game = new Game(4);
            Assert.IsFalse(game.guessNumber(4));
        }

        [TestMethod]
        public void Game_Incorrect()
        {
            Game game = new Game(2);
            Assert.IsTrue(game.guessNumber(3));
        }
        [TestMethod]

        public void Game_OutOfTries()
        {
            Game game = new Game(40);
            for(int i = 0; i < 10; i++)
            {
                game.guessNumber(2);
            }
            Assert.IsFalse(game.guessNumber(3));
        }

        [TestMethod]
        public void GuessNumber()
        {
            Game game = new Game(4);
            Assert.IsFalse(game.guessNumber(4));
        }
    }
}