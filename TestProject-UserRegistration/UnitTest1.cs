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
        [TestMethod]
        public void TestEmailId()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.EmailId("abc.Karan@bl.co.in");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMobilNumber()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.MobileNumber("+91 9064278954");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPassword()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Password("Saurabh13");
            Assert.IsTrue(result);
        }
    }
}