using System.Collections.Generic;

namespace MVPSampleProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Sahte veri tabanı 
        public static List<User> Users = new List<User>();
    }
}