using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe.Logic
{
    public class LevelMed
    {
        public int SetTurn(List<int> freeSpaces)
        {
            Random random = new Random();
            return random.Next(freeSpaces.Count);
        }
    }
}
