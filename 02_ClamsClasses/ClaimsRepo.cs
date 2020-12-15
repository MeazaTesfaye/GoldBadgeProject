using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsClasses
{
    public class ClaimsRepo
    {
        private List<Claims> _listOfClaims = new List<Claims>();
        
        
        //Read
        public List<Claims> GetListOfClaims()
        {
            return _listOfClaims;
        }
        // update
        public bool UpdateExistingClaims(int newclaimID, Claims newClaims)
        {
            Claims oldClaimId = GetCalimByClaimID(newclaimID);
            if(newclaimID != null)
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
                _listOfClaims.Add(claims);
            }
        //Delete
        public bool DeleteClaim(Claims claimid)
        {
            Claims claim = GetCalimByClaimID(claimid);
            if (claim == null)
            {
                return false;
            }
            int initialCount = _listOfClaims.Count;
            _listOfClaims.Remove(claim);
            if(initialCount > _listOfClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Claims GetCalimByClaimID(Claims claimid)
        {
            throw new NotImplementedException();
        }

        //Helper
        public Claims GetCalimByClaimID(int claimid)
    {
        foreach(Claims claims in _listOfClaims)
            {
         if (claims.ClaimID == claimid)
                {
                    return claims;
                }
            }
            return null;
        }

        public bool DeleteClaim(int deletedId)
        {
            Claims claims = GetCalimByClaimID(deletedId);
            if (_listOfClaims.Remove(claims))
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
