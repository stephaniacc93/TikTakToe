using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTakToe.Controls;

namespace TikTakToe.Logic
{
    public class Factory
    {
        string Level { get; set; }
        private LevelEasy levelEasy;
        private LevelMed levelMed;
        private LevelHard levelHard;
        private LevelExpert levelExpert;
        public GameView GameView;

        public Factory(string level)
        {
            Level = level;
            levelEasy = new LevelEasy();
            levelMed = new LevelMed();
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
                //aqui obtienes todos los space views
                var freeSpaces = GetFreeSpaces();
                return levelMed.SetTurn(freeSpaces);
            }
            else if (Level == "Hard")
            {
                return 0;
            }
            else
            {
                return 0;
            }
            return 0;

        }

        private List<int> GetFreeSpaces()
        {
            List<int> freeSpaces = new List<int>();
            foreach (var freeSpace in GameView.GetSpaceControls())
            {
                if (!freeSpace.IsUsed)
                    freeSpaces.Add(int.Parse(freeSpace.Name.Last().ToString()));
            }
            return freeSpaces;
        }
    }
}
