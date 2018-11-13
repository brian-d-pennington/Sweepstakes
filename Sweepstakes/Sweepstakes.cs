using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<Contestant, int> registeredContestants = new Dictionary<Contestant, int>();

        Sweepstakes(string name)
        {
            
        }

        
        void RegisterContestant(Contestant contestant)
        {
            contestant.GetRegistrationNumber();
            registeredContestants.Add(contestant, contestant.registrationNumber);
        }

        public string PickWinner()
        {
            Random winningPick = new Random();
            int sweepstakesWinner = winningPick.Next(1, registeredContestants.Count) + 1000;
            foreach (KeyValuePair<Contestant, int> contestant in registeredContestants)
            {
                if (contestant.Value == sweepstakesWinner)
                {
                    Console.WriteLine("Winner: " + contestant.firstName + " " + contestant.lastName + "!");
                }
                    
            }

        }

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine("registration number: " + contestant.registrationNumber);
        }
    }
}
