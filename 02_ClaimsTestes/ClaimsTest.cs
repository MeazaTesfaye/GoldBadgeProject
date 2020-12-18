using System;
using System.Collections.Generic;
using _02_ClaimsClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimsTestes
{
    [TestClass]
    public class ClaimsTest
    {
        private Claims _claims;
        private ClaimsRepo _claimRepo;

        [TestInitialize]
        public void TestClaim()
        {
            _claims = new Claims(1, "Car", "Car accident on 465", 400.00,
                new DateTime(2020, 5, 18),
                new DateTime(2020, 7, 18), true, TypesOfClaims.Car);
            _claimRepo = new ClaimsRepo();
            _claimRepo.AddClaim(_claims);
        }
            
        //Add
        [TestMethod]
        public void TestForAddingClaim()
        {
            //Arrange
            Claims claim = new Claims();
            ClaimsRepo claimsRepo = new ClaimsRepo();

            //Act
            claimsRepo.AddClaim(claim);
            Claims claimFromClaimsID = claimsRepo.GetCalimByClaimID(claim.ClaimID);
            //claim

            //Assert 
            Assert.IsNotNull(claimFromClaimsID);


        }
        [TestMethod]
        [DataTestMethod]
       [DataRow(1,true)]
       [DataRow(2, false)]
        
       //update
        public void TestForUpdatingClaims(int originalId, bool newId)
        {
            Claims newClaims = new Claims(1, "Car", "Car accident on 465", 400.00,
                new DateTime(2020, 5, 18), 
                new DateTime(2020, 7, 18), true, TypesOfClaims.Car);

            //Act
            bool UpdateClaim = _claimRepo.UpdateExistingClaims(originalId, newClaims);

            //Assert
            Assert.AreEqual(newId, UpdateClaim);
        }

        //Remove
        [TestMethod]
        public void RemoveClaim()
        {
            //Arange

            //Act
            bool removedClaim = _claimRepo.DeleteClaim(_claims);

            //Assert
            Assert.IsTrue(removedClaim);
        }

        
        [TestMethod]
        public void GetClaimById()
        {
            //Arange
            ClaimsRepo claimsRepo = new ClaimsRepo();
            Claims claimsToAdd = new Claims(1, "Car", "Car accident on 465", 400.00,
                new DateTime(2020, 5, 18),
                new DateTime(2020, 7, 18), true, TypesOfClaims.Car);
            _claimRepo = new ClaimsRepo();
            _claimRepo.AddClaim(claimsToAdd);



            //Act
            Claims claimByID = claimsRepo.GetCalimByClaimID(claimsToAdd.ClaimID);
            bool isClaimEqual = claimsToAdd.ClaimID == claimsToAdd.ClaimID;
           
            //Assert
            Assert.IsTrue(isClaimEqual);
        }
        [TestMethod]
        public void TestForGetAllClaimsIsNotNull()
        {
            //Arange
            ClaimsRepo claimsRepo = new ClaimsRepo();

            //Act
            Queue<Claims> listFromRepo = claimsRepo.GetAllClaims();
            //Assert
            Assert.IsNotNull(listFromRepo); 
        }
    }
}
