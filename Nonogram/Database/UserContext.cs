using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Nonogram.Models;

namespace Nonogram.Database
{
    interface IUser
    {
        public void SaveToUser(User user, string filePath);
        public void SaveNewUser(User user, string filePath);
        public List<User> GetUsers(string filePath);
    }


    public class JsonUserDatabase : IUser
    {
        public List<User> GetUsers(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<User>();

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<User>();

            List<User> tmp = JsonSerializer.Deserialize<List<User>>(json);
            return tmp;
        }

        public void SaveToUser(User user, string filePath)
        {
            List<User> users = GetUsers(filePath);

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i] != user)
                    continue;

                users[i] = user;
                return;
            }
        }

        public void SaveNewUser(User user, string filePath)
        {
            List<User> users = GetUsers(filePath);
            users.Add(user);

            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);
        }
    }
}
