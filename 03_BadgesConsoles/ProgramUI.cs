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
        private Badge badgeReo = new Badge();

        public void Run()
        {

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

        private void AddBadges()
        {
            Console.Clear();
            Badge newBadge = new Badge();
            Console.WriteLine("Please enter the bade number");
            string badgeId = Console.ReadLine();
            newBadge.BadgeID = int.Parse(badgeId);
            newBadge.DoorName = newBadge.DoorName;
        }

        //Update all doors from an existing badge
        public bool UpdateDoors(int badgeId, Badge newBadge)
        {
            Badge oldBadgeid = GetBadgeByBadgeID(badgeId);
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

        // list
        private List<Badge> ViewAllDoors ()
        {
            GetAllBadges();
            Console.WriteLine( ");
        }
    }

}

   

