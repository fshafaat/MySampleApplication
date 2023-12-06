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
        [InlineData("Password1234567_", true)]
        public void Password_Must_Be_More_Than_8_Characters(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("passwordislong", false)]
        [InlineData("123456789", false)]
        [InlineData("_PassWord12", true)]
        [InlineData("Reg__istration12!", true)]
        public void Password_Must_Has_At_Least_One_Capital_Letter(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("PASSWORD12!", false)]
        [InlineData("123456789", false)]
        [InlineData("PassW_ord12", true)]
        [InlineData("Reg_istration12!", true)]
        [InlineData("Pass_word!", false)]
        public void Password_Must_Has_At_Least_One_Lowercase_Letter(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("PASSWORDAbc", false)]
        [InlineData("123456789", false)]
        [InlineData("Password!", false)]
        [InlineData("PassWord12_", true)]
        [InlineData("Registration12!_", true)]
        public void Password_Must_Has_At_Least_One_Number(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("PASSWORDAbc", false)]
        [InlineData("123456789", false)]
        [InlineData("Password!", false)]
        [InlineData("PassWord12_", true)]
        [InlineData("Registration12!__", true)]
        public void Password_Must_Has_An_Underscore(string password, bool expected)
        {
            bool result = PasswordValidationHelper.IsPasswordValid(password);
            result.Should().Be(expected);
        }

    }
}