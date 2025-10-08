using System;
using System.Collections.Generic;
using System.Linq;
using MVPSampleProject.Models;

namespace MVPSampleProject.Data
{
    public class UserRepository
    {
        private static List<User> _users = User.Users;

        public List<User> GetAllUsers() => _users;

        public void AddUser(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null) _users.Remove(user);
        }

        public void UpdateUser(int id, string name, string email)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.Name = name;
                user.Email = email;
            }
        }

        // Basit filtreleme (JQL benzeri)
        public List<User> QueryUsers(string query)
        {
            
            var parts = query.Split('=');
            if (parts.Length != 2) return _users;

            string field = parts[0].Trim();
            string value = parts[1].Trim();

            switch (field)
            {
                case "Name":
                    return _users.Where(u => u.Name.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                case "Email":
                    return _users.Where(u => u.Email.Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
                default:
                    return _users;
            }
        }
    }
}