using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace MySampleApplication.Helpers
{
    public interface IPasswordValidator
    {
        public bool IsPasswordValid(string password);
    }

    public class PasswordValidator : IPasswordValidator
    {

        /// <summary>
        /// This method validates a given string password for the following
        /// Must have more than 8 characters
        /// Must have at least one capital letter
        /// Must have at least one lowercase letter
        /// Must have a number
        /// Must have an underscore
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public virtual bool IsPasswordValid(string password)
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
