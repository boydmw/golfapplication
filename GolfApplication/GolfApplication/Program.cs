using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Club Selection Assistant.");

            GolfBag userGolfBag = new GolfBag();

            Console.WriteLine("Below are the available clubs:");

            bool addMoreClubs = true;

            while (addMoreClubs)
            {
                Console.WriteLine("Enter the corresponding number to add the club to your bag or exit.");
                int clubToAdd = int.Parse(Console.ReadLine());

                if (clubToAdd != 50) //make sure the user did not enter 50. This is exit for now.
                {
                    //make sure it is a valid club number. 1-17 only. 
                    if (clubToAdd < 17 && clubToAdd > 0)
                    {
                        GolfClubs newClub = new GolfClubs();
                        newClub.clubType = newClub.Translate(clubToAdd);
                        userGolfBag.AddClubToGolfBag(newClub);
                        Console.WriteLine("{0} was added to your bag.", newClub.Translate(newClub.clubType));
                    }
                    Console.WriteLine("Enter a correct number.");

                }
                else if (userGolfBag.CheckGolfClubsAdded() >= 1)
                {
                    Console.WriteLine("Some Text. The user decided to stop adding golf clubs.");
                    addMoreClubs = false;


                    foreach (var club in userGolfBag.DisplayGolfClubsAdded())
                    {
                        Console.WriteLine(club);
                    }
                }
                else
                {
                    Console.WriteLine("You did not added any clubs to your bag.");
                    addMoreClubs = false;
                }
            }
            //TODO - Display available clubs to the user to select from.
        }
    }
}
