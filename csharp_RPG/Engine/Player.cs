using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : Entity
    {
        public int Gold { get;set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public Player(int currentHitpoints, int maximumHitpoints, int gold, int experiencePoints, int level) : base(currentHitpoints, maximumHitpoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }
    }
}
