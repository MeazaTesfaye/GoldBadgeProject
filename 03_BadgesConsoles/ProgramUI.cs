using _03_Badges;
using System;
using System.Collections.Generic;

namespace _03_BadgesConsoles
{
    public class ProgramUI
    {
        BadgesRepo badgesRepo = new BadgesRepo();
        public void Run()
        {
            SeeData();
            while (Menu())
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Goodbye!\n" +
                "Press an key to exit...");
            Console.ReadKey();
        }
        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                "1. AddBadge\n" +
                "2. Edit a Badge\n" +
                "3. List all Badges\n" +
                "4. Remove\n" +
                "5. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    AddBadges();
                    //Add
                    break;
                case "2":
                    //Edit
                    UpdateDoors();

                    break;
                case "3":
                    //List all Badges
                    ViewAllDoors();
                    break;
                case "4":
                    //Remove
                    DeleteExistingBadge();
                    break;
                case "5":
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
            Console.WriteLine("Please enter the badge Id");
            string badgeId = Console.ReadLine();
            newBadge.BadgeID = int.Parse(badgeId);
            newBadge.DoorName = newBadge.DoorName;
        }
        private void SeeData()
        {
            //public Badge(int 12345 badgeId, string doorName)A5
            var badge1 = new Badge(2127, new List<string> { "A5", "A7", "A8"});
            var badge2 = new Badge(2130, new List<string> { "B5", "A10", "A30" });
            badgesRepo.AddBadge(badge1);
            badgesRepo.AddBadge(badge2);
        }
        //update
        public void UpdateDoors()
        {
            Console.Clear();
            ViewAllDoors();
            Console.WriteLine("Enter Badge Id you would like to update");
            int badgeID = int.Parse(Console.ReadLine());

            Badge badge = badgesRepo.GetBadgeByBadgeID(badgeID);
            Console.WriteLine($"Badge ID: {badge.BadgeID}\n" +
                $"Door Name: {badge.BadgeID}");
        }

        //Delete
        private void DeleteExistingBadge()
        {
            Console.Clear();
            ViewAllDoors();

            Console.WriteLine("Enter Id of the door you would like to remove:");
            int badgeId = int.Parse(Console.ReadLine());
            Console.Clear();
            var doorToDelete = badgesRepo.GetBadgeByBadgeID(badgeId);

            Console.WriteLine("Are you sure you want to remove :(yes or no) ");
            foreach (var item in doorToDelete.DoorName)
            {
                Console.WriteLine(" "+ item) ;

            }
            
            string ans = Console.ReadLine();
            if (ans.ToLower() == "yes" || ans.ToLower() == "y")
            {

                if (badgesRepo.DeleteAllDoors(badgeId))
                {
                    Console.WriteLine("The Id was successfully deleted");
                }
                else
                {
                    Console.WriteLine("The Id could not be deleted");
                }

            }
        }
        // list
        private void ViewAllDoors()
        {
            Console.Clear();
            Dictionary<int, Badge> listOfBadges = badgesRepo.GetAllBadges();
            foreach (KeyValuePair<int, Badge> value in listOfBadges)
            {
                Console.WriteLine($"BadgeID: {value.Key}");
                foreach (string doors in value.Value.DoorName)
                {
                    Console.WriteLine($"DoorName: {doors}");

                }
            }

        }

        
        
    }

}



