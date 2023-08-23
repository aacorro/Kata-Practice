using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class HolidayVISharkPontoon
    {
        public string Shark(
              int pontoonDistance,
              int sharkDistance,
              int youSpeed,
              int sharkSpeed,
              bool dolphin)
        {
            double timeToReachPontoon = (double)pontoonDistance / youSpeed;
            double adjustedSharkSpeed = dolphin ? sharkSpeed / 2.0 : sharkSpeed;
            double timeToReachYou = (double)sharkDistance / adjustedSharkSpeed;

            if (timeToReachPontoon < timeToReachYou)
            {
                return "Alive!";
            }
            else
            {
                return "Shark Bait!";
            }
        }
    }
}

/*
 return pontoonDistance * sharkSpeed < yourSpeed * sharkDistance * (dolphin ? 2 : 1)
      ? "Alive!"
      : "Shark Bait!";*
/

/*
 This is very confusing, kata description should be updated. Below is the simplest way I can think to write this:

"sharkDistance = Shark's distance from Beach (in metres). If shark can get here before you, it will eat you."
"pontoonDistance = Your distance from Beach (in metres). If you can get here before the shark, you will live."
The two following examples are all 'aligned in 1 dimension', based on how it is written now:

Shark --> Pontoon --> You --> Beach = Shark traversing both distances succeeds for test examples, but not random.
Pontoon <-- Shark --- You --> Beach = This is the intended? But shark is just racing you to a different location?
Pontoon --- You <-> Shark --- Beach = Random test generates these with wrong interpretation, since you would always die.
This is how it should be viewed:

Shark --> You --> Beach = You could live, depending on speeds and distances.
You --> Shark --> Beach = It should technically still eat you no matter what, but at least you're racing in the same direction?
*/