using System.Collections.Generic;

namespace _03_Badges
{
    public class BadgesRepo
    {
        private Dictionary<int, List<Badge>> _badges = new Dictionary<int, List<Badge>>();
        //Create a new badges
        public void AddBadge(Badge badge)
        {
            List<Badge> badges = new List<Badge>();
            badges.Add(badge);
            _badges.Add(badge.BadgeID, badges);
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
        public Dictionary<int, List<Badge>> GetAllBadges()
        {
            return _badges;
        }

        // Helper
        public Badge GetBadgeByBadgeID(int badgeid)
        {

            foreach (KeyValuePair<int, List<Badge>> kVp in _badges)
            {
                if (kVp.Key == badgeid)
                {
                    foreach (var door in kVp.Value)

                    {
                        Badge value = door;
                        return value;
                    }
                    
                }
                
            }
            return null;

        }


    


    }
}
