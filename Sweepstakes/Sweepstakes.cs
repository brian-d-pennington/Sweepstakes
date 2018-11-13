using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<string, int> registeredContestants = new Dictionary<string, int>();

        Sweepstakes(string name)
        {

        }

        
        void RegisterContestant(Contestant contestant)
        {
            contestant.GetRegistrationNumber();
            registeredContestants.Add(contestant.lastName, contestant.registrationNumber);
        }

        string PickWinner()
        {
           
        }

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine("registration number: " + contestant.registrationNumber);
        }
    }
}
