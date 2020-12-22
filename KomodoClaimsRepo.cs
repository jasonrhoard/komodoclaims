using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims_Repo
{
    public class KomodoClaimsRepo
    {
        private List<KomodoClaims> _listofClaims = new List<KomodoClaims>();

        public void EnterNewClaims(KomodoClaims claims)
        {
            _listofClaims.Add(claims);
        }

        public List<KomodoClaims> SeeAllClaims()
        {
            return _listofClaims;
        }

       /** private KomodoClaims TakeCareOfNextClaim(string response)
        {
           foreach(KomodoClaims answer in _listofClaims)
            {
                if(answer.DealWithClaim == response)
                {
                    return answer;

                }
            }
            return null;
          **/      
        }
    }


