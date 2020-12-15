using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsClasses
{
    public enum TypesOfClaims
        {
            Car = 1,
            Home,
            Theft
        }
    // Pocos
    public class Claims
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfAccident{get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public TypesOfClaims typeOfClaims { get; set; }

        public Claims() { }
        public Claims(int claimId, string claimType, string description, double claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid, TypesOfClaims claim)
        {
            ClaimID = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            typeOfClaims = claim;
        }
    }
}
