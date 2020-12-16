using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsClasses
{
    public class ClaimsRepo
    {
        private Queue<Claims> claimIDs = new Queue<Claims>();
        
        
        //Read
        public Queue<Claims> GetAllClaims()
        {
            return claimIDs;
        }
        // update
        public bool UpdateExistingClaims(int newclaimID, Claims newClaims)
        {
            Claims oldClaimId = GetCalimByClaimID(newclaimID);
            if(oldClaimId != null)
            {
                oldClaimId.ClaimID = newClaims.ClaimID;
                oldClaimId.ClaimType = newClaims.ClaimType;
                return true;
            }
            else
            {
                return false;
            }
        }   
        
        //Create
          public void AddClaim(Claims claims)
            {
                claimIDs.Enqueue(claims);
            }
        //Delete
        public bool DeleteClaim(Claims claimid)
        {
            Claims claim = GetCalimByClaimID(claimid.ClaimID);
            if (claim == null)
            {
                return false;
            }
            int initialCount = claimIDs.Count;
            claimIDs.Dequeue();
            if (initialCount > claimIDs.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Helper
        public Claims SeeNextClaim()
        {

         return  claimIDs.Peek();
            
        }

        //Helper
        public Claims GetCalimByClaimID(int claimid)
    {
        foreach(Claims claims in claimIDs)
            {
         if (claims.ClaimID == claimid)
                {
                    return claims;
                }
            }
            return null;
        }

        public bool DeleteClaim()
        {
            int startingCount = claimIDs.Count;
            claimIDs.Dequeue();
            if(claimIDs.Count < startingCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
