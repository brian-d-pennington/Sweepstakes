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
            switch (item.ToLower())
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid choice."));
            }
        }
    }
}
