using System.Text.RegularExpressions;

namespace MySampleApplication.Helpers
{
    public static class PasswordValidationHelper
    {
        public static bool IsPasswordValid(string password)
        {
            var hasMoreThan8Characters = new Regex(@".{9,}");
            if (hasMoreThan8Characters.IsMatch(password))
                return true;

            return false;
        }
    }
}
