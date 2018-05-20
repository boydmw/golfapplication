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
            Console.WriteLine("Enter the corresponding number to add the club to your bag or exit."); //50 is exit for now.

            int clubToAdd = int.Parse(Console.ReadLine());

            if (clubToAdd != 50)
            {
                bool addMoreClubs = true;

                while (addMoreClubs)
                {
                    //make sure it is a valid club number. 1-17 only. 
                    if (clubToAdd < 17 && clubToAdd > 0)
                    {
                        GolfClubs newClub = new GolfClubs();
                        newClub.clubType = newClub.Translate(clubToAdd);
                        userGolfBag.AddClubToGolfBag(newClub);
                        Console.WriteLine("{0} was added to your bag.",newClub.Translate(newClub.clubType));
                    }

                }

            }
            else
            {
                Console.WriteLine("You have not added any clubs to your bag.");
            }

            Console.ReadLine();

            
            //TODO - Display available clubs to the user to select from.
            //TODO - Store clubs selected into golf bag.
            
            

        }
    }
}
