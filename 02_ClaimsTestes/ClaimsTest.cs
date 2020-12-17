using System;
using _02_ClaimsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTestes
{
    [TestClass]
    public class ClaimsTest
    {
        //        [TestMethod]
        //Add
        public void TestForAddingClaim()
        {
            //Arrange
            Claims claim = new Claims();
            ClaimsRepo claimsRepo = new ClaimsRepo();

            //Act
            claimsRepo.AddClaim(claim);
            Claims claimFromClaimsID = claimsRepo.GetCalimByClaimID(claimsRepo.);
            //claim

            //Assert 



        }
        //update
        public void TestForUpdatingClaims()
        {

        }

        //Create
    }
}
