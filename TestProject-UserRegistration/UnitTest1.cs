using UserRegistration_MSTesting;

namespace TestProject_UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.FirstName("Karan");

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestLastName()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.LastName("Kushwaha");

            Assert.IsTrue(result);
        }
    }
}