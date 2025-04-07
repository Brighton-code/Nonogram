using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram.Models;

namespace Nonogram.Interfaces
{
    public interface IUser
    {
        public void SaveToUser(User user, string filePath);
        public void SaveNewUser(User user, string filePath);
        public List<User> GetUsers(string filePath);
    }
}
