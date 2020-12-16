using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class BadgesRepo
    {
        private Dictionary<int, Badge> _badges = new Dictionary<int, Badge>();
        //Create a new badges
        public void AddBadge(Badge badge)
        {
            _badges.Add(badge.BadgeID,badge);
        }

       
        //Delete all doors from an existing badge
        private bool DeleteAllDoors(int badgeID)
        {
            Badge badges = GetBadgeByBadgeID(badgeID);
            if (_badges.Remove(badgeID))
            {
                return true;
            }
            return false;
        }
        //Read 
        public Dictionary<int,Badge> GetAllBadges()
        {
            return _badges;
        }

        // Helper
        public Badge GetBadgeByBadgeID(int badgeid)
        {
                Dictionary<int, Badge> badgeIDs = _badges.Get
                foreach(Badge badges in _badges)
            {
                if (badges.BadgeID == badgeid)
                {
                    return badges;
                }
            }
            return null;
        }

        //Add BadeToDictionary
        public void AddBadgeToDictionary(Dictionary<int,Badge> badgeCollection )
        {

        }
    }
}
