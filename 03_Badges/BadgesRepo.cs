using System.Collections.Generic;

namespace _03_Badges
{
    public class BadgesRepo
    {
        private Dictionary<int, Badge> _badges = new Dictionary<int, Badge>();
        //Create a new badges
        public void AddBadge(Badge badge)

        {
           // badge.BadgeID = 0;
            Badge addBadge = new Badge(badge.BadgeID, badge.DoorName);
           
            _badges.Add(badge.BadgeID,addBadge);
        }


        //Delete all doors from an existing badge
        public bool DeleteAllDoors(int badgeID)
        {
            // Badge badges = GetBadgeByBadgeID(badgeID);
            foreach (KeyValuePair<int, Badge> item in _badges)
            {
                if (item.Key == badgeID)
                {
                    if (_badges.Remove(item.Key))
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        //Update 
        public bool UpdateABadge(int newBadgeId, Badge newBadge)
        {
            Badge oldBadgeId = GetBadgeByBadgeID(newBadgeId);
            if (oldBadgeId != null)
            {
                oldBadgeId.BadgeID = newBadge.BadgeID;
                oldBadgeId.DoorName = newBadge.DoorName;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Read 
        public Dictionary<int, Badge> GetAllBadges()
        {
            return _badges;
        }

        // Helper
        public Badge GetBadgeByBadgeID(int badgeid)
        {

            foreach (KeyValuePair<int, Badge> kVp in _badges)
            {
                if (kVp.Key == badgeid)
                {
                    return kVp.Value;
                    
                }
                
            }
            return null;

        }

    }
}
