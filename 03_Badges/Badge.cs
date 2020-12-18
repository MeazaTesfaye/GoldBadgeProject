using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorName { get; set; }

        public Badge() { }
        public Badge(int badgeId, List<string> doorName)
        {
            BadgeID = badgeId;
            DoorName = doorName;
        }
        
    }
}
