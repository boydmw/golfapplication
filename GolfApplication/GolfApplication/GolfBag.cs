using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApplication
{
    public class GolfBag
    {
        int maxNumberOfClubs = 13;

        List<GolfClubs> golfBag;

        public GolfBag()
        {
            golfBag = new List<GolfClubs>();
        }

        public void AddClubToGolfBag(GolfClubs club)
        {
            golfBag.Add(club);
        }

        //TODO Define fields of the GolfBag object.
        //TODO allow user to add clubs to the golfbag.
        //TODO - make sure number of clubs never exceeds maxNumberOfClubs.

    }
}
