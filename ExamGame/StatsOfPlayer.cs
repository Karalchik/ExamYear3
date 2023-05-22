using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGame
{
    internal class StatsOfPlayer
    {
        public int LastScore { get; set; }
        public int MaxScore { get; set; }

        public StatsOfPlayer(int lastScore, int maxScore)
        {
            LastScore = lastScore;
            MaxScore = maxScore;
        }
        public StatsOfPlayer()
        {
            LastScore= 0;
            MaxScore= 0;
        }
        public override string ToString()
        {
            return $"{MaxScore} , {LastScore}";
        }
    }
}
