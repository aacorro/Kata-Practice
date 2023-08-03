using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class TerminalGameCombatFunction
    {
        public float Combat(float health, float damage)
        {
            return health > damage ? health - damage : 0;
        }
    }
}


/*
 Create a combat function that takes the player's current health and the amount of damage recieved, and returns the player's new health. Health can't be less than 0.
*/