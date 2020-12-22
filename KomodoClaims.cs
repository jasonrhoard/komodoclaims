using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims_Repo
{
    public enum ClaimTypes
    {
        Car =1,
        Home,
        Theft
    }
    public class KomodoClaims
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public string ClaimAmount { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }
        public string IsValid { get; set; }
        //public string DealWithClaim { get; set; }
        public ClaimTypes TypeOfClaims { get; set; }

        public KomodoClaims() { }

        public KomodoClaims(int claimID, string claimType, string description, string claimAmount, string dateOfIncident, string dateOfClaim, string isValid )
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
            //DealWithClaim = dealWithClaim;
            //TypeOfClaims = typesOfClaim;
        }
    }
}
