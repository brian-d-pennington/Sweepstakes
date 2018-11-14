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

        string PickWinner()
        {
            string winningRegistrationNumber;

            Random winningPick = new Random();
            int sweepstakesPick = winningPick.Next(1, registeredContestants.Count) + 1000;
            foreach (KeyValuePair<Contestant, int> contestant in registeredContestants)
            {
                if (contestant.Value == sweepstakesPick)
                {
                    winningRegistrationNumber = contestant.Value.ToString();
                    return winningRegistrationNumber;
                }
               
            } return "winner";
            
        }

        void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine("registration number: " + contestant.registrationNumber);
        }
    }
}
