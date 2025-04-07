using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Interfaces
{
    public interface IHandlerInput
    {
        public bool HandleInput(string text);
    }
}
