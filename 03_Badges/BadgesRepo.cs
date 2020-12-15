using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class BadgesRepo
    {
        private List<Badge> _badges = new List<Badge>();
        public void DictionaryOfBadges(){
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(12345, "A5");

       }

        //Create a new badges
        public void AddBadge(Badge badge)
        {
            _badges.Add(badge);
        }

       
        //Delete all doors from an existing badge
        private bool DeleteAllDoors(int badgeID)
        {
            Badge badges = GetBadgeByBadgeID(badgeID);
            if (_badges.Remove(badges))
            {
                return true;
            }
            return false;
        }
        //Read 
        public List<Badge> GetAllBadges()
        {
            return _badges;
        }
        // show a list with all numbers and door access

        // Helper
        public Badge GetBadgeByBadgeID(int badgeid)
        {
            foreach (Badge badges in _badges)
            {
                if (badges.BadgeID == badgeid)
                {
                    return badges;
                }
            }
            return null;
        }
    }
}
