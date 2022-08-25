using KinoProjektNikolaTrogrlic.Classes;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Linq;

namespace KinoProjektNikolaTrogrlic
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }
        public string LastName { get; set; }
        public bool ValidatedAccount { get; set; }
        public DateTime LastLogin { get; set; }

        public Image Image { get; set; }

        public byte[] Salt { get; set; }

        public byte[] ImageBytes { get; set; }

        public User()
        {

        }

        /*Overload pri dodavanju*/
        public User(string username, string password, string firstname, string lastname, string gender, Image image)
        {
            Username = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            ValidatedAccount = false;
            Gender = gender;
            LastLogin = DateTime.Now;
            Image = image;
        }

        /*Serijalizacija i deserijalizacija uz byte*/
        [JsonConstructor]
        public User(string username, string password, string firstname, string lastname, string gender, string validated, byte[] image)
        {
            Username = username;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            ValidatedAccount = Convert.ToBoolean(validated);
            Gender = gender;
            LastLogin = DateTime.Now;
            ImageBytes = image;
        }

        /*Overload za login attempt*/
        public User(string username, string password)
        {
            try
            {
                Username = username;
                Password = password;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string Name()
        {
            return FirstName + " " + LastName;
        }

        public static void ValidateInput(string username, string firstname, string lastname, string gender, string language)
        {
            if (username.Length < 5) {
                switch (language) {
                    case "hr":
                        throw new Exception("Korisničko ime mora imati barem 5 znakova");
                    default:
                        throw new Exception("Username must be at least 5 characters");
                }
            }
            if (firstname.Length <= 1 || firstname.Any(char.IsDigit)) 
                switch (language)
                {
                    case "hr":
                        throw new Exception("Unesite ispravno Ime");
                    default:
                        throw new Exception("Enter a valid First Name.");
                }
            if (lastname.Length <= 1 || lastname.Any(char.IsDigit))
                switch (language)
                {
                    case "hr":
                        throw new Exception("Unesite ispravno Prezime");
                    default:
                        throw new Exception("Enter a valid Last Name.");
                }
            if (gender.Length < 1)
            {
                switch (language)
                {
                    case "hr":
                        throw new Exception("Unesite ispravan Rod");
                    default:
                        throw new Exception("Enter a valid Gender");
                }
            }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
