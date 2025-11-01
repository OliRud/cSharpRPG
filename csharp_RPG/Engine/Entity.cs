using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Entity
    {
        public int MaximumHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public Entity(int currentHitpoints, int maximumHitpoints) 
        {
            CurrentHitPoints = currentHitpoints;
            MaximumHitPoints = maximumHitpoints;
        }
    }
}
