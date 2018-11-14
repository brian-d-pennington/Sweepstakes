using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class ManagerFactory
    {
        public static ISweepstakesManager SweepstakesAssign()
        {
            Console.WriteLine("Choose between 'queue' or 'stack' management system.");

            string managerEntry = Console.ReadLine().ToLower();
            switch (managerEntry)
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
