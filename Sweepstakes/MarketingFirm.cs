using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public Sweepstakes sweepstakes;
        public ManagerFactory manager;
        public Contestant contestant;
        public string sweepstakeName;
        
        ISweepstakesManager manageSweepstakes;

        public MarketingFirm(ISweepstakesManager manageSweepstakes)
        {
            this.manageSweepstakes = manageSweepstakes;
        }

        public void RunSweepstakes()
        {
            Console.WriteLine("What would you like to call your new Sweepstakes?");
            string sweepstakeName = Console.ReadLine();
            sweepstakes = new Sweepstakes(sweepstakeName);
            manageSweepstakes.InsertSweepstakes(sweepstakes);
            sweepstakes.PickWinner();
        }

       
    }
}
