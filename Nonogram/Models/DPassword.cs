using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Models
{
    public class DPassword(string hash, string salt)
    {
        public string Hash { get; private set; } = hash;
        public string Salt { get; private set; } = salt;
    }
}
