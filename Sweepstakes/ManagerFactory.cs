using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
        public void SweepstakesAssign()
        {
            Console.WriteLine("Choose between 'queue' or 'stack' management system.");

            string managerEntry = Console.ReadLine();
            switch (managerEntry)
            {
                case "queue":
                    new SweepstakesQueueManager();
                    break;
                case "stack":
                    new SweepstakesStackManager();
                    break;
                default:
                    throw new ApplicationException(string.Format("Not a valid choice."));
                   
            }
        }
    }
}
