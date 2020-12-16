using _02_ClaimsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClaimsConsole
{
    public class ProgramUI
    {
        private ClaimsRepo _claimsRepo = new ClaimsRepo();

        public void Run()
        {
            SeedClaimList();
            Menu();
        }
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning == true)
            {
                Console.WriteLine("Select a menu option\n" +
                    "1. View all items in the queue\n" +
                    "2. Take Care of the next claim\n" +
                    "3. Enter the Claim ID\n" +
                    "4. Exist");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ViewAllClaims();
                        //View all items in the queue
                        break;
                    case "2":
                        DeleteClaims();
                        //Update or Take care of the next queue
                        break;
                    case "3":
                        EnterNewClaim();
                        //Create or Enter the Claim ID
                        break;
                    case "4":
                        //Exist

                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter a vaild ID Number");
                        break;
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
        //View all items in the queue
        private void ViewAllClaims()
        {
            Console.Clear();
            Queue<Claims> listOfClaims = _claimsRepo.GetAllClaims();
            foreach (Claims claim in listOfClaims)
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"\tType: {claim.ClaimType}\n" +
                    $"\tDescrition: {claim.Description}\n" +
                    $"\ttDate Of Accident: {claim.DateOfAccident}\n" +
                    $"\tDate of Claim: {claim.DateOfClaim}\n" +
                    $"\tIs it Valid: {claim.IsValid}");
            }
        }
        //GetYes/No
        private bool YesOrNo()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "yes" || input == "y")
                {
                    return true;
                }
                else if (input == "no" || input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid value");
                }
            }
            
        }
        //Delete
        private void DeleteClaims()
        {
            Console.Clear();
            ViewAllClaims();
            _claimsRepo.SeeNextClaim();
           
            Console.WriteLine("Would like to deal with this claim now y/n?");
           if(YesOrNo())
            {
                if (_claimsRepo.DeleteClaim())
                {
                    Console.WriteLine("Claim Id deleted successfully");
                }
                else
                {
                    Console.WriteLine("Claim cannot be deleted");
                }
            }

            Console.WriteLine("Would you like to deal with another claim?");
            if (YesOrNo())
            {
                DeleteClaims();
            }
        }

        // create
        private void EnterNewClaim()
        {
            Console.Clear();
            Claims newClaim = new Claims();
            //ClaimID
            Console.WriteLine("Enter the Claim ID");
            string claimNum = Console.ReadLine();
            newClaim.ClaimID = int.Parse(claimNum);

            //Claim Type
            Console.WriteLine("Enter the claim type\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            newClaim.ClaimType = Console.ReadLine();
            //Description

            Console.WriteLine("Enter a claim description");
            newClaim.Description = Console.ReadLine();

            //Amount of Damage
            Console.WriteLine("Enter amount of damage");
            string claimDamage = Console.ReadLine();
            newClaim.ClaimAmount = double.Parse(claimDamage);

            //Date Of Accident
            Console.WriteLine("Enter Date of Accident");
            string dateAcc = Console.ReadLine();
            newClaim.DateOfAccident = DateTime.Parse(dateAcc);

            //Date of Claim
            Console.WriteLine("Enter date of claim");
            string dateClaim = Console.ReadLine();
            newClaim.DateOfClaim = DateTime.Parse(dateClaim);

            // This claim is Valid
            Console.WriteLine("Is this claim valid? y/n");
            string isValid = Console.ReadLine();
            if(isValid == "y")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
        }

        //SeedClaimList
        private void SeedClaimList()
        {
            //public Claims(int claimId, string claimType, string description, double claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid, TypesOfClaims claim)

            Claims car = new Claims(1, "Car", "Car accident on 465", 400.00, new DateTime(2020, 5, 18), new DateTime(2020, 7, 18), true, TypesOfClaims.Car);
            Claims home = new Claims(2, "Home", "House fire in kitchen", 400.00, new DateTime(2020, 11, 18), new DateTime(2020, 12, 18), true, TypesOfClaims.Home);
            Claims theft = new Claims(3, "Theft", "Stoken pancakes", 4.00, new DateTime(2020, 7, 18), new DateTime(2020, 01, 18), false, TypesOfClaims.Theft);

            _claimsRepo.AddClaim(car);
            _claimsRepo.AddClaim(home);
            _claimsRepo.AddClaim(theft);

        }

        private void ViewClaims(Claims claims)
        {
            Console.WriteLine($"ID: {claims.ClaimID}" +
                $"\tType: {claims.ClaimType}\n" +
                $"\tDescription: {claims.Description}\n" +
                $"\tClaimAmount: {claims.ClaimAmount}\n" +
                $"\tDateOfAccident: {claims.DateOfAccident}\n" +
                $"\tDateOfClaim: {claims.DateOfClaim}\n" +
                $"\tIs this Claim valid? : {claims.IsValid}");
        }
    }
}

