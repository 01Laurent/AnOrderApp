using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnOrderApp
{
    class UserAccount //this is the users space, it contains; settings, language preference, email, password and seettings
    {
        //methods have to be private to store the users info secure
        private string? email;
        private string password;
        private string languagePreference;

        public class UserCredentials
        {
            public string email { get; set; }
            public string password { get; set; }
            public string languagePreference { get; set; }
        }

        public UserCredentials InputCredentials()
        {
            Console.Write("Enter your email: ");
            email = Console.ReadLine();

            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            Console.Write("Enter your language preference: ");
            languagePreference = Console.ReadLine();

            Console.WriteLine("Credentials set successfully");

            var response = new UserCredentials();

            response.email = email;
            response.password = password;
            response.languagePreference = languagePreference;

            return response;
        }

        public void DisplayCredentials(UserCredentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.email) || string.IsNullOrEmpty(credentials.password) || string.IsNullOrEmpty(credentials.languagePreference)) //if credentials ain't set, display a text to prompt the user to set
            {
                Console.WriteLine("Set up your credentials first to be able to log in.");
            }
            else
            { //read what the user input
                Console.WriteLine($"Your current email is: {credentials.email}");
                Console.WriteLine($"Your current password is: {credentials.password}");
                Console.WriteLine($"Your current language preference is: {credentials.languagePreference}");
            }

        }


        /// <summary>
        /// accepts old credentials and returns new credentials
        /// </summary>
        /// <returns>new user credentials</returns>
        public UserCredentials ResetCredentials()
        {
            Console.Write("Enter a new email: ");
            email = Console.ReadLine();

            Console.Write("Enter a new password: ");
            password = Console.ReadLine();

            Console.Write("Enter a new language preference: ");
            languagePreference = Console.ReadLine();

            Console.WriteLine("Your credentials reset successfully");

            var response = new UserCredentials();

            response.email = email;
            response.password = password;
            response.languagePreference = languagePreference;

            return response;
        }
    

    public void DisplaySettings()
    {
        string theme = "";
        string fontSize = ""; //*to check

        Console.WriteLine($"Settings:");
        Console.WriteLine($"1. Theme: {theme}");
        Console.WriteLine($"2. Font Size: {fontSize}");
    }
        public void ResetSettings(string settingChoice) //*
        {
            switch (settingChoice)
            {
                case "1":
                    Console.Write("Enter new Theme: ");
                    string? newTheme = Console.ReadLine();
                    ChangeTheme(newTheme);
                    break;
                case "2":
                    Console.Write("Enter new Font Size");
                    // the input string is converted to an integer and returns a boolean if the conversion was successful
                    // out allows the int.Parseto set the value for new size
                    // new size checks if the integer is greater than 0. The entire condition is only true if both parts are true
                    if (int.TryParse(Console.ReadLine(), out int newSize) && newSize > 0)
                    {
                        ChangeFontSize(newSize);
                    }
                    else
                    {
                        Console.WriteLine("Invalid font size. Please enter a positive integer");
                    }
                    break;
            }
        }
        public void ChangeFontSize(int newSize)
        {
            int fontSize = 0; //*to check
            fontSize = newSize;
            Console.WriteLine($"Font size changed to: {fontSize}");
        }
        public void ChangeTheme(string newTheme)
        {
            string theme = "";
            theme = newTheme;
        }
    }
    class CallingMethods //class for calling the methods above
    {
        UserAccount _account; //dependency injection
        public CallingMethods(UserAccount account)
        { //_account is a variable that has been assigned account and the dependency(account) has been passed as a parameter in the constructor
            _account = account;
        }
        public void AccountFunctions()
        {

            Console.WriteLine("Options:");
            Console.WriteLine("1. Input Initial Credentials");
            Console.WriteLine("2. View Credentials");
            Console.WriteLine("3. Reset Credentials");

            Console.Write("Select an option (1, 2, or 3): ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    var credentials = _account.InputCredentials();
                    _account.DisplayCredentials(credentials);
                    break;
                case "3":
                    var newCredentials = _account.ResetCredentials();
                    _account.DisplayCredentials(newCredentials);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
                    break;
            }
        }
    }
}
