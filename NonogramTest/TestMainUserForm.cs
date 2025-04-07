using Nonogram;
using Nonogram.Models;
using System.Windows.Forms;

namespace NonogramTest
{
    [TestClass]
    public sealed class TestMainUserForm
    {
        Main form = new Main();

        /// <summary>
        /// Test that label changes text when user gets updated
        /// 
        /// ** Had to sleep and update form otherwise it was too fast
        /// </summary>
        [TestMethod]
        public void TestRun()
        {
            form.Show();
            form.Update();

            User user = new User("TestUser", new DPassword("", ""), []);

            form.Invalidate();
            Thread.Sleep(100);
            ChangeUser(null);
            form.Invalidate();
            Thread.Sleep(100);
            AssertNullUser();
            form.Invalidate();
            Thread.Sleep(100);
            AssertUserLabel("label1");
            form.Invalidate();
            Thread.Sleep(100);
            ChangeUser(user);
            form.Invalidate();
            Thread.Sleep(100);
            AssertUserLabelVisibile();
            form.Invalidate();
            Thread.Sleep(100);
            AssertUserWithName(user.Name);
            form.Invalidate();
            Thread.Sleep(100);
            AssertUserLabel(user.Name);
            form.Invalidate();
            Thread.Sleep(100);

            form.Dispose();
        }

        public bool ChangeUser(User user)
        {
            Main.User = user;
            Main.ChangeNavUser(form.Controls);
            return true;
        }

        public void AssertNullUser()
        {
            Assert.IsNull(Main.User);
        }

        public void AssertUserWithName(string name)
        {
            Assert.IsNotNull(Main.User);
            Assert.AreEqual(name, Main.User.Name);
        }

        public void AssertUserLabel(string equels)
        {
            Control lbl = form.Controls.Find("lblUser", true).FirstOrDefault();
            Assert.IsTrue(lbl is Label);

            Assert.AreEqual(lbl.Text, equels);
        }

        public void AssertUserLabelVisibile()
        {
            Control lbl = form.Controls.Find("lblUser", true).FirstOrDefault();
            Assert.IsNotNull(lbl);
            Assert.IsTrue(lbl is Label);
            Assert.IsTrue(lbl.Visible);
        }

        public void AssertUserLabelInvisibile()
        {
            form.Invalidate();
            Control lbl = form.Controls.Find("lblUser", true).FirstOrDefault();
            Assert.IsNotNull(lbl);
            Assert.IsTrue(lbl is Label);
            Assert.IsTrue(lbl.Visible);
        }
    }
}

