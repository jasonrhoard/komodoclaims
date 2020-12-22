using KomodoClaims_Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims_Console
{
    class ProgramUI
    {
        private KomodoClaimsRepo _claimsRepo = new KomodoClaimsRepo();

        public void Run()
        {
            SeedClaimList();

            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Welcome to Komodo Claims! Please enter an option number:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;

                    case "2":
                        TakeCareOfNext();
                        break;

                    case "3":
                        EnterNewClaim();
                        break;

                    default:
                        Console.WriteLine("Please enter number 1, 2, or 3...");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
               
            }
        }

        private void SeeAllClaims()
        {
            List<KomodoClaims> listOfClaims = _claimsRepo.SeeAllClaims();
            foreach (KomodoClaims item in listOfClaims)
            {
                Console.WriteLine($"ClaimID:{item.ClaimID}", $"Type:{item.ClaimType}",$"Description{item.Description}",$"Amount:{item.ClaimAmount}",$"IncidentDate{item.DateOfIncident}",$"Claim Date:{item.DateOfClaim}",$"IsValid{item.IsValid}");

               /** string[] claimID = { "1", "2", "3" };
                string[] type = { "Car", "Home", "Theft" };
                string[] description = { "Car accident on 465.", "House fire in kitchen.", "Stolen pancakes." };
                string[] amount = { "$400.00", "$4000.00", "$4.00" };
                string[] incidentDate = { "4/25/18", "4/11/18", "4/27/18" };
                string[] claimDate = { "4/27/18", "4/12/18", "6/01/18" };
                string[] isValid = { "true", "true", "false" };

                Console.WriteLine("ClaimID", "Type", "Description", "Amount", "Incident Date", "Claim Date", "IsValid");

                Console.WriteLine(claimID, type, description, amount, incidentDate, claimDate, isValid);

                DataTable dt = new DataTable();

                dt.Columns.Add("Claim ID");
                dt.Columns.Add("Type");
                dt.Columns.Add("Description");
                dt.Columns.Add("Amount");
                dt.Columns.Add("Incident Date");
                dt.Columns.Add("Claim Date");
                dt.Columns.Add("IsValid");

                dt.Rows.Add("1", "Auto", "Car accident on 465.", "$400.00", "4/25/18", "4/27/18", true);
                dt.Rows.Add("2", "Home", "House fire in kitchen.", "$4000.00", "4/11/18", "4/12/18", true);
                dt.Rows.Add("3", "Theft", "Stolen pancakes.", "$4.00", "4/27/18", "6/01/18", false);

                Console.WriteLine(dt);
        **/

            }
        }

        private void TakeCareOfNext()
        {

        }

        private void EnterNewClaim()
        {
            KomodoClaims newClaims = new KomodoClaims();

            Console.WriteLine("Please enter the Claim ID:");
            string idAsString = Console.ReadLine();
            newClaims.ClaimID = int.Parse(idAsString);

            Console.WriteLine("Please enter the Claim Type\n" +
                "Enter 1 for Auto, 2 for Home, or 3 for Theft):");
            string claimTypeAsString = Console.ReadLine();
            int claimTypeAsInt = int.Parse(claimTypeAsString);
            newClaims.TypeOfClaims = (ClaimTypes)claimTypeAsInt;

            Console.WriteLine("Please enter the Claim Description:");
            newClaims.Description = Console.ReadLine();

            Console.WriteLine("Please enter the Claim Amount:");
            newClaims.ClaimAmount = Console.ReadLine();

            Console.WriteLine("Please enter the Date of the Incident (example 01/01/2020):");
            newClaims.DateOfIncident = Console.ReadLine();

            Console.WriteLine("Please enter the Date of the Claim (example 01/01/2020:");
            newClaims.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Is the Claim valid (True/False)?");
            newClaims.IsValid = Console.ReadLine();
            

            
           
        }

       private void SeedClaimList()
        {
            KomodoClaims first = new KomodoClaims(1, "Auto", "Car accident on 465.", "$400.00", "4/25/18", "4/27/18", "true");
            KomodoClaims second = new KomodoClaims(2, "Home", "House fire in Kitchen.", "$4000.00", "4/11/18", "4/12/18", "true");
            KomodoClaims third = new KomodoClaims(3, "Theft","Stolen pancakes.", "$4.00", "4/27/18", "6/01/18", "false");

            _claimsRepo.EnterNewClaims(first);
            _claimsRepo.EnterNewClaims(second);
            _claimsRepo.EnterNewClaims(third);

            /**string[] claimID = { "1", "2","3" };
            string[] type = {"Car","Home","Theft" };
            string[] description = {"Car accident on 465.","House fire in kitchen.","Stolen pancakes." };
            string[] amount = {"$400.00","$4000.00","$4.00" };
            string[] incidentDate = {"4/25/18","4/11/18","4/27/18" };
            string[] claimDate = {"4/27/18","4/12/18","6/01/18" };
            string[] isValid = {"true","true","false" };

            Console.WriteLine("{0,-20} {1,5}\n", "ClaimID", "Type","Description","Amount","Incident Date","Claim Date","IsValid");
           
                Console.WriteLine("{0,-20} {1,5:N1}", claimID, type, description, amount, incidentDate, claimDate, isValid);
            DataTable dt = new DataTable();
           
            dt.Columns.Add("Claim ID");
            dt.Columns.Add("Type");
            dt.Columns.Add("Description");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Incident Date");
            dt.Columns.Add("Claim Date");
            dt.Columns.Add("IsValid");

            dt.Rows.Add("1", "Auto", "Car accident on 465.", "$400.00", "4/25/18", "4/27/18", true);
            dt.Rows.Add("2", "Home", "House fire in kitchen.", "$4000.00", "4/11/18", "4/12/18", true);
            dt.Rows.Add("3", "Theft", "Stolen pancakes.", "$4.00", "4/27/18", "6/01/18", false);

            Console.WriteLine(dt);
            **/
        }
    }
}



