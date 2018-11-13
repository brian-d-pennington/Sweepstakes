using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Sweepstakes(string name)
        {

        }

        void RegisterContestant(Contestant contestant)
        {
            Dictionary<string, int> registeredContestants = new Dictionary<string, int>();
            registeredContestants.Add(contestant.lastName, contestant.registrationNumber);
        }

        string PickWinner()
        {

        }

        void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
