using NUnit.Framework;
using OrangeProject.Driver;

namespace OrangeProject
{
    public class Tests
    {
        LogIn _Login;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _Login = new LogIn();
        }

        [Test]
        public void Test1()
        {
            _Login.LoginUser("Admin", "admin123");
        }
    }
}