﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe.Logic
{
    public class LevelEasy
    {
        public int SetTurn()
        {
            Random random = new Random();
            return random.Next(1, 9);
        }
    }
}
