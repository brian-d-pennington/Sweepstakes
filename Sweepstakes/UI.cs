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
    }
}
