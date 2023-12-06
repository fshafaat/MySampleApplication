using System.Text.RegularExpressions;

namespace MySampleApplication.Helpers
{
    public static class PasswordValidationHelper
    {
        public static bool IsPasswordValid(string password)
        {
            var hasMoreThan8Characters = new Regex(@".{9,}");
            var hasACapitalLetter = new Regex(@"[A-Z]+");
            var hasALowerCaseLetter = new Regex(@"[a-z]+");
            var hasANumber = new Regex(@"[0-9]+");
            var hasAnUnderscore = new Regex(@"[_]");

            if (hasMoreThan8Characters.IsMatch(password)
                && hasACapitalLetter.IsMatch(password)
                && hasALowerCaseLetter.IsMatch(password)
                && hasANumber.IsMatch(password)
                && hasAnUnderscore.IsMatch(password))
                return true;

            return false;
        }
    }
}
