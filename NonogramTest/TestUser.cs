using System.Diagnostics;
using Nonogram.Database;
using Nonogram.Models;

namespace NonogramTest
{
    [TestClass]
    public sealed class TestUser
    {
        private string _filePath = "../../../users.json";
        JsonUserDatabase db = new();

        /// <summary>
        /// Assert that the users file does not exists.
        /// </summary>
        [TestMethod]
        [Priority(1), DoNotParallelize]
        public void TestNoUsersFile()
        {
            TestDeleteUserFile();
            Assert.IsFalse(File.Exists(_filePath));
        }

        /// <summary>
        /// Asserts that there are no users in file.
        /// </summary>
        [TestMethod]
        [Priority(2), DoNotParallelize]
        public void TestNoUsersInFile()
        {
            List<User> users = db.GetUsers(_filePath);

            Assert.IsTrue(users.Count == 0);
        }

        [TestMethod]
        [Priority(3), DoNotParallelize]
        public void TestInsertUserToFile()
        {
            User user = new User("TestInsert", new DPassword("", ""), []);
            db.SaveNewUser(user, _filePath);
        }

        /// <summary>
        /// Insert a new user into the database
        /// </summary>
        [TestMethod]
        [Priority(4), DoNotParallelize]
        public void TestUserInsertSaved()
        {
            User user = new User("TestInsert", new DPassword("", ""), []);
            List<User> users = db.GetUsers(_filePath);

            Assert.IsTrue(users.Count > 0);
            Assert.IsTrue(users.Find(u => u.Name == user.Name) != null);
        }

        /// <summary>
        /// Inserts a history into a user that already exists in the database
        /// and checks if the history is the same as the insert history
        /// </summary>
        [TestMethod]
        [Priority(5), DoNotParallelize]
        public void TestInsertHistoryToUser()
        {
            User user = new User("TestInsert", new DPassword("", ""), []);
            GameHistory history = new GameHistory();
            history.UpdatedAt = DateTime.Now;
            history.GridSize = 5;
            history.Seed = 12345;
            history.GameTime = new TimeSpan(10);
            history.GameState = new int[history.GridSize * history.GridSize].ToString();
            user.History.Add(history);

            db.SaveToUser(user, _filePath);

            List<User> users = db.GetUsers(_filePath);
            User dbUser = users.Find(u => u.Name == user.Name);

            Assert.IsNotNull(dbUser);
            Assert.IsTrue(dbUser.History.Count > 0);

            GameHistory dbUserHistory = dbUser.History.Find(h => h.GridSize == history.GridSize && h.Seed == history.Seed);
            Assert.IsNotNull(dbUserHistory);
            Assert.IsTrue(dbUserHistory.CreatedAt == history.CreatedAt);
        }


        /// <summary>
        /// Test that inserting new data to a "existing" users does not work if the users doesn't exists
        /// </summary>
        [TestMethod]
        [Priority(7), DoNotParallelize]
        public void TestInsertHistoryToUserThatDoesNotExists()
        {
            User user = new User("TestUserDoesntExistsHistory", new DPassword("", ""), []);
            GameHistory history = new GameHistory();
            history.UpdatedAt = DateTime.Now;
            history.GridSize = 5;
            history.Seed = 12345;
            history.GameTime = new TimeSpan(10);
            history.GameState = new int[history.GridSize * history.GridSize].ToString();
            user.History.Add(history);

            db.SaveToUser(user, _filePath);
            List<User> users = db.GetUsers(_filePath);
            User dbUser = users.Find(u => u.Name == user.Name);

            Assert.IsNull(dbUser);
        }


        /// <summary>
        /// Test that a user gets created
        /// </summary>
        [TestMethod]
        [Priority(8), DoNotParallelize]
        public void TestUserGet()
        {
            TestUserStore("TestUser");

            List<User> users = db.GetUsers(_filePath);
            Assert.IsNotNull(users);
            Assert.IsTrue(users.Count > 0);
        }

        [TestMethod]
        [Priority(9), DoNotParallelize]
        public void TestCreateTenUsers()
        {
            for (int i = 0; i < 10; i++)
            {
                TestUserStore("TestUser" + i);
            }

            List<User> users = db.GetUsers(_filePath);
            Assert.IsNotNull(users);
            Assert.IsTrue(users.Count > 9);
        }

        public void TestUserStore(string name)
        {
            DPassword password = User.HashPassword("Hello");
            User user = new User(name, password, []);

            db.SaveNewUser(user, _filePath);
        }

        [TestMethod]
        [Priority(99), DoNotParallelize]
        public void TestCleanupUsersFile()
        {
            TestDeleteUserFile();
        }

        public void TestDeleteUserFile()
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);

            //Assert.IsFalse(File.Exists(_filePath));
        }
    }
}
