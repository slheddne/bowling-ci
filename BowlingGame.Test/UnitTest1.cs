using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void can_create_game()
        {
            // Arrange
            var game = new Game();
        }

        [TestMethod]
        public void score_0_if_gutter_game()
        {
            // Arrange
            var game = new Game();

            // Act
            for (var i = 0; i < 20; i++)
                game.Roll(0);

            // Assert
            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void score_que_des_1()
        {
            // Arrange
            var game = new Game();

            // Act
            for (var i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            // Assert
            Assert.AreEqual(20, game.Score);


        }
    }
}