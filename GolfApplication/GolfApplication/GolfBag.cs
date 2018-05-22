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

        public int CheckGolfClubsAdded()
        {
           return golfBag.Count();
        }

        public List<string> DisplayGolfClubsAdded()
        {
            List<string> clubsInBag = new List<string>();

            foreach (var club in golfBag)
            {
                clubsInBag.Add(string.Format("You added a {0} to your bag.", club.Translate(club.clubType)));
            }

            return clubsInBag;
        }

        //TODO Define fields of the GolfBag object.
        //TODO - make sure number of clubs never exceeds maxNumberOfClubs.

    }
}
