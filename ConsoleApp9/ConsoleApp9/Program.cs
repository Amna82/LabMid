
using System;
using System.Collections.Generic;

namespace StudentClubManagement
{

    public class Society
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

 
    public class FundedSociety : Society
    {
        public decimal FundingAmount { get; set; }
    }

   
    public class NonFundedSociety : Society
    {
        
    }

    public class ClubRole
    {
        public string RoleName { get; set; }
        public string MemberName { get; set; }
    }

    // Represents a Student Club
    public class StudentClub
    {
        public decimal Budget { get; set; }
        public string President { get; set; }
        public string VicePresident { get; set; }
        public List<Society> Societies { get; set; }
        public List<ClubRole> Roles { get; set; }

        public StudentClub()
        {
            Societies = new List<Society>();
            Roles = new List<ClubRole>();
        }

        public void AddSociety(Society society)
        {
            Societies.Add(society);
        }

        public void AddRole(ClubRole role)
        {
            Roles.Add(role);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"President: {President}");
            Console.WriteLine($"Vice President: {VicePresident}");
            Console.WriteLine($"Budget: {Budget:C}");
            Console.WriteLine("Societies:");
            foreach (var society in Societies)
            {
                Console.WriteLine($"- {society.Name} ({society.GetType().Name})");
                Console.WriteLine($"  Description: {society.Description}");
                if (society is FundedSociety funded)
                {
                    Console.WriteLine($"  Funding Amount: {funded.FundingAmount:C}");
                }
            }
            Console.WriteLine("Roles:");
            foreach (var role in Roles)
            {
                Console.WriteLine($"- {role.RoleName}: {role.MemberName}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Student club Management System.");

            Console.WriteLine("1. Registernew society.");

            Console.WriteLine("Allocate funds.");

            Console.WriteLine("Register an event");

            Console.WriteLine("Display Society funding Information.");

            Console.WriteLine("Exit.");

            StudentClub club = new StudentClub();

         
            Console.Write("Enter the name of the President: ");
            club.President = Console.ReadLine();
            Console.Write("Enter the name of the Vice President: ");
            club.VicePresident = Console.ReadLine();

            Console.Write("Enter the budget for the club: ");
            club.Budget = decimal.Parse(Console.ReadLine());

            Console.Write("How many societies do you want to add? ");
            int societyCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < societyCount; i++)
            {
                Console.Write("Enter the type of society (funded/non-funded): ");
                string societyType = Console.ReadLine().ToLower();

                Society society;
                Console.Write("Enter the name of the society: ");
                string societyName = Console.ReadLine();
                Console.Write("Enter a description for the society: ");
                string description = Console.ReadLine();

                if (societyType == "funded")
                {
                    society = new FundedSociety
                    {
                        Name = societyName,
                        Description = description
                    };
                    Console.Write("Enter the funding amount: ");
                    ((FundedSociety)society).FundingAmount = decimal.Parse(Console.ReadLine());
                }
                else if (societyType == "non-funded")
                {
                    society = new NonFundedSociety
                    {
                        Name = societyName,
                        Description = description
                    };
                }
                else
                {
                    Console.WriteLine("Invalid society type. Please enter 'funded' or 'non-funded'.");
                    i--; // Decrement to retry this iteration
                    continue;
                }

                club.AddSociety(society);
            }

            Console.Write("How many roles do you want to add? ");
            int roleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < roleCount; i++)
            {
                Console.Write("Enter the role name: ");
                string roleName = Console.ReadLine();
                Console.Write("Enter the member name for this role: ");
                string memberName = Console.ReadLine();

                club.AddRole(new ClubRole { RoleName = roleName, MemberName = memberName });
            }

            
            club.DisplayInfo();

            // Keep the console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}