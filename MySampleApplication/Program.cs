// See https://aka.ms/new-console-template for more information

using MySampleApplication.Helpers;

Console.WriteLine("This is a password validation test application.");
var passwordValidator = new PasswordValidator();
var isValid = passwordValidator.IsPasswordValid("Password");
Console.WriteLine(isValid.ToString());