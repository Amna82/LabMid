using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Mid
{
    internal class Program
    {
        public class StudentClub
        {
            public double Budget { get; set; }

        }
        public class Society
        {
            public string Name { get; set; }
            public int Contact { get; set; }
            public string TeamLeader { get; set; }
            public string AssistantTeamLeader { get; set; }
            public List<Activity> Activities { get; set; } = new List<Activity>();
            public void AddActiviy(double activity)
            {
                activity = 0;
                activity++;
                Activity.AddActiviy();
            }
            public List<Events> Event { get; set; } = new List<Events>();

            public void ListEvents(double events)
            {
                events = 0;
                events++;
                return new List<Event>();
            }

            public void RegisterEvent()
            {
                if (ListEvents.Count == 0)
                {
                    Console.WriteLine("Enter the name of event yu want to register:");
                    Console.ReadLine();
                }
                else
                {
                    Console.WtiteLine("Sorry! You cannot register an event.");

                }
            }


        }
        public void AddSociety(double s, double c)
        {
            s = new Society();
            c = new Contact();
            double fundedsociety = 0;
            if (s = FundedSociety)
            {
                Console.WriteLine("Enter the name of new funded  society you want to add: ");
                Console.ReadLine();
                Console.WriteLine("Enter the contact number of new society:");
                Console.ReadLine();
                Console.WriteLine("Congratulations! Society added successfulyy.");
            }
            else
            {
                Console.WriteLine("Sorry ! you cannot add society.");
            }
        }
            public class FundedSociety : Society
            {
                public int fundingamount { get; set; }
                public double TechBitsociety = 600;
                public double SportsSociety = 500;
                public List<FundedSociety> FundedSocieties { get; set; } = new List<FundedSociety>();
                public void Funds()
                {
                    double fund;
                    Console.WriteLine("The funds collection of society is:" + fund);
                    Console.ReadLine();
                }

                public AddFunds(double funds)
                {
                    if (Funds > 0)
                    {
                        double amount;
                        Console.WriteLine("Enter the amount of funds you want to submit:");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("No funds can be added..");
                    }
                }
                public void DisplayFunds()
                {
                    Console.WriteLine("The funds in this society are:" + funds);
                }

            }
            public class NonFundedSociety : Society
            {
            NonFundedSociety();
            }
            public void EventDisplay()
            {
                double totalevents = 0;
                foreach (int events=0;events<= ListEvents;i++)
                    {
                    Console.WriteLine("The total events are: " + totalevents);

                }
            }
            public class ClubRole
            {
                public string RoleName { get; set; }
                public string Role { get; set; }
                public string CotactInfo { get; set; }
            public string ClubPresident { get; set; }
            public string VicePresident { get; set; }
            public string GeneralSectory { get; set; }
            public string FinanceSectory { get; set; }

            double ClubPresident = new ClubRole();
            double VicePresident = new ClubRole();
            double GeneralPresident = new ClubRole();
            double FinancePresident = new ClubRole();


        }
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("                               Stuent Club Management System.                                             ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  1. Register a new Society. ");
            Console.WriteLine("  2. Allocate funding to societies. ");
            Console.WriteLine("  3. Register an event for a society. ");
            Console.WriteLine("  4. Display society Finding Information.");
            Console.WriteLine("  5. Display events for a society. ");
            Console.WriteLine("  6. Exit.");
           switch(choice)
            {
                case 1:
                    {
                        AddSociety();
                        Console.ReadLine();
                    }
                case 2:
                    {
                        AddFunds();
                        Console.ReadLine();

                    }
                case 3:
                    {
                        RegisterEvent();
                        Console.ReadLine();

                    }
                case 4:
                    {
                        DisplayFunds();
                        Console.ReadLine();

                    }
                case 5:
                    {
                        EventDisplay();
                        Console.ReadLine();

                    }

            }
        }
    }
}




























