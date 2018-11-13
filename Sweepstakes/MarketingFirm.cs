using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {

        ISweepstakesManager manageSweepstakes;
        public MarketingFirm(ISweepstakesManager manageSweepstakes)
        {
            Console.WriteLine("Choose between 'queue' or 'stack' management system.");

            string managerEntry = Console.ReadLine();
            switch (managerEntry)
            {
                case "queue":
                    manageSweepstakes = new SweepstakesQueueManager();
                    break;
                case "stack":
                    manageSweepstakes = new SweepstakesStackManager();
                    break;
                default:
                    throw new ApplicationException(string.Format("Not a valid choice."));
                    break;
            }
        }
    }
}
