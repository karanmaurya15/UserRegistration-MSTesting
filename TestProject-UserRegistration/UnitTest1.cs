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
        public void TestPasswordRule1()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Password("Saurabh13");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordRule2()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Password("sauraBhChau");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordRule3()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Password("sauraBh13k");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPasswordRule4()
        {
            UserRegistration user = new UserRegistration();
            bool result = user.Password("sauraBh@13k");
            Assert.IsTrue(result);
        }
    }
}