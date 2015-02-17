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
        private LevelEasy levelEasy;
        private LevelMed levelMed;
        private LevelHard levelHard;
        private LevelExpert levelExpert;

        public Factory(string level)
        {
            Level = level;
            levelEasy = new LevelEasy();
            levelMed =  new LevelMed();
            levelHard = new LevelHard();
            levelExpert = new LevelExpert();
        }

        public int NewTurn()
        {
            if (Level == "Easy")
            {
                return levelEasy.SetTurn();
            }
            else if (Level == "Med")
            {
                
            }
            else if (Level == "Hard")
            {
                
            }
            else
            {
                return 0;
            }
            return 0;

        }
    }
}
