using _03_Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BadgesConsoles
{
    public class ProgramUI
    {
        BadgesRepo badgesRepo = new BadgesRepo();
        public void Run()
        {
            SeeData();
            Menu();
        }

        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                "1. AddBadge\n" +
                "2. Edit a Badge\n" +
                "3. List all Badges" +
                "4. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    AddBadges();
                    //Add
                    break;
                case "2":
                    //Edit
                    //UpdateDoors();
                        break;
                case "3":
                    //List all Badges
                    break;
                case "4":
                    //Exit
                    return false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            return true;
        }
        //Create
        private void AddBadges()
        {
            Console.Clear();
            Badge newBadge = new Badge();
            Console.WriteLine("Please enter the bade number");
            string badgeId = Console.ReadLine();
            newBadge.BadgeID = int.Parse(badgeId);
            newBadge.DoorName = newBadge.DoorName;
        }
        private void SeeData()
        {
            //public Badge(int 12345 badgeId, string doorName)A5
            var badge1 = new Badge(2127, "A5");
            var badge2 = new Badge(0912, "A7");
            badgesRepo.AddBadge(badge1);
            badgesRepo.AddBadge(badge2);

        }
        //update
        public bool UpdateDoors(int badgeId, Badge newBadge)
        {
            Badge oldBadgeid =  (badgeId);
            if (newBadge != null)
            {
                oldBadgeid.BadgeID = newBadge.BadgeID;
                oldBadgeid.DoorName = newBadge.DoorName;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        private void DeleteExistingBadge()
        {
            Console.Clear();
            ViewAllDoors();
            Console.WriteLine("");
        }

        // list
        private void ViewAllDoors ()
        {
            Console.Clear();
            Dictionary<int, Badge> listOfBadges = badgesRepo.GetAllBadges();
            foreach(KeyValuePair<int, Badge> value in listOfBadges)
            {
                Console.WriteLine($"BadgeID: {value.Key}" +
                    $"DoorName: {value.Value.DoorName}");
            }
            
        }
    }

}

   

