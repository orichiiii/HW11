using System;
using Task1;
using Xunit;

namespace HW11.xTests
{
    public class UserServiceTests
    {
        private UserService userService = new UserService();

        [Theory]
        [InlineData("admin", true)]
        [InlineData("system", true)]
        public void ValidateLogin_ReturnTrue(string login, bool expected)
        {
            var actualResult = userService.ValidateLogin(ref login);

            Assert.Equal(expected, actualResult);
        }

        [Theory]
        [InlineData("admin", true)]
        [InlineData("system", true)]
        public void IsLoginExist_ReturnTrue(string login, bool expected)
        {
            var actualResult = userService.ValidateLogin(ref login);

            Assert.Equal(expected, actualResult);
        }

        [Fact]
        public void IsLoginExist_ReturnFalse_IfLoginDoesNotExist()
        {
            var login = "Mary";

            var expectedResult = false;
            var actualResult = userService.IsLoginExist(login);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsPasswordCorrect_ReturnFalse_IfUserPasswordDoesNotExist()
        {
            var login = "admin";
            var password = "1234";

            var expectedResult = false;
            var actualResult = userService.IsPasswordCorrect(login, password);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsPasswordCorrect_ReturnTrue_IfUserPasswordExist()
        {
            var login = "admin";
            var password = "admin";

            var expectedResult = true;
            var actualResult = userService.IsPasswordCorrect(login, password);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsUserAdmin_ReturnTrue_IfUserIsAdmin()
        {
            var login = "admin";
            var password = "admin";

            var expectedResult = true;
            var actualResult = userService.IsUserAdmin(login, password);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsUserAdmin_ReturnFalse_IfUserIsNotAdmin()
        {
            var login = "Mary";
            var password = "12345";

            var expectedResult = false;
            var actualResult = userService.IsUserAdmin(login, password);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
