using MySampleApplication.Helpers;

namespace MySampleApplication.UnitTests
{
    public class PasswordValidationHelperTests
    {

        [Theory]
        [InlineData("password", false)]
        [InlineData("1", false)]
        [InlineData("12", false)]
        [InlineData("1234", false)]
        [InlineData("12345678", false)]
        [InlineData("123456789", true)]
        [InlineData("Password!", true)]
        public void Password_Must_Be_More_Than_8_Characters(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

    }
}