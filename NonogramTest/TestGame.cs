using Nonogram.Database;
using Nonogram.Models;

namespace NonogramTest
{
    [TestClass]
    public sealed class TestGame
    {
        private string _filePath = "../../../users.json";
        JsonUserDatabase db = new();

        /// <summary>
        /// Generates a game with random seed and check if hint max is higher than 0
        /// </summary>
        [TestMethod]
        public void TestGameCreateWithoutSeed()
        {
            Game game = new Game(5);

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Seed);
            Assert.IsNotNull(game.ColHints);
            Assert.IsNotNull(game.RowHints);

            Assert.IsTrue(game.ColHintMax > 0);
            Assert.IsTrue(game.RowHintMax > 0);
        }

        /// <summary>
        /// Generates a game with a seed and checks that the hints and max hints are set
        /// </summary>
        [TestMethod]
        public void TestGameCreatWithSeed()
        {
            int seed = 123456;
            Game game = new Game(5, seed);

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Seed);
            Assert.IsNotNull(game.ColHints);
            Assert.IsNotNull(game.RowHints);

            Assert.IsTrue(game.Seed == seed);
            Assert.IsTrue(game.ColHintMax == 2);
            Assert.IsTrue(game.RowHintMax == 2);
        }

        /// <summary>
        /// Generated a game with a specific seed to check if the hints generated are the expected ones
        /// </summary>
        [TestMethod]
        public void TestGameGeneratedHints()
        {
            int seed = 123456;
            Game game = new Game(5, seed);

            Assert.IsNotNull(game);
            List<System.Drawing.Point> hints = game.GetPossibleHints();
            Assert.IsNotNull(hints);
            Assert.IsTrue(hints.Count == 11);
            Assert.IsTrue(hints[0] == new System.Drawing.Point(0, 4));
        }

        /// <summary>
        /// Validate game without correct solution
        /// </summary>
        [TestMethod]
        public void TestGameValidateIncompleteGame()
        {
            Game game = new Game(5);

            Assert.IsNotNull(game);
            Assert.IsFalse(game.Complete);

            game.ValidateGame();
            Assert.IsFalse(game.Complete);
        }

        /// <summary>
        /// Mark all correct cells as done and validate game
        /// </summary>
        [TestMethod]
        public void TestGameValidateCompletedGame()
        {
            Game game = new Game(5);

            Assert.IsNotNull(game);
            Assert.IsFalse(game.Complete);

            for (int i = 0; i < game.Solution.GetLength(0); i++)
                for (int j = 0; j < game.Solution.GetLength(1); j++)
                    if (game.Solution[i, j] == 1)
                        game.Marked[i, j] = EMarked.Done;

            game.ValidateGame();
            Assert.IsTrue(game.Complete);
        }


        /// <summary>
        /// Create a game with no seed
        /// Mark all correct cells as incorrect (wrong)
        /// Create a user with a GameHistory equel to the game data
        /// Encode the marked 2d array to a string
        /// Store user to database
        /// Assert that the latest history of database user is equel to the markedString
        /// </summary>
        [TestMethod]
        public void TestGameStoreMarkedToUser()
        {
            Game game = new Game(5);

            Assert.IsNotNull(game);

            for (int i = 0; i < game.Solution.GetLength(0); i++)
                for (int j = 0; j < game.Solution.GetLength(1); j++)
                    if (game.Solution[i, j] == 1)
                        game.Marked[i, j] = EMarked.Wrong;

            string markedString = game.EncodeMarked();
            Assert.IsInstanceOfType(markedString, typeof(string));
            Assert.IsTrue(markedString.Length > 0);

            User user = new User("TestGame", new DPassword("", ""), []);

            GameHistory history = new GameHistory();
            history.Seed = game.Seed;
            history.GridSize = game.GridSize;
            history.UpdatedAt = DateTime.Now;
            history.GameState = markedString;

            user.History.Add(history);

            db.SaveNewUser(user, _filePath);

            List<User> users = db.GetUsers(_filePath);
            Assert.IsNotNull(users);

            User dbUser = users[users.Count - 1];
            Assert.IsNotNull(dbUser);
            Assert.IsTrue(user.Name == dbUser.Name);

            Assert.IsTrue(dbUser.History.Last().GameState == markedString);
        }
    }
}
