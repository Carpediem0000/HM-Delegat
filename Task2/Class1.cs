using static Task2.User;

namespace Task2
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string name, int age, double height, double weight, string login, string password)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            AuthDelegate auth = ChekValid;
            if (Authenticate(login, password, auth))
            {
                Login = login;
                Password = password;
            }
            else
            {
                Login = "user";
                Password = "0000";
            }
        }

        public delegate bool AuthDelegate(string username, string password);
        public bool ChekValid(string username, string password)
        {
            if (username.Contains(" ") || username.Contains("!@#$") || password.Contains(" ") || password.Length < 7 || password.Length > 25)
            {
                Console.WriteLine("Login or Password incorrect");
                return false;
            }
            return true;
        }
        public bool ChekUser(string username, string password)
        {
            if (Login == username && Password == password) return true;
            return false;
        }
        public static bool Authenticate(string username, string password, AuthDelegate delegates)
        {
            return delegates(username, password);
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Name: {Name}\n";
            msg += $"Age: {Age}\n";
            msg += $"Height: {Height}\n";
            msg += $"Weight: {Weight}\n";
            msg += $"Login: {Login}\n";
            msg += $"Password: {Password}\n";
            return msg;
        }
    }
   
}
