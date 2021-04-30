using NUnit.Framework;
using HW11;
using Task1;

namespace HW11.Tests
{
    public class UserserviceTests
    {
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            userService = new UserService();
        }

        [Test]
        [TestCaseAttribute("admin", true)]
        [TestCaseAttribute("system", true)]
        public void ValidateLogin_ReturnTrue(string login, bool expected)
        {
            var actualResult = userService.ValidateLogin(ref login);

            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        [TestCaseAttribute("admin", true)]
        [TestCaseAttribute("system", true)]
        public void IsLoginExist_ReturnTrue(string login, bool expected)
        {
            var actualResult = userService.ValidateLogin(ref login);

            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void IsLoginExist_ReturnFalse_IfLoginDoesNotExist()
        {
            var login = "Mary";

            var expectedResult = false;
            var actualResult = userService.IsLoginExist(login);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPasswordCorrect_ReturnFalse_IfUserPasswordDoesNotExist()
        {
            var login = "admin";
            var password = "1234";

            var expectedResult = false;
            var actualResult = userService.IsPasswordCorrect(login, password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsPasswordCorrect_ReturnTrue_IfUserPasswordExist()
        {
            var login = "admin";
            var password = "admin";

            var expectedResult = true;
            var actualResult = userService.IsPasswordCorrect(login, password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsUserAdmin_ReturnTrue_IfUserIsAdmin()
        {
            var login = "admin";
            var password = "admin";

            var expectedResult = true;
            var actualResult = userService.IsUserAdmin(login, password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void IsUserAdmin_ReturnFalse_IfUserIsNotAdmin()
        {
            var login = "Mary";
            var password = "12345";

            var expectedResult = false;
            var actualResult = userService.IsUserAdmin(login, password);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}