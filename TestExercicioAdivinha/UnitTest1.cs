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
        public void Game_Correct_LastChance()
        {
            Game game = new Game(4);
            for (int i = 0; i < 8; i++)
            {
                game.guessNumber(3);
            }
            Assert.IsFalse(game.guessNumber(4));
        }

        [TestMethod]
        public void Game_Incorrect()
        {
            Game game = new Game(2);
            Assert.IsFalse(game.guessNumber(3));
        }
        [TestMethod]

        public void Game_OutOfTries()
        {
            Game game = new Game(40);
            for (int i = 0; i < 9; i++)
            {
                game.guessNumber(2);
            }
            Assert.IsTrue(game.guessNumber(3));
        }

        [TestMethod]
        public void Sum()
        {
            Sum sum = new Sum();
            Assert.AreEqual(7, sum.sum(3, 4));
        }

        [TestMethod]
        public void Sum_Incorrect()
        {
            Sum sum = new Sum();
            Assert.AreEqual(2, sum.sum(5, 4));
        }

        [TestMethod]
        public void Converter_Convert()
        {
            Converter converter = new Converter();
            Assert.AreEqual(4000.0, converter.convert(4));
        }

        [TestMethod]
        public void Converter_Convert_Fail()
        {
            Converter converter = new Converter();
            Assert.AreEqual(4000.0, converter.convert(7));
        }
    }
}