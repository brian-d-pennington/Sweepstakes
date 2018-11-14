using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {
        public static string first;
        public static string last;
        public static string email;

        public static bool contestantEntered;
        public static string confirmInfo;
        public static int registrationNumber;
        public static int firstRegisterNumber = 1000;



        public static void ContestantEntersPersonalInfo()
        {
            if (contestantEntered == false)
            {
                GetContestantFirstName();
                GetContestantLastName();
                GetContestantEmail();
                GetRegistrationNumber();
                ConfirmPersonalInfo();
                ContestantEntered();
            }
        }
        public static void GetRegistrationNumber()
        {
            firstRegisterNumber++;
            registrationNumber = firstRegisterNumber;
        }
        public static void ContestantEntered()
        {
            contestantEntered = false;

            if (confirmInfo == "y")
            {
                contestantEntered = true;
            }
            else
            {
                contestantEntered = false;
            }
        }

        public static void GetContestantFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            first = Console.ReadLine();
        }

        public static void GetContestantLastName()
        {
            Console.WriteLine("And now your last name: ");
            last = Console.ReadLine();
        }

        public static void GetContestantEmail()
        {
            Console.WriteLine("What is your email address?");
            email = Console.ReadLine();
        }

        public static void ConfirmPersonalInfo()
        {
            Console.WriteLine("Does this look correct?");
            Console.WriteLine(first + " " + last);
            Console.WriteLine(email);
            Console.WriteLine("Yes: type Y, No: type N");
            confirmInfo = Console.ReadLine().ToLower();
        }
    }
}
