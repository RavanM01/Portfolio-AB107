using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountTask
{
    internal class User : IAccount
    {
        private static int _Id = 1;
        private readonly int _id;

        public User(string fullName, string email, string password)
        {
            _id = _Id; 
            _Id++;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public int Id { get { return _id; } }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool PasswordChecker(string password)
        {
            /*
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

            // Regex ilə şərtləri yoxlayırıq
            return Regex.IsMatch(password, pattern);

            */
            
            if (password.Length>=8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) 
            {
                return true;
            }
            return false;
                    
        }


        public void ShowInfo(User user)
        {
            Console.WriteLine($"User ID:{user.Id}\nFullName:{user.FullName}\nEmail:{user.Email}");
        }
    }
}
