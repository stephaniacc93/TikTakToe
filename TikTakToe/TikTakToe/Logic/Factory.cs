using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe.Logic
{
    public class Factory
    {
        string Level { get; set; }

        public Factory(string level)
        {
            Level = level;
        }
    }
}
