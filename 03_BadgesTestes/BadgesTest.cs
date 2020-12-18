using _03_Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BadgesTestes
{
   [TestClass]
    public class BadgesTest
    {
        private Badge _badge;
        private BadgesRepo _badgesRepo;
        [TestInitialize]
        public void TestBadge()
        {
            _badge = new Badge(2127, new List<string> 
            { "A5", "A7", "A8" });
            _badgesRepo = new BadgesRepo();
            _badgesRepo.AddBadge(_badge);
        }
        //Add
        [TestMethod]
        public void TestForAddingBadge()
        {
            Badge badge = new Badge();
            BadgesRepo badgesToAdd = new BadgesRepo();
            //Act
            badgesToAdd.AddBadge(badge);

            //Assert
            Dictionary<int,Badge> badgeDict = badgesToAdd.GetAllBadges();
            bool idIsEqual = false;
            foreach(KeyValuePair <int, Badge> badgedict in badgeDict)
            {
                if(badgedict.Key == badge.BadgeID)
                {
                    idIsEqual = true;
                    break;
                }
            }

        }
        [TestMethod]
        //Update
        public void UpdateBadge()
        {
            Badge newBadgeId = new Badge(2127, new List<string>
            { "A5", "A7", "A8" });

            //Act
            bool UpdateBadge = _badgesRepo.UpdateABadge(2127, newBadgeId);

            //Assert
            Assert.IsTrue(UpdateBadge);
        }
        [TestMethod]
        //Delete
        public void RemoveBadge()
        {
            //Arange

            //Act
            bool removeBadge = _badgesRepo.DeleteAllDoors(_badge.BadgeID);

            //Assert
            Assert.IsTrue(removeBadge);
        }



        [TestMethod]
        //View or show
        public void ShowListWithBadges()
        {
            //Arange
            BadgesRepo badgesRepo = new BadgesRepo();

            //Act
            Dictionary<int, Badge> listFromRepo = badgesRepo.GetAllBadges();

            //Assert
            Assert.IsNotNull(badgesRepo);
        }

        //Get Badge By Badge Id
        [TestMethod]
        public void GetBadgeByID()
        {
            //Arange
            BadgesRepo badgesRepo = new BadgesRepo();
            Badge badgeToAdd = new Badge(2127, new List<string>
            { "A5", "A7", "A8" });
            _badgesRepo = new BadgesRepo();
            _badgesRepo.AddBadge(_badge);
            //Act
            Badge badgeById = badgesRepo.GetBadgeByBadgeID(badgeToAdd.BadgeID);
            bool isBadgeEqual = badgeToAdd.BadgeID == badgeToAdd.BadgeID;

            //Assert
            Assert.IsTrue(isBadgeEqual);
        }
    }
}
