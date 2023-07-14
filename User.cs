using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;

namespace Group
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public int Telephone { get; set; }
        
        public User(string name,string password,string role,int tele)
        {
            UserName = name;
            Password = password;
            Role = role;
            Telephone = tele;
        }
        public User()
        {
            
        }
    }
}