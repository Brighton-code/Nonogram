using Nonogram.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Nonogram.Models;

namespace Nonogram.Database
{
    public class JsonUserDatabase : IUser
    {
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { WriteIndented = true };

        public List<User> GetUsers(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<User>();

            List<User> tmp = JsonSerializer.Deserialize<List<User>>(json, _options);
            return tmp;
        }

        public void SaveToUser(User user, string filePath)
        {
            List<User> users = GetUsers(filePath);
            int indx = users.FindIndex(u => u.Name == user.Name);

            if (indx != -1)
                users[indx] = user;

            string json = JsonSerializer.Serialize(users, _options);
            File.WriteAllText(filePath, json);
        }

        public void SaveNewUser(User user, string filePath)
        {
            List<User> users = GetUsers(filePath);
            users.Add(user);

            string json = JsonSerializer.Serialize(users, _options);
            File.WriteAllText(filePath, json);
        }
    }
}
